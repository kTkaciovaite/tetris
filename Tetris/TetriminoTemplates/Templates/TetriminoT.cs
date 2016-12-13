namespace Tetris.TetriminoTemplates.Templates
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
            CurrentState = 0;

            createStates();
            createBounds();
        }
        
        public override void createStates()
        {
            States = new string[] { "0000111001000000", "0010011000100000", "0000010001100100", "0000111001000000" };
        }
        
        protected override void createBounds()
        {
            string[] bottomBounds = new string[] { "121-", "-12-", "-222", "-32-" };
            string[] leftBounds = new string[] { "-01-", "212-", "-21-", "-111" };
            string[] rightBounds = new string[] { "-21-", "222-", "-23-", "-121" };

            bounds = new Bounds(bottomBounds, leftBounds, rightBounds);
        }
    }
}