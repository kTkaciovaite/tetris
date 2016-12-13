namespace Tetris.TetriminoStrategies
{
    class TetriminoZ : Tetrimino
    {
        public TetriminoZ()
        {
            Id = 6;
            X = 5;
            Y = 0;
            Dimension = 4;
            Piece = "0000110001100000";
            Length = Piece.Length;

            createStates();
            createBounds();
        }

        public override void createStates()
        {
            States = new string[] { "0000110001100000", "0010011001000000", "0000011000110000", "0000001001100100" };
        }
        
        public override void createBounds()
        {
            createBottomBounds();
            createLeftBounds();
            createRightBounds();
        }

        private void createBottomBounds()
        {
            BottomBounds = new string[] { "122-", "-21-", "-122", "-32-" };
        }

        private void createLeftBounds()
        {
            LeftBounds = new string[] { "-01-", "211-", "-12-", "-211" };
        }
        
        private void createRightBounds()
        {
            RightBounds = new string[] { "-12-", "221-", "-23-", "-221" };
        }
    }
}