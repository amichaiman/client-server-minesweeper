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
using System.Windows.Shapes;
using MineSweeperClient.ServiceReference1;

namespace MineSweeperClient
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        public MineSweeperServiceClient client { get; set; }
        public ClientCallback callback { get; set; }

        private void RegisterButton_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(UsernameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                MessageBox.Show("username or password missing", "error", MessageBoxButton.OK);                                                       
            }
            //searching for username in db. if exists, return false
            //else adds client to db and returns false
            try
            {
                if (client.PlayerExists(UsernameTextBox.Text.Trim()))
                {
                    MessageBox.Show("username " + UsernameTextBox.Text.Trim() + " already exists");
                }
                else
                {
                    Player player = new Player();
                    player.UserName = UsernameTextBox.Text.Trim();
                    player.Password = PasswordTextBox.Text.Trim();
                    client.EnterPlayerToDB(player);
                    this.Close();
                }
            } catch (FaultException<UserExistsFault> f) { 
                MessageBox.Show(f.Message);
            }
        }
    }
}
