﻿namespace Tetris.TetriminoTemplates.Templates
{
    class TetriminoJ : Tetrimino
    {
        public TetriminoJ()
        {
            Id = 1;
            X = 5;
            Y = 0;
            Dimension = 4;
            Piece = "0000111000100000";
            Length = Piece.Length;

            createStates();
            createBounds();
        }

        public override void createStates()
        {
            States = new string[] { "0000111000100000", "0010001001100000", "0000010001110000", "0000011001000100" };
        }
        
        public override void createBounds()
        {
            createBottomBounds();
            createLeftBounds();
            createRightBounds();
        }

        private void createBottomBounds()
        {
            BottomBounds = new string[] { "112-", "-22-", "-222", "-31-" };
        }
        
        private void createLeftBounds()
        {
            LeftBounds = new string[] { "-02-", "221-", "-11-", "-111" };        
        }

        private void createRightBounds()
        {
            RightBounds = new string[] { "-22-", "222-", "-13-", "-211" };
        }
    }
}