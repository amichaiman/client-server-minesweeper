using MineSweeperClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for ShowAllDataWindow.xaml
    /// </summary>
    public partial class ShowAllDataWindow : Window
    {
        public enum DataType { PLAYERS, GAMES };
        public DataType Datatype { get; set; }

        public ShowAllDataWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataTable data = new DataTable();
            string[][] stdata;
            if (Datatype == DataType.GAMES)
            {

                stdata = MainWindow.client.GetAllGames();
                data.Columns.Add("Date");
                data.Columns.Add("Winner");
                data.Columns.Add("Loser");
                data.Columns.Add("Tie");
                foreach (var d in stdata)
                {

                    data.Rows.Add(d[0], d[1], d[2], d[3]);
                }

            }
            else if(Datatype == DataType.PLAYERS)
            {
                stdata = MainWindow.client.GetAllPlayers();
                data.Columns.Add("Player Name");
                data.Columns.Add("Number Of Games");
                data.Columns.Add("Number Of Wins");
                data.Columns.Add("Number Of Loses");
                data.Columns.Add("Number Of Ties");
                data.Columns.Add("Percentage Of Wins");
                foreach (var d in stdata)
                {

                    data.Rows.Add(d[0], d[1], d[2], d[3], d[4], d[5]);
                }
            }
            

            dgData.ItemsSource = data.DefaultView;
        }
             
    }
}
