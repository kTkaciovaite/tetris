using System.Collections.Generic;

namespace Tetris.TetriminoStrategies
{
    class TetriminoO : TetriminoStrategy
    {
        public TetriminoO()
        {
            id = 3;
            x = 5;
            y = 0;
            dimension = 4;
            tetrimino = "0000011001100000";
            tetriminoLength = tetrimino.Length;

            createStates();
            createBounds();
        }

        public override void createStates()
        {
            statesDictionary = new Dictionary<int, string> { };

            statesDictionary.Add(0, "0000011001100000");
            statesDictionary.Add(1, "0000011001100000");
            statesDictionary.Add(2, "0000011001100000");
            statesDictionary.Add(3, "0000011001100000");
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

            bottomBoundsDictionary.Add(0, "-22-");
            bottomBoundsDictionary.Add(1, "-22-");
            bottomBoundsDictionary.Add(2, "-22-");
            bottomBoundsDictionary.Add(3, "-22-");
        }

        private void createLeftBounds()
        {
            leftBoundsDictionary = new Dictionary<int, string> { };

            leftBoundsDictionary.Add(0, "-11-");
            leftBoundsDictionary.Add(1, "-11-");
            leftBoundsDictionary.Add(2, "-11-");
            leftBoundsDictionary.Add(3, "-11-");
        }

        private void createRightBounds()
        {
            rightBoundsDictionary = new Dictionary<int, string> { };

            rightBoundsDictionary.Add(0, "-22-");
            rightBoundsDictionary.Add(1, "-22-");
            rightBoundsDictionary.Add(2, "-22-");
            rightBoundsDictionary.Add(3, "-22-");
        }
    }
}
