using Tetris.TetriminoTemplates;
using Tetris.TetriminoTemplates.Templates;

namespace Tetris
{
    public class TetriminoFactory
    {
        private Tetrimino tetrimino;

        public TetriminoFactory(int id)
        {
            switch (id)
            {
                case 0:
                    tetrimino = new TetriminoI();
                    break;
                case 1:
                    tetrimino = new TetriminoJ();
                    break;
                case 2:
                    tetrimino = new TetriminoL();
                    break;
                case 3:
                    tetrimino = new TetriminoO();
                    break;
                case 4:
                    tetrimino = new TetriminoS();
                    break;
                case 5:
                    tetrimino = new TetriminoT();
                    break;
                case 6:
                    tetrimino = new TetriminoZ();
                    break;
            }
        }

        public Tetrimino getTetrimino() => tetrimino;
    }
}
