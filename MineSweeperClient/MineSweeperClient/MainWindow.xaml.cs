using MineSweeperClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MineSweeperClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ClientCallback callback;
        public static MineSweeperServiceClient client;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(UsernameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                 MessageBox.Show("username or password missing", "error", MessageBoxButton.OK);
            }
            else
            {
                ConnectToServer();
            }
            
        }

        string username;
        private void ConnectToServer()
        {
            ClientCallback callback = new ClientCallback();
            username = UsernameTextBox.Text.Trim();
            MineSweeperServiceClient client = new MineSweeperServiceClient(
                new InstanceContext(callback));
            if (!client.IsLegalUser(UsernameTextBox.Text.Trim(),PasswordTextBox.Text.Trim()))
            {
                MessageBox.Show("Invalid user name or password");
            }
            else
            {
                try
                {
                    client.ClientConnected(username);
                    GameLobbyWindow mainWindow = new GameLobbyWindow();
                    MainWindow.client = client;
                    MainWindow.callback = callback;
                    mainWindow.Username = username;
                    mainWindow.Title = username;
                    this.Close();
                    mainWindow.Show();
                }
                catch (FaultException<UserExistsFault> fe)
                {
                    MessageBox.Show(fe.Message);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e) {
            callback = new ClientCallback();
            client = new MineSweeperServiceClient(
                       new InstanceContext(callback));
            RegisterWindow wind = new RegisterWindow();
            wind.client = client;
            wind.callback = callback;
            wind.ShowDialog();

        }
    }
}
