using MineSweeperClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperClient
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class ClientCallback : IMineSweeperServiceCallback
    {
        public delegate void PutMessageDelegate(string m, string fc);
        public event PutMessageDelegate putMessage;
        public void PutMessage(string message, string fromClient)
        {
            putMessage(message, fromClient);
        }

        public delegate void UpdatePlayersDelegate(List<string> player);
        public event UpdatePlayersDelegate updatePlayerList;

        public void UpdatePlayerList(List<string> player)
        {
            updatePlayerList(player);
        }

        public void UpdatePlayerList(string[] player)
        {
//            updatePlayerList(player.ToList());
        }


        public delegate void StartGamePutRequestDelegate(string fromClient);
        public event StartGamePutRequestDelegate startGamePutRequest;
        public void StartGamePutRequest(string fromPlayer)
        {
            startGamePutRequest(fromPlayer);
        }

        public delegate void RequestDeniedDelegate(string fromClient);
        public event RequestDeniedDelegate requestDenied;
        public void RequestDenied(string fromClient)
        {
            requestDenied(fromClient);
        }

        public delegate void StartGameDelegate(string fromClient, int size, int mines, Tuple<int, int>[] minesPositions, bool flag);
        public event StartGameDelegate startGame;
        public void StartGame(string fromClient, int size, int mines, Tuple<int, int>[] minesPositions, bool flag)
        {
            startGame(fromClient, size, mines, minesPositions, flag);
        }
        
        public void ClickSpot(int row, int col, int tag, string fromPlayer, string other)
        {
            throw new NotImplementedException();
        }

        public void SetFlag(int row, int col, int tag, string fromPlayer)
        {
            throw new NotImplementedException();
        }

        public void UpdateWinner()
        {
            throw new NotImplementedException();
        }

        public void UserExit(string activator, string other)
        {
            throw new NotImplementedException();
        }

    }
}
