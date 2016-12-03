using System.Collections.Generic;

namespace Tetris.TetriminoStrategies
{
    class TetriminoL : TetriminoStrategy
    {
        public override void create()
        {
            id = 2;
            x = 5;
            y = 0;
            dimension = 4;
            tetrimino = "0000011101000000";
            tetriminoLength = tetrimino.Length;

            createStates();
            createBounds();
        }

        public override void createStates()
        {
            statesDictionary = new Dictionary<int, string> { };

            statesDictionary.Add(0, "0000011101000000");
            statesDictionary.Add(1, "0000011000100010");
            statesDictionary.Add(2, "0000001011100000");
            statesDictionary.Add(3, "0100010001100000");
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

            bottomBoundsDictionary.Add(0, "-211");
            bottomBoundsDictionary.Add(1, "-13-");
            bottomBoundsDictionary.Add(2, "222-");
            bottomBoundsDictionary.Add(3, "-22-");
        }

        private void createLeftBounds()
        {
            leftBoundsDictionary = new Dictionary<int, string> { };

            leftBoundsDictionary.Add(0, "-11-");
            leftBoundsDictionary.Add(1, "-122");
            leftBoundsDictionary.Add(2, "-20-");
            leftBoundsDictionary.Add(3, "112-");
        }
        
        private void createRightBounds()
        {
            rightBoundsDictionary = new Dictionary<int, string> { };

            rightBoundsDictionary.Add(0, "-31-");
            rightBoundsDictionary.Add(1, "-222");
            rightBoundsDictionary.Add(2, "-22-");
            rightBoundsDictionary.Add(3, "112-");
        }
    }
}
