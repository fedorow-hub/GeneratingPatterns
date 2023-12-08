using GeneratingPatterns.GraphObjects;

namespace GeneratingPatterns.Builders
{
    internal interface IBuilder
    {
        CompositeShape CreateRoot();
        CompositeShape CreateContainer(CompositeShape parent);
        void CreatePoint(CompositeShape parent, int x, int y, string color);
        void CreateLine(CompositeShape parent, int xs, int ys, int xe, int ye, string color);
        void CreateCircle(CompositeShape parent, int x, int y, int r, string color);
        void CreateTriangle(CompositeShape parent, int xa, int ya, int xb, int yb, int xc, int yc, string color);
        void ShowWork();
        void Serialise();
    }
}
