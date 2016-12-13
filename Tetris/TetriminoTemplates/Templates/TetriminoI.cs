namespace Tetris.TetriminoTemplates.Templates
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
            CurrentState = 0;

            createStates();
            createBounds();
        }
        
        public override void createStates()
        {
            States = new string[] { "0000111100000000", "0010001000100010", "0000000011110000", "0100010001000100" };
        }

        protected override void createBounds()
        {
            string[] bottomBounds = new string[] { "1111", "--3-", "2222", "-3--" };
            string[] leftBounds = new string[] { "-0--", "2222", "--0-", "1111" };
            string[] rightBounds = new string[] { "-3--", "2222", "--3-", "1111" };

            bounds = new Bounds(bottomBounds, leftBounds, rightBounds);
        }
    }
}