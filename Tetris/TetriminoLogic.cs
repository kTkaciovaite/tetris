using System;
using System.Linq;

namespace Tetris
{
    public class TetriminoLogic
    {
        private TetriminoStrategy tetrimino;

        public int id => tetrimino.Id;

        public int x => tetrimino.X;

        public int y => tetrimino.Y;

        public int dimension => tetrimino.Dimension;

        public string piece { get; private set; }

        public TetriminoLogic()
        {
            createRandomTetrimino();
            piece = tetrimino.Piece;
        }

        public void createRandomTetrimino()
        {
            Random newId = new Random();

            TetriminoFactory tetriminoFactory = new TetriminoFactory(newId.Next(0, 7));
            tetrimino = tetriminoFactory.getTetrimino();
        }

        public void moveDown() => tetrimino.moveDown();

        public void moveLeft() => tetrimino.moveLeft();

        public void moveRight() => tetrimino.moveRight();

        public bool canBeDropped(Board board)
        {
            int state = tetrimino.statesDictionary.FirstOrDefault(x => x.Value == piece).Key;

            string bounds = tetrimino.bottomBoundsDictionary.FirstOrDefault(x => x.Key == state).Value;

            for (int i = x; i < x + dimension; i++)
            {
                if (!bounds[i - x].Equals('-'))
                {
                    int index = y + (int)char.GetNumericValue(bounds[i - x]) + 1;
                    if (!board.isBoardCellEmpty(index, i))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool canBeMovedLeft(Board board)
        {
            int state = tetrimino.statesDictionary.FirstOrDefault(x => x.Value == piece).Key;

            string bounds = tetrimino.leftBoundsDictionary.FirstOrDefault(x => x.Key == state).Value;

            for (int i = y; i < y + dimension; i++)
            {
                if (!bounds[i - y].Equals('-'))
                {
                    int index = x - 1 + (int)char.GetNumericValue(bounds[i - y]);
                    if (!board.isBoardCellEmpty(i, index))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool canBeMovedRight(Board board)
        {
            int state = tetrimino.statesDictionary.FirstOrDefault(x => x.Value == piece).Key;

            string bounds = tetrimino.rightBoundsDictionary.FirstOrDefault(x => x.Key == state).Value;

            for (int i = y; i < y + dimension; i++)
            {
                if (!bounds[i - y].Equals('-'))
                {
                    int index = x + (int)char.GetNumericValue(bounds[i - y]) + 1;
                    if (!board.isBoardCellEmpty(i, index))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}