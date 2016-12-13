using System.Collections.Generic;

namespace Tetris.TetriminoStrategies
{
    class TetriminoS : Tetrimino
    {
        public TetriminoS()
        {
            Id = 4;
            X = 5;
            Y = 0;
            Dimension = 4;
            Piece = "0000011011000000";
            Length = Piece.Length;

            createStates();
            createBounds();
        }

        public override void createStates()
        {
            States = new string[] { "0000011001100000", "0100011000100000", "0000001101100000", "0000010001100010" };
        }
        
        public override void createBounds()
        {
            createBottomBounds();
            createLeftBounds();
            createRightBounds();
        }

        private void createBottomBounds()
        {
            BottomBounds = new string[] { "221-", "-12-", "-221", "-23-" };
        }

        private void createLeftBounds()
        {
            LeftBounds = new string[] { "-10-", "112-", "-21-", "-112" };
        }
        
        private void createRightBounds()
        {
            RightBounds = new string[] { "-21-", "122-", "-32-", "-122" };
        }
    }
}