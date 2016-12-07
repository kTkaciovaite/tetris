using System;
using System.Linq;
using Tetris.TetriminoStrategies;

namespace Tetris
{
    public class Tetrimino
    {
        private TetriminoStrategy tetrimino;

        public int id => tetrimino.id;

        public int x => tetrimino.x;

        public int y => tetrimino.y;

        public int dimension => tetrimino.dimension;

        public string piece => tetrimino.tetrimino;
        
        public Tetrimino()
        {
            createRandomTetrimino();
        }

        public void createRandomTetrimino()
        {
            Random newId = new Random();

            switch (newId.Next(0, 7))
            {
                case 0:
                    tetrimino = new TetriminoI();
                    break;
                case 1:
                    tetrimino = new TetriminoJ();
                    break;
                case 2:
                    tetrimino = new TetriminoL();
                    break;
                case 3:
                    tetrimino = new TetriminoO();
                    break;
                case 4:
                    tetrimino = new TetriminoS();
                    break;
                case 5:
                    tetrimino = new TetriminoT();
                    break;
                case 6:
                    tetrimino = new TetriminoZ();
                    break;
            }
        }
        
        public void moveDown() => tetrimino.y++;

        public void moveLeft() => tetrimino.x--;

        public void moveRight() => tetrimino.x++;

        public bool canBeDropped(Board board)
        {
            int state = tetrimino.statesDictionary.FirstOrDefault(x => x.Value == tetrimino.tetrimino).Key;

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
            int state = tetrimino.statesDictionary.FirstOrDefault(x => x.Value == tetrimino.tetrimino).Key;

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
            int state = tetrimino.statesDictionary.FirstOrDefault(x => x.Value == tetrimino.tetrimino).Key;

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