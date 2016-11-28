namespace Tetris
{
    public class BoardLogic
    {
        public void dropDown(Board board, Tetrimino tetrimino, ref bool isFalling)
        {
            if(canBeDropped(board, tetrimino))
            {
                board.removeTetriminoFromBoard(tetrimino);
                tetrimino.moveDown();
                board.putTetriminoIntoBoard(tetrimino);
            }
            else
            {
                isFalling = false;
            }
        }

        public bool canBeDropped(Board board, Tetrimino tetrimino)
        {
            string bounds = tetrimino.getBottomBounds();
            
            for (int i = tetrimino.x; i < tetrimino.x + tetrimino.Width; i++)
            {
                if(!bounds[i - tetrimino.x].Equals('-'))
                {
                    int index = tetrimino.y + (int)char.GetNumericValue(bounds[i - tetrimino.x]) + 1;
                    if (!board.isBoardCellEmpty(index, i))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void moveLeft(Board board, Tetrimino tetrimino)
        {
            if (canBeMovedLeft(board, tetrimino))
            {
                board.removeTetriminoFromBoard(tetrimino);
                tetrimino.moveLeft();
                board.putTetriminoIntoBoard(tetrimino);
            }
        }

        public bool canBeMovedLeft(Board board, Tetrimino tetrimino)
        {
            string bounds = tetrimino.getLeftBounds();

            for (int i = tetrimino.y; i < tetrimino.y + tetrimino.Height; i++)
            {
                if (!bounds[i - tetrimino.y].Equals('-'))
                {
                    int index = tetrimino.x - 1 + (int)char.GetNumericValue(bounds[i - tetrimino.y]);
                    if (!board.isBoardCellEmpty(i, index))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void moveRight(Board board, Tetrimino tetrimino)
        {
            if (canBeMovedRight(board, tetrimino))
            {
                board.removeTetriminoFromBoard(tetrimino);
                tetrimino.moveRight();
                board.putTetriminoIntoBoard(tetrimino);
            }
        }

        public bool canBeMovedRight(Board board, Tetrimino tetrimino)
        {
            string bounds = tetrimino.getRightBounds();

            for (int i = tetrimino.y; i < tetrimino.y + tetrimino.Height; i++)
            {
                if (!bounds[i - tetrimino.y].Equals('-'))
                {
                    int index = tetrimino.x + (int)char.GetNumericValue(bounds[i - tetrimino.y]) + 1;
                    if (!board.isBoardCellEmpty(i, index))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void deleteFullLines(Board board)
        {
            for (int i = 0; i < board.Height - 1; i ++)
            {
                if(isLineFull(board, i))
                {
                    deleteFullLine(board, i);
                }
            }
        }

        public void deleteFullLine(Board board, int line)
        {
            for (int i = line; i > 0; i--)
            {
                for (int j = 2; j < board.Width - 2; j++)
                {
                    board.gameBoard[i][j] = board.gameBoard[i - 1][j];
                }
            }
        }

        public bool isLineFull(Board board, int line)
        {
            for (int i = 2; i < board.Width - 2; i++)
            {
                if (board.gameBoard[line][i] == -1)
                {
                    return false;
                }
            }

            return true;
        }

        public bool isTopReached(Tetrimino tetrimino) => tetrimino.y == 0;
    }
}