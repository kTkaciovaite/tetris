namespace Tetris.TetriminoStrategies
{
    class TetriminoT : Tetrimino
    {
        public TetriminoT()
        {
            Id = 5;
            X = 5;
            Y = 0;
            Dimension = 4;
            Piece = "0000111001000000";
            Length = Piece.Length;

            createStates();
            createBounds();
        }
        
        public override void createStates()
        {
            States = new string[] { "0000111001000000", "0010011000100000", "0000010001100100", "0000111001000000" };
        }
        
        public override void createBounds()
        {
            createBottomBounds();
            createLeftBounds();
            createRightBounds();
        }

        private void createBottomBounds()
        {
            BottomBounds = new string[] { "121-", "-12-", "-222", "-32-" };
        }

        private void createLeftBounds()
        {
            LeftBounds = new string[] { "-01-", "212-", "-21-", "-111" };
        }
        
        private void createRightBounds()
        {
            RightBounds = new string[] { "-21-", "222-", "-23-", "-121" };
        }
    }
}