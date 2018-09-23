using MineSweeperClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MineSweeperClient
{
    /// <summary>
    /// Interaction logic for GameLobbyWindow.xaml
    /// </summary>
    public partial class GameLobbyWindow : Window
    {
        public GameLobbyWindow()
        {
            InitializeComponent();
        }

        public string Username { get; set; }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
//            MainWindow.callback.startGamePutRequest += StartGameRequest;
//            Callback.requestDenied       += RequestDenied;
//            Callback.startGame           += StartGame;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow.client.ClientDisconnected(Username);
            Environment.Exit(Environment.ExitCode);
        }

//        private void StartGameRequest(string fromClient)
//        {
//            var result = MessageBox.Show(fromClient + " invites you to play, do you accept?" , "Game Request", MessageBoxButton.YesNo);
//            if (result == MessageBoxResult.Yes)
//            {
//            /*    ChooseSizeWindow choose = new ChooseSizeWindow();
//                choose.Client = Client;
//                choose.Callback = Callback;
//                choose.Username = Username;
//                choose.Rival = fromClient;
//                choose.ShowDialog();*/

//            }
//            if (result == MessageBoxResult.No)
//            {
//                Client.DenyGameRequest(Username, fromClient);
//            }
//        }

//        private void RequestDenied(string fromClient)
//        {
//            MessageBox.Show(fromClient + " does not want to play", "Game Request denied", MessageBoxButton.OK);
//        }

        private void StartGame(string fromClient, int size, int mines, Tuple<int, int>[] minesPositions, bool flag)
        {

        }

        private void OnePlayer_Click(object sender, RoutedEventArgs e)
        {
            SinglePlayerGame game = new SinglePlayerGame();
            game.ShowDialog();
        }

        private void TwoPlayers_Click(object sender, RoutedEventArgs e)
        {
            TwoPlayerGame game = new TwoPlayerGame();
            game.ShowDialog();
        }

        private void ShowGamesButton_Click(object sender, RoutedEventArgs e)
        {
            ShowAllDataWindow showAllDataWindow = new ShowAllDataWindow();
            showAllDataWindow.Datatype = ShowAllDataWindow.DataType.GAMES;
            showAllDataWindow.ShowDialog();

        }

        private void ShowPlayersButton_Click(object sender, RoutedEventArgs e)
        {
            ShowAllDataWindow showAllDataWindow = new ShowAllDataWindow();
            showAllDataWindow.Datatype = ShowAllDataWindow.DataType.PLAYERS;
            showAllDataWindow.ShowDialog();

        }
    }
}
