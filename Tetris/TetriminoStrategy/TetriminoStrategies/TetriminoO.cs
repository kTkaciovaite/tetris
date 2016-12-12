﻿using System.Collections.Generic;

namespace Tetris.TetriminoStrategies
{
    class TetriminoO : Tetrimino
    {
        public TetriminoO()
        {
            Id = 3;
            X = 5;
            Y = 0;
            Dimension = 4;
            Piece = "0000011001100000";
            Length = Piece.Length;

            createStates();
            createBounds();
        }

        public override void createStates()
        {
            statesDictionary = new Dictionary<int, string> { };

            statesDictionary.Add(0, "0000011001100000");
            statesDictionary.Add(1, "0000011001100000");
            statesDictionary.Add(2, "0000011001100000");
            statesDictionary.Add(3, "0000011001100000");
        }
        
        public override void createBounds()
        {
            createBottomBounds();
            createLeftBounds();
            createRightBounds();
        }

        private void createBottomBounds()
        {
            bottomBoundsDictionary = new Dictionary<int, string> { };

            bottomBoundsDictionary.Add(0, "-22-");
            bottomBoundsDictionary.Add(1, "-22-");
            bottomBoundsDictionary.Add(2, "-22-");
            bottomBoundsDictionary.Add(3, "-22-");
        }

        private void createLeftBounds()
        {
            leftBoundsDictionary = new Dictionary<int, string> { };

            leftBoundsDictionary.Add(0, "-11-");
            leftBoundsDictionary.Add(1, "-11-");
            leftBoundsDictionary.Add(2, "-11-");
            leftBoundsDictionary.Add(3, "-11-");
        }

        private void createRightBounds()
        {
            rightBoundsDictionary = new Dictionary<int, string> { };

            rightBoundsDictionary.Add(0, "-22-");
            rightBoundsDictionary.Add(1, "-22-");
            rightBoundsDictionary.Add(2, "-22-");
            rightBoundsDictionary.Add(3, "-22-");
        }
    }
}
