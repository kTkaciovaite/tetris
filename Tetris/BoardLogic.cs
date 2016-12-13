namespace Tetris
{
    public class BoardLogic
    {
        Constants constants = new Constants();

        private int boardWidth => constants.BoardWidth;

        private int boardHeight => constants.BoardHeight;

        public void dropDown(Board board, TetriminoLogic tetrimino, ref bool isFalling)
        {
            if(tetrimino.canBeDropped(board.getBoard()))
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

        public void moveLeft(Board board, TetriminoLogic tetrimino)
        {
            if (tetrimino.canBeMovedLeft(board.getBoard()))
            {
                board.removeTetriminoFromBoard(tetrimino);
                tetrimino.moveLeft();
                board.putTetriminoIntoBoard(tetrimino);
            }
        }
        
        public void moveRight(Board board, TetriminoLogic tetrimino)
        {
            if (tetrimino.canBeMovedRight(board.getBoard()))
            {
                board.removeTetriminoFromBoard(tetrimino);
                tetrimino.moveRight();
                board.putTetriminoIntoBoard(tetrimino);
            }
        }

        public void deleteFullLines(Board board)
        {
            for (int i = 0; i < boardHeight - 1; i ++)
            {
                if(isLineFull(board, i))
                {
                    deleteFullLine(board, i);
                }
            }
        }

        public void deleteFullLine(Board board, int line)
        {
            int[][] gameBoard = board.getBoard();

            for (int i = line; i > 0; i--)
            {
                for (int j = 2; j < boardWidth - 2; j++)
                {
                    gameBoard[i][j] = gameBoard[i - 1][j];
                }
            }
        }

        public bool isLineFull(Board board, int line)
        {
            int[][] gameBoard = board.getBoard();

            for (int i = 2; i < boardWidth - 2; i++)
            {
                if (gameBoard[line][i] == -1)
                {
                    return false;
                }
            }

            return true;
        }

        public bool isTopReached(TetriminoLogic tetrimino) => tetrimino.y == 0;
    }
}