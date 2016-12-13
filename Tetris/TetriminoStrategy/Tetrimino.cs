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
        
        public string[] States { get; protected set; }

        public string[] BottomBounds { get; protected set; }

        public string[] LeftBounds { get; protected set; }

        public string[] RightBounds { get; protected set; }
        
        public abstract void createStates();

        public abstract void createBounds();
        
        public void moveDown() => Y++;

        public void moveLeft() => X--;

        public void moveRight() => X++;

        public int getStateId()
        {
            for (int i = 0; i < States.Length; i++)
            {
                if (Piece == States[i])
                {
                    return i;
                }
            }

            return -1;
        }

        public string getBottomBounds()
        {
            int stateId = getStateId();

            return BottomBounds[stateId];
        }

        public string getLeftBounds()
        {
            int stateId = getStateId();

            return LeftBounds[stateId];
        }

        public string getRightBounds()
        {
            int stateId = getStateId();

            return RightBounds[stateId];
        }
    }
}