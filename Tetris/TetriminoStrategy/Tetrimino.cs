using System.Collections.Generic;

namespace Tetris
{
    public abstract class Tetrimino
    {
        public int Id { get; protected set; }

        public int X { get; protected set; }

        public int Y { get; protected set; }

        public int Dimension { get; protected set; }

        public int Length { get; protected set; }

        public string Piece { get; protected set; }
        
        public Dictionary<int, string> statesDictionary { get; set; }

        public Dictionary<int, string> bottomBoundsDictionary { get; set; }

        public Dictionary<int, string> leftBoundsDictionary { get; set; }

        public Dictionary<int, string> rightBoundsDictionary { get; set; }
        
        public abstract void createStates();

        public abstract void createBounds();

        public void moveDown() => Y++;

        public void moveLeft() => X--;

        public void moveRight() => X++;
    }
}