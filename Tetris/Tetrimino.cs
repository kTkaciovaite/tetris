using System;

namespace Tetris
{
    public class Tetrimino
    {
        public const int TetriminoWidth = 4;
        public const int TetriminoHeight = 4;

        public int id { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string tetrimino { get; set; }

        public Tetrimino()
        {
            id = generateId();
            x = 5;
            y = 0;
            tetrimino = getTetrimino();
        }

        public int generateId()
        {
            Random newId = new Random();

            return newId.Next(0, 6);
        }

        public string getTetrimino()
        {
            switch (id)
            {
                case 0:
                    return "0000111100000000";
                case 1:
                    return "0000111000100000";
                case 2:
                    return "0000011101000000";
                case 3:
                    return "0000011001100000";
                case 4:
                    return "0000011011000000";
                case 5:
                    return "0000111001000000";
                case 6:
                    return "0000110001100000";
            }

            return "";
        }
        
        public int Width => TetriminoWidth;

        public int Height => TetriminoHeight;

        public string getBottomBounds()
        {
            string bounds = "";

            for (int i = 0; i < Width; i++)
            {
                bounds += getBottomBound(i);
            }

            return bounds;
        }

        public string getBottomBound(int column)
        {
            string bound = "-";

            for (int i = column; i < tetrimino.Length; i += Width)
            {
                if (tetrimino[i].Equals('1'))
                {
                    bound = (i / Width).ToString();
                }
            }

            return bound;
        }

        public string getLeftBounds()
        {
            string bounds = "";

            for (int i = 0; i < Height; i++)
            {
                bounds += getLeftBound(i);
            }

            return bounds;
        }

        public string getLeftBound(int line)
        {
            string bound = "-";

            for (int i = 0; i < Width; i++)
            {
                if (tetrimino[line * Width + i].Equals('1'))
                {
                    bound = i.ToString();
                    break;
                }
            }

            return bound;
        }

        public string getRightBounds()
        {
            string bounds = "";

            for (int i = 0; i < Height; i++)
            {
                bounds += getRightBound(i);
            }

            return bounds;
        }

        public string getRightBound(int line)
        {
            string bound = "-";

            for (int i = 0; i < Width; i++)
            {
                if (tetrimino[line * Width + i].Equals('1'))
                {
                    bound = i.ToString();
                }
            }

            return bound;
        }

        public void moveDown() => y++;

        public void moveLeft() => x--;

        public void moveRight() => x++;
    }
} //160