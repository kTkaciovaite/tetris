using System.Collections.Generic;

namespace Tetris
{
    abstract class TetriminoStrategy
    {
        //properties
        public int id { get; set; }

        public int x { get; set; }

        public int y { get; set; }

        public int dimension { get; set; }

        public int tetriminoLength { get; set; }

        public string tetrimino { get; set; }
        
        public Dictionary<int, string> statesDictionary { get; set; }

        public Dictionary<int, string> bottomBoundsDictionary { get; set; }

        public Dictionary<int, string> leftBoundsDictionary { get; set; }

        public Dictionary<int, string> rightBoundsDictionary { get; set; }

        //methods
        public abstract void createStates();

        public abstract void createBounds();
    }
}