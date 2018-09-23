using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace MineSweeperServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
     ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class MineSweeperService : IMineSweeperService
    {
        SortedDictionary<string, IMineSweeperServiceCallback> callbacks = new SortedDictionary<string, IMineSweeperServiceCallback>();

        public void ClientConnected(string username)
        {
            if (!PlayerExists(username))
            {
                throw new FaultException<UserExistsFault>(
                    new UserExistsFault { Message = username + " already exists" }, new FaultReason(username + " already exists"));
            }
            if (callbacks.ContainsKey(username))
            {
                throw new FaultException<UserExistsFault>(
                    new UserExistsFault { Message = username + " already exists" }, new FaultReason(username + " already exists"));
            }
            try
            {
                IMineSweeperServiceCallback callback =
                    OperationContext.Current.GetCallbackChannel
                    <IMineSweeperServiceCallback>();
                callbacks.Add(username, callback);
                UpdateUsersList();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        private void UpdateUsersList()
        {
            Thread updateListThread = new Thread(() => {
                foreach (var callback in callbacks.Values) {
                    callback.UpdatePlayerList(callbacks.Keys);
                }
            });
            updateListThread.Start();
        }

        public void ClientDisconnected(string username)
        {
            callbacks.Remove(username);
            UpdateUsersList();
        }

        public bool PlayerExists(string username)
        {
            using (MinesweeperDataBaseEntities ctx = new MinesweeperDataBaseEntities()) {
                return (from p in ctx.Players
                        where p.UserName == username
                        select p.UserName).ToList().Count != 0;
            }
        }

        public bool IsLegalUser(string username, string password)
        {
            using (MinesweeperDataBaseEntities ctx = new MinesweeperDataBaseEntities()) {
                return (from p in ctx.Players
                        where p.UserName == username && p.Password == password
                        select p.UserName).ToList().Count != 0;
            }
        }
        public void EnterPlayerToDB(Player player) {
            using (MinesweeperDataBaseEntities ctx = new MinesweeperDataBaseEntities()) {
                if (PlayerExists(player.UserName))
                {
                    throw new FaultException<UserExistsFault>(
                        new UserExistsFault { Message = player.UserName + " already exists" }, new FaultReason(player.UserName + " already exists"));
                }
                else
                {
                    ctx.Players.Add(player);
                    ctx.SaveChanges();
                }
            }
        }

        public void SendRequest(string fromPlayer, string toPlayer) {
            Thread startGame = new Thread(() => {
               callbacks[toPlayer].StartGamePutRequest(fromPlayer);
            });
            startGame.Start();
        }

        public List<string[]> GetAllPlayers() {
            List<string[]> allPlayerStats = new List<string[]>();

            using (MinesweeperDataBaseEntities ctx = new MinesweeperDataBaseEntities()) {
                foreach (Player p in ctx.Players.ToList()) { {
                        string[] playerStats = new string[6];
                        var gamesWon   = (from g in ctx.Games
                                        where g.Winner == p.UserName
                                        select g).ToList().Count;
                        var gamesLost = (from g in ctx.Games
                                         where g.Loser == p.UserName
                                         select g).ToList().Count;

                        var gamesTied = (from g in ctx.Games where g.Tie &&
                                         (g.Winner == p.UserName) || (g.Loser == p.UserName)
                                         select g).ToList().Count;
                        var totalGames = gamesWon + gamesLost + gamesTied;

                        var winPercent = totalGames == 0 ? 0 : (double)gamesWon / totalGames;

                        playerStats[0] = p.UserName;
                        playerStats[1] = gamesWon.ToString();
                        playerStats[2] = gamesLost.ToString();
                        playerStats[3] = gamesTied.ToString();
                        playerStats[4] = totalGames.ToString();
                        playerStats[5] = winPercent.ToString();

                        allPlayerStats.Add(playerStats); 
                    } 
                }
            }
            return allPlayerStats;
        }

        public List<string[]> GetAllGames() {
            List<string[]> allGames = new List<string[]>();

            using (MinesweeperDataBaseEntities ctx = new MinesweeperDataBaseEntities()) {
                foreach (Game game in ctx.Games.ToList()) {
                    string[] gameStats = new string[4];
                    gameStats[0] = game.GameDate.ToString();
                    gameStats[1] = game.Winner;
                    gameStats[2] = game.Loser;
                    gameStats[3] = game.Tie ? "YEAH" : "NOPE";

                    allGames.Add(gameStats);
                }
                return allGames;
            }
        }

        public void DenyGameRequest(string fromPlayer, string toPlayer) {
            Thread gameDenied = new Thread(() => callbacks[toPlayer].RequestDenied(fromPlayer));
            gameDenied.Start();
        }

        public void StartGameServer(string fromPlayer, string toPlayer, int size, int mines, Tuple<int, int>[] minesPositions) {
            Thread startGame = new Thread(() => {
                callbacks[toPlayer].StartGame(fromPlayer, size, mines, minesPositions, true);
                callbacks[fromPlayer].StartGame(toPlayer, size, mines, minesPositions, false);
            });
            startGame.Start();
        }

        public void SpotClicked(int row, int col, int tag, string fromPlayer, string toPlayer) {
            Thread spotClicked = new Thread(() => {
                callbacks[toPlayer].ClickSpot(row,col,tag,fromPlayer, toPlayer);
            });
            spotClicked.Start();
        }

        public void SpotFlaged(int row, int col, int tag, string fromPlayer, string toPlayer) {
            Thread spotFlaged = new Thread(() => {
                // TODO: WHAT THE FUCK IS THIS TAG MATE?
                callbacks[toPlayer].SetFlag(row,col,tag,fromPlayer);
            });
            spotFlaged.Start();
        }

        public void PlayerWon(string toPlayer) {
            Thread playerWon = new Thread(() => {
                callbacks[toPlayer].UpdateWinner();
            });
            playerWon.Start();
        }

        List<Game> OnGoingGames = new List<Game>();

        public void GameStarted(Game game) {
            OnGoingGames.Add(game);
        }

        public void GameEnded(Game game) {
            AddGameToDB(game);
            OnGoingGames.Remove(game);
        }

        private void AddGameToDB(Game game) {
            using (MinesweeperDataBaseEntities ctx = new MinesweeperDataBaseEntities()) {
                game.Id = (from g in ctx.Games select g.Id).Max()+1; 
                ctx.Games.Add(game);
            }
        }

        public List<string> GetOnGoingGames() {
            List<string> games = new List<string>();
            foreach (Game game in OnGoingGames) {
                games.Add($"Player 1: {game.Winner}, Player 2:{game.Loser}");
            }
            return games;
        }

        public void PlayerQuitInGame(string Username, string Rival) {
            //TODO: WHAT THE HECK guys this is moshey IS THIS FUNCTION MAAAAAAAAAAAAAAAAAATE
            throw new NotImplementedException();
        }
    }
}
