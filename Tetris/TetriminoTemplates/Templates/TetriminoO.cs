namespace Tetris.TetriminoTemplates.Templates
{
    class TetriminoO : Tetrimino
    {
        public TetriminoO()
        {
            Id = 3;
            X = 5;
            Y = 0;
            Dimension = 4;
            Piece = "0000011001100000";
            Length = Piece.Length;

            createStates();
            createBounds();
        }

        public override void createStates()
        {
            States = new string[] { "0000011001100000", "0000011001100000", "0000011001100000", "0000011001100000" };
        }
        
        public override void createBounds()
        {
            createBottomBounds();
            createLeftBounds();
            createRightBounds();
        }

        private void createBottomBounds()
        {
            BottomBounds = new string[] { "-22-", "-22-", "-22-", "-22-" };
        }

        private void createLeftBounds()
        {
            LeftBounds = new string[] { "-11-", "-11-", "-11-", "-11-" };
        }

        private void createRightBounds()
        {
            RightBounds = new string[] { "-22-", "-22-", "-22-", "-22-" };
        }
    }
}