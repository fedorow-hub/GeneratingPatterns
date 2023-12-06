using GeneratingPatterns.GraphObjects;

namespace GeneratingPatterns.CreateObjects
{
    internal abstract class GraphObjectsFactory
    {
        public abstract SimpleShape createPoint(CompositeShape parent, int x, int y, string color);
        public abstract SimpleShape createDefaultPoint(CompositeShape parent);
        public abstract SimpleShape createLine(CompositeShape parent, int xs, int ys, int xe, int ye, string color);
        public abstract SimpleShape createCircle(CompositeShape parent, int x, int y, int r, string color);
        public abstract SimpleShape createTriangle(CompositeShape parent, int xa, int ya, int xb, int yb, int xc, int yc, string color);
        public abstract CompositeShape createRoot();
        public abstract CompositeShape createContainer(CompositeShape parent);
    }
}
