using System;

namespace Tetris.TetriminoTemplates
{
    public abstract class Tetrimino
    {
        public int Id { get; protected set; }

        public int X { get; protected set; }

        public int Y { get; protected set; }

        public int Dimension { get; protected set; }

        public string Piece { get; protected set; }

        public int CurrentState { get; protected set; }
        
        public string[] States { get; protected set; }

        public Bounds bounds { get; protected set; }
        
        public abstract void createStates();

        protected abstract void createBounds();
        
        public void moveDown() => Y++;

        public void moveLeft() => X--;

        public void moveRight() => X++;
                
        public bool canBeDropped(int[][] gameBoard)
        {
            string bottomBounds = bounds.getBottomBounds(CurrentState);

            for (int i = X; i < X + Dimension; i++)
            {
                if (!bottomBounds[i - X].Equals('-'))
                {
                    int index = Y + (int)char.GetNumericValue(bottomBounds[i - X]) + 1;
                    if (!(gameBoard[index][i] == -1))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool canBeMovedLeft(int[][] gameBoard)
        {
            string leftBounds = bounds.getLeftBounds(CurrentState);

            for (int i = Y; i < Y + Dimension; i++)
            {
                if (!leftBounds[i - Y].Equals('-'))
                {
                    int index = X - 1 + (int)char.GetNumericValue(leftBounds[i - Y]);
                    if (!(gameBoard[i][index] == -1))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool canBeMovedRight(int[][] gameBoard)
        {
            string rightBounds = bounds.getRightBounds(CurrentState);

            for (int i = Y; i < Y + Dimension; i++)
            {
                if (!rightBounds[i - Y].Equals('-'))
                {
                    int index = X + (int)char.GetNumericValue(rightBounds[i - Y]) + 1;
                    if (!(gameBoard[i][index] == -1))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool canBeRotated(int[][] boardArea)
        {
            int newState = CurrentState == 3 ? 0 : CurrentState + 1;
            string newPiece = States[newState];

            int index = 0;

            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    boardArea[i][j] = Piece[index] == '1' && boardArea[i][j] == Id ? -1 : boardArea[i][j];
                    
                    if (newPiece[index] == '1' && boardArea[i][j] != -1)
                    {
                        return false;
                    }
                    index++;
                }
            }

            return true;
        }

        public void update()
        {
            CurrentState = CurrentState == 3 ? 0 : CurrentState + 1;
            Piece = States[CurrentState];
        }
    }
}