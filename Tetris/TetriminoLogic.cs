using System;
using Tetris.TetriminoTemplates;

namespace Tetris
{
    public class TetriminoLogic
    {
        private Tetrimino tetrimino;

        public int id => tetrimino.Id;

        public int x => tetrimino.X;

        public int y => tetrimino.Y;

        public int dimension => tetrimino.Dimension;

        public string piece { get; private set; }

        public TetriminoLogic()
        {
            createRandomTetrimino();
            piece = tetrimino.Piece;
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