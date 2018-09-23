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
    /// Interaction logic for ChooseBoardWindow.xaml
    /// </summary>
    public partial class ChooseBoardWindow : Window
    {
        private int _boardSize;
        private int _numberOfMines;

        public int BoardSize
        {
            get { return _boardSize; }
            set
            {
                if (value < 5 || value > 20)
                {
                    throw new InvalidBoardParameters("invalid board size");
                }
                _boardSize = value;
            }
        }
        public int NumberOfMines
        {
            get => _numberOfMines;
            set
            {
                if (value < 5 || value > 400)
                {
                    throw new InvalidBoardParameters("Invalid number of mines");
                }
                _numberOfMines = value;
            }
        }

        public ChooseBoardWindow()
        {
            InitializeComponent();
        }

        private void EasyButton_Click(object sender, RoutedEventArgs e)
        {
            BoardSize = 9;
            NumberOfMines = 10;
            Close();
        }

        private void MediumButton_Click(object sender, RoutedEventArgs e)
        {
            BoardSize = 16;
            NumberOfMines = 40;
            Close();
        }

        private void HardButton_Click(object sender, RoutedEventArgs e)
        {
            BoardSize = 20;
            NumberOfMines = 99;
            Close();
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BoardSize = int.Parse(BoardSizeTextBox.Text.Trim());
                NumberOfMines = int.Parse(NumberOfMinesTextBox.Text.Trim());

                if (NumberOfMines >= BoardSize * BoardSize)
                {
                    BoardSize = NumberOfMines = 0;
                    throw new InvalidBoardParameters("invalid ratio of mines to board size");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
