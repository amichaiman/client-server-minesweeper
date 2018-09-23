using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MineSweeperServer
{


    [ServiceContract(CallbackContract = typeof(IMineSweeperServiceCallback))]
    public interface IMineSweeperService
    {
        [OperationContract]
        [FaultContract(typeof(UserExistsFault))]
        /*  connects client     */
        void ClientConnected(string username);
        [OperationContract]
        /*  disconnects client  */
        void ClientDisconnected(string username);
        [OperationContract]
        /*  searches for a player in db with username */
        bool PlayerExists(string player);
        [OperationContract]
        /*  returns true if given username and password are legal */
        bool IsLegalUser(string username, string password);
        [OperationContract]
        [FaultContract(typeof(UserExistsFault))]
        /*  enters username to db */
        void EnterPlayerToDB(Player player);
        [OperationContract]
        /*sends a game request to a player*/
        void SendRequest(string fromPlayer, string toPlayer);
        [OperationContract]
        /*  get all players in DB   */
        List<string[]> GetAllPlayers();
        [OperationContract]
        /*  get all the games in DB    */
        List<string[]> GetAllGames();
        [OperationContract]
        /*  game denied by player */
        void DenyGameRequest(string fromPlayer, string toPlayer);
        [OperationContract]
        /*  start game  */
        void StartGameServer(string fromPlayer, string toPlayer, int size, int mines, Tuple<int, int>[] minesPositions);
        [OperationContract]
        /*  click spot on board  */
        void SpotClicked(int row, int col,int tag, string fromPlayer, string toPlayer);
        [OperationContract]
        /*  flag spot on board   */
        void SpotFlaged(int row, int col, int tag, string fromPlayer, string toPlayer);
        [OperationContract]
        /*  player has won  */
        void PlayerWon(string toPlayer);
        [OperationContract]
        /*  game started */
        void GameStarted(Game game);
        [OperationContract]
        /*  game ended */
        void GameEnded(Game game);
        [OperationContract]
        /*  get list of on-going games  */
        List<string> GetOnGoingGames();
        [OperationContract]
        /*  player quit during the game   */
       void PlayerQuitInGame(string Username, string Rival);
    }

    public interface IMineSweeperServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        /*  updates player list */
        void UpdatePlayerList(IEnumerable<string> players);
        [OperationContract(IsOneWay = true)]
        /*  sends player a game request */
        void StartGamePutRequest(string fromPlayer);
        [OperationContract(IsOneWay = true)]
        /*  sends message to client   */
        void PutMessage(string message ,string fromPlayer);
        [OperationContract(IsOneWay = true)]
        /*  send message if game request was denied  */
        void RequestDenied(string username);
        [OperationContract(IsOneWay = true)]
        /*  player started a game   */
        void StartGame(string fromPlayer, int size, int mines,Tuple<int,int>[] minesPositions, bool flag);
        [OperationContract(IsOneWay = true)]
        /*  spot clicked  */
        void ClickSpot(int row, int col,int tag, string fromPlayer, string other);
        [OperationContract(IsOneWay = true)]
        /*  flag clicked  */
        void SetFlag(int row, int col, int tag, string fromPlayer);
        [OperationContract(IsOneWay = true)]
        /*  update player that he has won */
        void UpdateWinner();
        [OperationContract(IsOneWay = true)]
        /*  when user presses exit button, server activates that function   */
        void UserExit(string activator, string other);
    }

}
