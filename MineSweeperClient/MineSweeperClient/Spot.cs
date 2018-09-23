namespace MineSweeperClient {
    internal class Spot {
        public bool IsMine { get; set; }
        public int NumberOfNeighborMines { get; set; }
        public bool IsVisible { get; set; }
        public Spot() {
            IsMine = false;
            NumberOfNeighborMines = 0;
            IsVisible = false;
        }
    }
}