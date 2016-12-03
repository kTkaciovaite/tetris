namespace Tetris
{
    public class BoardLogic
    {
        public void dropDown(Board board, Tetrimino tetrimino, ref bool isFalling)
        {
            if(tetrimino.canBeDropped(board))
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

        public void moveLeft(Board board, Tetrimino tetrimino)
        {
            if (tetrimino.canBeMovedLeft(board))
            {
                board.removeTetriminoFromBoard(tetrimino);
                tetrimino.moveLeft();
                board.putTetriminoIntoBoard(tetrimino);
            }
        }
        
        public void moveRight(Board board, Tetrimino tetrimino)
        {
            if (tetrimino.canBeMovedRight(board))
            {
                board.removeTetriminoFromBoard(tetrimino);
                tetrimino.moveRight();
                board.putTetriminoIntoBoard(tetrimino);
            }
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