using System;

namespace Tetris
{
    class Game
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            BoardLogic boardLogic = new BoardLogic();
            BoardDrawer boardDrawer = new BoardDrawer();

            bool isFalling;
            bool isRunning = true;

            ConsoleKeyInfo key;

            while (isRunning)
            {
                TetriminoLogic tetrimino = new TetriminoLogic();
                board.putTetriminoIntoBoard(tetrimino);
                Console.Clear();
                boardDrawer.drawBoard(board.getBoard());

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
                            //case ConsoleKey.Spacebar:
                            //    board.removeTetriminoFromBoard(tetrimino);
                            //    tetrimino.rotateTetrimino(board);
                            //    break;
                        }

                        boardDrawer.drawBoard(board.getBoard());
                    }
                    else
                    {
                        Console.Clear();
                        boardLogic.dropDown(board, tetrimino, ref isFalling);
                        boardDrawer.drawBoard(board.getBoard());
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