using System.Collections.Generic;

namespace Tetris.TetriminoStrategies
{
    class TetriminoZ : TetriminoStrategy
    {
        public TetriminoZ()
        {
            id = 6;
            x = 5;
            y = 0;
            dimension = 4;
            tetrimino = "0000110001100000";
            tetriminoLength = tetrimino.Length;

            createStates();
            createBounds();
        }

        public override void createStates()
        {
            statesDictionary = new Dictionary<int, string> { };

            statesDictionary.Add(0, "0000110001100000");
            statesDictionary.Add(1, "0010011001000000");
            statesDictionary.Add(2, "0000011000110000");
            statesDictionary.Add(3, "0000001001100100");
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

            bottomBoundsDictionary.Add(0, "122-");
            bottomBoundsDictionary.Add(1, "-21-");
            bottomBoundsDictionary.Add(2, "-122");
            bottomBoundsDictionary.Add(3, "-32-");
        }

        private void createLeftBounds()
        {
            leftBoundsDictionary = new Dictionary<int, string> { };

            leftBoundsDictionary.Add(0, "-01-");
            leftBoundsDictionary.Add(1, "211-");
            leftBoundsDictionary.Add(2, "-12-");
            leftBoundsDictionary.Add(3, "-211");
        }
        
        private void createRightBounds()
        {
            rightBoundsDictionary = new Dictionary<int, string> { };

            rightBoundsDictionary.Add(0, "-12-");
            rightBoundsDictionary.Add(1, "221-");
            rightBoundsDictionary.Add(2, "-23-");
            rightBoundsDictionary.Add(3, "-221");
        }
    }
}
