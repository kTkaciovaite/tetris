using System;
using System.Collections.Generic;

namespace Tetris
{
    public class Colors
    {
        public Dictionary<int, ConsoleColor> getColors()
        {
            Dictionary<int, ConsoleColor> ColorsDictionary = new Dictionary<int, ConsoleColor> { };

            ColorsDictionary.Add(-2, ConsoleColor.Black);
            ColorsDictionary.Add(-1, ConsoleColor.Black);
            ColorsDictionary.Add(0, ConsoleColor.Cyan);
            ColorsDictionary.Add(1, ConsoleColor.Blue);
            ColorsDictionary.Add(2, ConsoleColor.DarkYellow);
            ColorsDictionary.Add(3, ConsoleColor.Yellow);
            ColorsDictionary.Add(4, ConsoleColor.Green);
            ColorsDictionary.Add(5, ConsoleColor.Magenta);
            ColorsDictionary.Add(6, ConsoleColor.Red);

            return ColorsDictionary;
        }
    }
}
