namespace Tetris
{
    public class Board
    {
        Constants constants = new Constants();

        private int boardWidth => constants.BoardWidth;

        private int boardHeight => constants.BoardHeight;

        private int[][] gameBoard { get; set; }

        public Board()
        {
            gameBoard = createBoard();
        }

        public int[][] getBoard() => gameBoard;

        public int[][] createBoard()
        {
            int[][] board = new int[boardHeight][];

            for (int i = 0; i < boardHeight; i++)
            {
                board[i] = new int[boardWidth];
                for (int j = 0; j < boardWidth; j++)
                {
                    board[i][j] = isBorder(i, j) ? -2 : -1;
                }
            }

            return board;
        }

        public int[][] getBoardArea(TetriminoLogic tetrimino)
        {
            int[][] boardArea = new int[tetrimino.Dimension][];
            int indexI = 0;
            int indexJ;
            
            for (int i = tetrimino.Y; i < tetrimino.Y + tetrimino.Dimension; i++)
            {
                boardArea[indexI] = new int[tetrimino.Dimension];
                indexJ = 0;
                for (int j = tetrimino.X; j < tetrimino.X + tetrimino.Dimension; j++)
                {
                    boardArea[indexI][indexJ] = gameBoard[i][j];
                    indexJ++;
                }
                indexI++;
            }

            return boardArea;
        }

        public bool isBorder(int i, int j) => j < 2 || j > boardWidth - 3 || i == boardHeight - 1 || i == boardHeight - 2;

        public void putTetriminoIntoBoard(TetriminoLogic tetrimino)
        {
            int index = 0;

            for (int i = 0; i < tetrimino.Dimension; i++)
            {
                for (int j = 0; j < tetrimino.Dimension; j++)
                {
                    if (tetrimino.Piece[index].Equals('1'))
                    {
                        setCellValue(tetrimino.X + j, tetrimino.Y + i, tetrimino.Id);
                    }

                    index++;
                }
            }
        }

        public void removeTetriminoFromBoard(TetriminoLogic tetrimino)
        {
            for (int i = 0; i < tetrimino.Dimension; i++)
            {
                for (int j = 0; j < tetrimino.Dimension; j++)
                {
                    if (!tetrimino.Piece[i * tetrimino.Dimension + j].Equals('0'))
                    {
                        gameBoard[tetrimino.Y + i][tetrimino.X + j] = -1;
                    }
                }
            }
        }

        public void setCellValue(int x, int y, int value) => gameBoard[y][x] = value;
    }
}