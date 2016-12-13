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
            CurrentState = 0;

            createStates();
            createBounds();
        }

        public override void createStates()
        {
            States = new string[] { "0000011001100000", "0000011001100000", "0000011001100000", "0000011001100000" };
        }
        
        protected override void createBounds()
        {
            string[] bottomBounds = new string[] { "-22-", "-22-", "-22-", "-22-" };
            string[] leftBounds = new string[] { "-11-", "-11-", "-11-", "-11-" };
            string[] rightBounds = new string[] { "-22-", "-22-", "-22-", "-22-" };

            bounds = new Bounds(bottomBounds, leftBounds, rightBounds);
        }
    }
}