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

namespace MineSweeperClient {
    /// <summary>
    /// Interaction logic for ChoosePlayerWindow.xaml
    /// </summary>
    public partial class ChoosePlayerWindow : Window {
        public ChoosePlayerWindow() {
            InitializeComponent();
        }

        public void UpdatePlayerList(List<string> players) {
            PlayersListBox.ItemsSource = players;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            MainWindow.callback.updatePlayerList += UpdatePlayerList; 
        }

        private void GoButton_Click(object sender, RoutedEventArgs e) {
            if (PlayersListBox.SelectedItem == null) {
                MessageBox.Show("no player has been selected");
                return;
            } 
        }
    }
}
