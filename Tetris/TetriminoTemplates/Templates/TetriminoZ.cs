namespace Tetris.TetriminoTemplates.Templates
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
        
        protected override void createBounds()
        {
            string[] bottomBounds = new string[] { "122-", "-21-", "-122", "-32-" };
            string[] leftBounds = new string[] { "-01-", "211-", "-12-", "-211" };
            string[] rightBounds = new string[] { "-12-", "221-", "-23-", "-221" };

            bounds = new Bounds(bottomBounds, leftBounds, rightBounds);
        }
    }
}