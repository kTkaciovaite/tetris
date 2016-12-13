using System;
using Tetris.TetriminoTemplates;

namespace Tetris
{
    public class TetriminoLogic
    {
        private Tetrimino tetrimino;

        public int Id => tetrimino.Id;

        public int X => tetrimino.X;

        public int Y => tetrimino.Y;

        public int Dimension => tetrimino.Dimension;

        public string Piece { get; private set; }

        public TetriminoLogic()
        {
            createRandomTetrimino();
            Piece = tetrimino.Piece;
        }

        public void createRandomTetrimino()
        {
            Random newId = new Random();

            TetriminoFactory tetriminoFactory = new TetriminoFactory(newId.Next(0, 7));
            tetrimino = tetriminoFactory.getTetrimino();
        }

        public void moveDown() => tetrimino.moveDown();

        public void moveLeft() => tetrimino.moveLeft();

        public void moveRight() => tetrimino.moveRight();

        public bool canBeDropped(int[][] gameBoard) => tetrimino.canBeDropped(gameBoard);

        public bool canBeMovedLeft(int[][] gameBoard) => tetrimino.canBeMovedLeft(gameBoard);

        public bool canBeMovedRight(int[][] gameBoard) => tetrimino.canBeMovedRight(gameBoard);
    }
}