using System;

namespace Tetris
{
    public class Board
    {
        private const int BoardWidth = 14;
        private const int BoardHeight = 21;

        public int[][] gameBoard { get; set; }

        public Board()
        {
            gameBoard = createBoard();
        }

        public int[][] createBoard()
        {
            int[][] board = new int[Height][];

            for (int i = 0; i < Height; i++)
            {
                board[i] = new int[Width];
                for (int j = 0; j < Width; j++)
                {
                    board[i][j] = isBorder(i, j) ? -2 : -1;
                }
            }

            return board;
        }

        public bool isBorder(int i, int j) => j < 2 || j > Width - 3 || i == Height - 1;

        public void drawBoard()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    switch (gameBoard[i][j])
                    {
                        case -2:
                            drawCell(ConsoleColor.Black, "#");
                            break;
                        case -1:
                            drawCell(ConsoleColor.Black, " ");
                            break;
                        case 0:
                            drawCell(ConsoleColor.Cyan, " ");
                            break;
                        case 1:
                            drawCell(ConsoleColor.Blue, " ");
                            break;
                        case 2:
                            drawCell(ConsoleColor.DarkYellow, " ");
                            break;
                        case 3:
                            drawCell(ConsoleColor.Yellow, " ");
                            break;
                        case 4:
                            drawCell(ConsoleColor.Green, " ");
                            break;
                        case 5:
                            drawCell(ConsoleColor.Magenta, " ");
                            break;
                        case 6:
                            drawCell(ConsoleColor.Red, " ");
                            break;
                    }
                }
                Console.WriteLine();
            }
        }

        public void drawCell(ConsoleColor color, string content)
        {
            Console.BackgroundColor = color;
            Console.Write(content);
        }

        public void putTetriminoIntoBoard(Tetrimino tetrimino)
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

        public void removeTetriminoFromBoard(Tetrimino tetrimino)
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

        public bool isBoardCellEmpty(int index, int i) => gameBoard[index][i] == -1;

        public int Height => BoardHeight;

        public int Width => BoardWidth;
    }