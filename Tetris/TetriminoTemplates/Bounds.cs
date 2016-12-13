namespace Tetris.TetriminoTemplates
{
    public class Bounds
    {
        public string[] BottomBounds { get; private set; }

        public string[] LeftBounds { get; private set; }

        public string[] RightBounds { get; private set; }

        public Bounds(string[] bottomBounds, string[] leftBounds, string[] rightBounds)
        {
            BottomBounds = bottomBounds;
            LeftBounds = leftBounds;
            RightBounds = rightBounds;
        }

        public string getBottomBounds(int stateId)
        {
            return BottomBounds[stateId];
        }

        public string getLeftBounds(int stateId)
        {
            return LeftBounds[stateId];
        }

        public string getRightBounds(int stateId)
        {
            return RightBounds[stateId];
        }
    }
}
