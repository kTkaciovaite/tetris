﻿namespace Tetris
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

        public bool isBorder(int i, int j) => j < 2 || j > boardWidth - 3 || i == boardHeight - 1;

        public void putTetriminoIntoBoard(TetriminoLogic tetrimino)
        {
            int index = 0;

            for (int i = 0; i < tetrimino.dimension; i++)
            {
                for (int j = 0; j < tetrimino.dimension; j++)
                {
                    if (tetrimino.piece[index].Equals('1'))
                    {
                        setCellValue(tetrimino.x + j, tetrimino.y + i, tetrimino.id);
                    }

                    index++;
                }
            }
        }

        public void removeTetriminoFromBoard(TetriminoLogic tetrimino)
        {
            for (int i = 0; i < tetrimino.dimension; i++)
            {
                for (int j = 0; j < tetrimino.dimension; j++)
                {
                    if (!tetrimino.piece[i * tetrimino.dimension + j].Equals('0'))
                    {
                        gameBoard[tetrimino.y + i][tetrimino.x + j] = -1;
                    }
                }
            }
        }

        public void setCellValue(int x, int y, int value) => gameBoard[y][x] = value;
    }
}