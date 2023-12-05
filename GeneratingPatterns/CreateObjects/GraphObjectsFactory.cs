using GeneratingPatterns.GraphObjects;

namespace GeneratingPatterns.CreateObjects
{
    internal abstract class GraphObjectsFactory
    {
        public abstract Point createPoint(int x, int y, string color);
        public abstract Point createDefaultPoint();
        public abstract Line createLine(int xs, int ys, int xe, int ye, string color);
        public abstract Circle createCircle(int x, int y, int r, string color);
    }
}
