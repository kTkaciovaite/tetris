using System;
using System.Collections.Generic;

namespace Tetris
{
    public class BoardDrawer
    {
        Constants constants = new Constants();

        private int boardWidth => constants.BoardWidth;

        private int boardHeight => constants.BoardHeight;

        Colors colors = new Colors();
        private Dictionary<int, ConsoleColor> ColorsDictionary => colors.getColors();

        public void drawBoard(int[][] gameBoard)
        {
            ConsoleColor color;

            for (int i = 0; i < boardHeight; i++)
            {
                for (int j = 0; j < boardWidth; j++)
                {
                    ColorsDictionary.TryGetValue(gameBoard[i][j], out color);
                    Console.BackgroundColor = color;

                    string content = gameBoard[i][j] == -2 ? "#" : " ";
                    Console.Write(content);
                }
                Console.WriteLine();
            }
        }
    }
}
