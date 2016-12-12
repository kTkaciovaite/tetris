using System.Collections.Generic;

namespace Tetris.TetriminoStrategies
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
            Length = Piece.Length;

            createStates();
            createBounds();
        }
        
        public override void createStates()
        {
            statesDictionary = new Dictionary<int, string> { };

            statesDictionary.Add(0, "0000111100000000");
            statesDictionary.Add(1, "0010001000100010");
            statesDictionary.Add(2, "0000000011110000");
            statesDictionary.Add(3, "0100010001000100");
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

            bottomBoundsDictionary.Add(0, "1111");
            bottomBoundsDictionary.Add(1, "--3-");
            bottomBoundsDictionary.Add(2, "2222");
            bottomBoundsDictionary.Add(3, "-3--");
        }

        private void createLeftBounds()
        {
            leftBoundsDictionary = new Dictionary<int, string> { };

            leftBoundsDictionary.Add(0, "-0--");
            leftBoundsDictionary.Add(1, "2222");
            leftBoundsDictionary.Add(2, "--0-");
            leftBoundsDictionary.Add(3, "1111");
        }

        private void createRightBounds()
        {
            rightBoundsDictionary = new Dictionary<int, string> { };

            rightBoundsDictionary.Add(0, "-3--");
            rightBoundsDictionary.Add(1, "2222");
            rightBoundsDictionary.Add(2, "--3-");
            rightBoundsDictionary.Add(3, "1111");
        }
    }
}
