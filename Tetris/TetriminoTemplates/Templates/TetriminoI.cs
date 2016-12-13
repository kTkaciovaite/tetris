namespace Tetris.TetriminoStrategies
{
    class TetriminoI : Tetrimino
    {
        public TetriminoI()
        {
            Id = 0;
            X = 5;
            Y = 0;
            Dimension = 4;
            Piece = "0000111100000000";
            Length = Piece.Length;

            createStates();
            createBounds();
        }
        
        public override void createStates()
        {
            States = new string[] { "0000111100000000", "0010001000100010", "0000000011110000", "0100010001000100" };
        }

        public override void createBounds()
        {
            createBottomBounds();
            createLeftBounds();
            createRightBounds();
        }

        private void createBottomBounds()
        {
            BottomBounds = new string[] { "1111", "--3-", "2222", "-3--" };
        }

        private void createLeftBounds()
        {
            LeftBounds = new string[] { "-0--", "2222", "--0-", "1111" };
        }

        private void createRightBounds()
        {
            RightBounds = new string[] { "-3--", "2222", "--3-", "1111" };
        }
    }
}