using System;
using System.Linq;
using Tetris.TetriminoStrategies;

namespace Tetris
{
    public class TetriminoLogic
    {
        private TetriminoStrategy tetrimino;

        public int id => tetrimino.Id;

        public int x => tetrimino.X;

        public int y => tetrimino.Y;

        public int dimension => tetrimino.Dimension;

        public string piece { get; set; }

        public TetriminoLogic()
        {
            createRandomTetrimino();
            piece = tetrimino.Piece;
        }

        public void createRandomTetrimino()
        {
            //TODO -> apply Factory pattern
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

        //public void rotateTetrimino(Board board)
        //{
        //    int currentState = tetrimino.statesDictionary.FirstOrDefault(x => x.Value == piece).Key;
        //    int newState = currentState == 3 ? 0 : currentState + 1;
        //    //string newPiece;
        //    //tetrimino.statesDictionary.TryGetValue(newState, out newPiece);

        //    //bool canBeRotated = true;

        //    //string temporaryBoardSpace = getBoardSpace(board);

        //    //for (int i = 0; i < piece.Length; i++)
        //    //{
        //    //    if (newPiece[i] == '1' && temporaryBoardSpace[i] == '0')
        //    //    {
        //    //        canBeRotated = true;
        //    //    }
        //    //    else
        //    //    {
        //    //        canBeRotated = false;
        //    //        break;
        //    //    }
        //    //}

        //    //if (canBeRotated)
        //    //{
        //        string newPieceState;
        //        tetrimino.statesDictionary.TryGetValue(newState, out newPieceState);

        //        piece = newPieceState;
        //    //}
        //}

        ////private string getBoardSpace(Board board)
        ////{
        ////    string boardSpace = "";
        ////    int[][] gameBoard = board.getBoard();
        ////    int index = 0;

        ////    for (int i = y; i < y + dimension; i++)
        ////    {
        ////        for (int j = x; x < x + dimension; j++)
        ////        {
        ////            if (gameBoard[i][j] == -1 || piece[index] != '0')
        ////            {
        ////                boardSpace += "0";
        ////            }
        ////            else
        ////            {
        ////                boardSpace += "1";
        ////            }

        ////            index++;
        ////        }
        ////    }

        ////    return boardSpace;
        ////}
    }
}