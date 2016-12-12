using System.Collections.Generic;

namespace Tetris.TetriminoStrategies
{
    class TetriminoT : TetriminoStrategy
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
            statesDictionary = new Dictionary<int, string> { };

            statesDictionary.Add(0, "0000111001000000");
            statesDictionary.Add(1, "0010011000100000");
            statesDictionary.Add(2, "0000010001100100");
            statesDictionary.Add(3, "0000111001000000");
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

            bottomBoundsDictionary.Add(0, "121-");
            bottomBoundsDictionary.Add(1, "-12-");
            bottomBoundsDictionary.Add(2, "-222");
            bottomBoundsDictionary.Add(3, "-32-");
        }

        private void createLeftBounds()
        {
            leftBoundsDictionary = new Dictionary<int, string> { };

            leftBoundsDictionary.Add(0, "-01-");
            leftBoundsDictionary.Add(1, "212-");
            leftBoundsDictionary.Add(2, "-21-");
            leftBoundsDictionary.Add(3, "-111");
        }
        
        private void createRightBounds()
        {
            rightBoundsDictionary = new Dictionary<int, string> { };

            rightBoundsDictionary.Add(0, "-21-");
            rightBoundsDictionary.Add(1, "222-");
            rightBoundsDictionary.Add(2, "-23-");
            rightBoundsDictionary.Add(3, "-121");
        }
    }
}
