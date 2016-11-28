using System;

namespace Tetris
{
    class Game
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            BoardLogic boardLogic = new BoardLogic();

            bool isFalling;
            bool isRunning = true;

            ConsoleKeyInfo key;

            while (isRunning)
            {
                Tetrimino tetrimino = new Tetrimino();
                board.putTetriminoIntoBoard(tetrimino);
                Console.Clear();
                board.drawBoard();

                isFalling = true;
                while (isFalling)
                {
                    if (Console.KeyAvailable)
                    {
                        key = Console.ReadKey();
                        Console.Clear();

                        switch (key.Key)
                        {
                            case ConsoleKey.DownArrow:
                                boardLogic.dropDown(board, tetrimino, ref isFalling);
                                break;
                            case ConsoleKey.LeftArrow:
                                boardLogic.moveLeft(board, tetrimino);
                                break;
                            case ConsoleKey.RightArrow:
                                boardLogic.moveRight(board, tetrimino);
                                break;
                        }

                        board.drawBoard();
                    }
                    else
                    {
                        Console.Clear();
                        boardLogic.dropDown(board, tetrimino, ref isFalling);
                        board.drawBoard();
                        System.Threading.Thread.Sleep(700);
                    }
                }

                boardLogic.deleteFullLines(board);

                if (boardLogic.isTopReached(tetrimino))
                {
                    isRunning = false;
                }
            }

            Console.WriteLine("   GAME OVER");
        }
    }
}