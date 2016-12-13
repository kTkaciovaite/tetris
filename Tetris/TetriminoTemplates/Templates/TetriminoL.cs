namespace Tetris.TetriminoTemplates.Templates
{
    class TetriminoL : Tetrimino
    {
        public TetriminoL()
        {
            Id = 2;
            X = 5;
            Y = 0;
            Dimension = 4;
            Piece = "0000011101000000";
            Length = Piece.Length;

            createStates();
            createBounds();
        }

        public override void createStates()
        {
            States = new string[] { "0000011101000000", "0000011000100010", "0000001011100000", "0100010001100000" };
        }

        protected override void createBounds()
        {
            string[] bottomBounds = new string[] { "-211", "-13-", "222-", "-22-" };
            string[] leftBounds = new string[] { "-11-", "-122", "-20-", "112-" };
            string[] rightBounds = new string[] { "-31-", "-222", "-22-", "112-" };

            bounds = new Bounds(bottomBounds, leftBounds, rightBounds);
        }
    }
}