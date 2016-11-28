using System;

namespace TetrisGame
{
    public class Tetrimino
    {
        public int id;
        public string color;
        public int[,] piece;

        public Tetrimino()
        {
            id = getId();
        }

        public int getId()
        {
            Random newTetrimino = new Random();
            int newTetriminoId;

            newTetriminoId = newTetrimino.Next(0, 6);

            return 0;
        }

        //public string getcolor() {}

        //public int[,] getPiece() {}
    }
}
