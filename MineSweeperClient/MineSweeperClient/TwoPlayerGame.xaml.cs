using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;

namespace MineSweeperClient
{
    /// <summary>
    /// Interaction logic for SinglePlayerGame.xaml
    /// </summary>
    public partial class TwoPlayerGame : Window
    {
        private Spot[,] logicalBoard;
        private int boardSize;
        private int numberOfMines;
        private int spotsRevealed;

        public const int NUMBER_OF_AJECENT_SQUARES = 8;

        public TwoPlayerGame()
        {
            ChoosePlayerWindow choosePlayerWindow = new ChoosePlayerWindow();
            choosePlayerWindow.ShowDialog();
 
            ChooseBoardWindow chooseBoardWindow = new ChooseBoardWindow();
            chooseBoardWindow.ShowDialog();
            numberOfMines = chooseBoardWindow.NumberOfMines;
            boardSize = chooseBoardWindow.BoardSize;
            InitializeComponent();

            NumberOfMinesTextBox.Text = numberOfMines.ToString();
            CreateBoard();
        }

        private void CreateBoard() {
            logicalBoard = new Spot[boardSize, boardSize];
            spotsRevealed = 0;
            //create buttons
            for (int i = 0; i < boardSize*boardSize; ++i)
            {
                Button button = new Button() {
                    Tag = i //i/boardsize is line, i%boardsize is column
                };
                //set button's background
                BitmapImage bitimg = new BitmapImage();
                bitimg.BeginInit();
                bitimg.UriSource = new Uri(@"Images/square.png", UriKind.RelativeOrAbsolute);
                bitimg.EndInit();

                Image img = new Image();
                img.Stretch = Stretch.Fill;
                img.Source = bitimg;
                button.Background = new ImageBrush(bitimg);

                //function to handle button click event
                button.Click += new RoutedEventHandler(button_clicked);
                //add button to board
                board.Children.Add(button);

                //init spot in logicalboard
                logicalBoard[i / boardSize, i % boardSize] = new Spot();
            }
            AddMines(); 
        }

        private void AddMines() {
            Random r = new Random();
            int[] ajecentI = { 1, 1, 1, 0, 0, -1, -1, -1};
            int[] ajecentJ = { -1, 0, 1, -1, 1, -1, 0, 1};
            int minesToPut = numberOfMines;           
            while (minesToPut > 0) {
                int row = r.Next() % boardSize;
                int col = r.Next() % boardSize;

                if (!logicalBoard[row, col].IsMine) {
                    logicalBoard[row, col].IsMine = true;
                    minesToPut--;
                    for(int i=0; i<NUMBER_OF_AJECENT_SQUARES; i++) {
                        if (IsInBoard(row+ajecentI[i], col+ajecentJ[i])) {
                            logicalBoard[row + ajecentI[i], col + ajecentJ[i]].NumberOfNeighborMines++; 
                        }
                    }
                }
            }
        }

        private bool IsInBoard(int row, int col) {
            return row >= 0 && row < boardSize && col >= 0 && col < boardSize;
        }

        private void button_clicked(object sender, RoutedEventArgs e) {
            Button b = sender as Button;
            int row = int.Parse(b.Tag.ToString()) / boardSize;
            int col = int.Parse(b.Tag.ToString()) % boardSize;

            if (logicalBoard[row, col].IsVisible) {
                return;
            }
            
            SetButtonBackground(b, row, col, true);
            logicalBoard[row, col].IsVisible = true;
            spotsRevealed++;
            if (logicalBoard[row, col].IsMine) {
                MessageBox.Show("haha you lose!");
                ShowBoard();
            }
            if (spotsRevealed == boardSize*boardSize-numberOfMines) {
                MessageBox.Show("you win!");
                ShowBoard();
                return;
            }
            //open recursively
            if (logicalBoard[row, col].NumberOfNeighborMines == 0) {
                int[] ajecentI = { 1, 1, 1, 0, 0, -1, -1, -1};
                int[] ajecentJ = { -1, 0, 1, -1, 1, -1, 0, 1};
                for (int i = 0; i < NUMBER_OF_AJECENT_SQUARES; i++) {
                    if (IsInBoard(row + ajecentI[i], col + ajecentJ[i])) {
                        button_clicked(board.Children[(row + ajecentI[i]) * boardSize + (col + ajecentJ[i])], e);
                    }
                }
            }
        }

        private void SetButtonBackground(Button b, int row, int col, bool clicked) {
            BitmapImage bitimg = new BitmapImage();
            bitimg.BeginInit();
            bitimg.UriSource = GetSpotImage(row, col, clicked);
            bitimg.EndInit();
            Image img = new Image();
            img.Stretch = Stretch.Fill;
            img.Source = bitimg;
            b.Background = new ImageBrush(bitimg);
        }

        private void ShowBoard() {
            for (int i=0; i<boardSize; i++) {
                for (int j=0; j<boardSize; j++) {
                    if (!logicalBoard[i, j].IsVisible) {
                        logicalBoard[i, j].IsVisible = true;
                        Button b = board.Children[i * boardSize + j] as Button;
                        SetButtonBackground(b, i, j, false);
                    }
                }
            }

        }

        private Uri GetSpotImage(int row, int col, bool clicked) {
            if (logicalBoard[row, col].IsMine) {
                return clicked ? new Uri(@"Images/bomkclicked.jpg", UriKind.RelativeOrAbsolute) : new Uri(@"Images/mine.jpg", UriKind.RelativeOrAbsolute);
            }
            switch (logicalBoard[row, col].NumberOfNeighborMines) {
                case 0:  return new Uri(@"Images/zero.png", UriKind.RelativeOrAbsolute);
                case 1:  return new Uri(@"Images/one.png", UriKind.RelativeOrAbsolute); 
                case 2:  return new Uri(@"Images/two.png", UriKind.RelativeOrAbsolute); 
                case 3:  return new Uri(@"Images/three.png", UriKind.RelativeOrAbsolute);
                case 4:  return new Uri(@"Images/four.png", UriKind.RelativeOrAbsolute); 
                case 5:  return new Uri(@"Images/five.png", UriKind.RelativeOrAbsolute); 
                case 6:  return new Uri(@"Images/six.png", UriKind.RelativeOrAbsolute); 
                case 7:  return new Uri(@"Images/seven.png", UriKind.RelativeOrAbsolute);
                case 8:  return new Uri(@"Images/eight.png", UriKind.RelativeOrAbsolute);
                default:break;

            }
            return null;
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e) {
            Close();
        }
    }
}
