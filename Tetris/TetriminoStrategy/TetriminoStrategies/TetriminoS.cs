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
            statesDictionary = new Dictionary<int, string> { };

            statesDictionary.Add(0, "0000011001100000");
            statesDictionary.Add(1, "0100011000100000");
            statesDictionary.Add(2, "0000001101100000");
            statesDictionary.Add(3, "0000010001100010");
        }
        
        public override void createBounds()
        {
            createBottomBounds();
            createLeftBounds();
            createRightBounds();
        }

        private void createBottomBounds()
        {
            bottomBoundsDictionary = new Dictionary<int, string> { };

            bottomBoundsDictionary.Add(0, "221-");
            bottomBoundsDictionary.Add(1, "-12-");
            bottomBoundsDictionary.Add(2, "-221");
            bottomBoundsDictionary.Add(3, "-23-");
        }

        private void createLeftBounds()
        {
            leftBoundsDictionary = new Dictionary<int, string> { };

            leftBoundsDictionary.Add(0, "-10-");
            leftBoundsDictionary.Add(1, "112-");
            leftBoundsDictionary.Add(2, "-21-");
            leftBoundsDictionary.Add(3, "-112");
        }
        
        private void createRightBounds()
        {
            rightBoundsDictionary = new Dictionary<int, string> { };

            rightBoundsDictionary.Add(0, "-21-");
            rightBoundsDictionary.Add(1, "122-");
            rightBoundsDictionary.Add(2, "-32-");
            rightBoundsDictionary.Add(3, "-122");
        }
    }
}
