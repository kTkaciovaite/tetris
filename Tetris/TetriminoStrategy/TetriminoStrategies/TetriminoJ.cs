using System.Collections.Generic;

namespace Tetris.TetriminoStrategies
{
    class TetriminoJ : TetriminoStrategy
    {
        public override void create()
        {
            id = 1;
            x = 5;
            y = 0;
            dimension = 4;
            tetrimino = "0000111000100000";
            tetriminoLength = tetrimino.Length;

            createStates();
            createBounds();
        }

        public override void createStates()
        {
            statesDictionary = new Dictionary<int, string> { };

            statesDictionary.Add(0, "0000111000100000");
            statesDictionary.Add(1, "0010001001100000");
            statesDictionary.Add(2, "0000010001110000");
            statesDictionary.Add(3, "0000011001000100");
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

            bottomBoundsDictionary.Add(0, "112-");
            bottomBoundsDictionary.Add(1, "-22-");
            bottomBoundsDictionary.Add(2, "-222");
            bottomBoundsDictionary.Add(3, "-31-");
        }
        
        private void createLeftBounds()
        {
            leftBoundsDictionary = new Dictionary<int, string> { };

            leftBoundsDictionary.Add(0, "-02-");
            leftBoundsDictionary.Add(1, "221-");
            leftBoundsDictionary.Add(2, "-11-");
            leftBoundsDictionary.Add(3, "-111");
        }

        private void createRightBounds()
        {
            rightBoundsDictionary = new Dictionary<int, string> { };

            rightBoundsDictionary.Add(0, "-22-");
            rightBoundsDictionary.Add(1, "222-");
            rightBoundsDictionary.Add(2, "-13-");
            rightBoundsDictionary.Add(3, "-211");
        }
    }
}
