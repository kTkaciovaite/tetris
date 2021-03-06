﻿namespace Tetris.TetriminoTemplates.Templates
{
    class TetriminoS : Tetrimino
    {
        public TetriminoS()
        {
            Id = 4;
            X = 5;
            Y = 0;
            Dimension = 4;
            Piece = "0000011011000000";
            CurrentState = 0;

            createStates();
            createBounds();
        }

        public override void createStates()
        {
            States = new string[] { "0000011011000000", "0100011000100000", "0000001101100000", "0000010001100010" };
        }
        
        protected override void createBounds()
        {
            string[] bottomBounds = new string[] { "221-", "-12-", "-221", "-23-" };
            string[] leftBounds = new string[] { "-10-", "112-", "-21-", "-112" };
            string[] rightBounds = new string[] { "-21-", "122-", "-32-", "-122" };

            bounds = new Bounds(bottomBounds, leftBounds, rightBounds);
        }
    }
}