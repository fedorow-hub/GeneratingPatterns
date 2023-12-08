using GeneratingPatterns.CreateObjects;
using GeneratingPatterns.GraphObjects;

namespace GeneratingPatterns.Builders
{
    internal class BuildRealScene : IBuilder
    {
        ColorObjectsFactory colorObjectsFactory = new ColorObjectsFactory();
        public CompositeShape CreateRoot()
        {
            return colorObjectsFactory.createRoot();
        }

        public CompositeShape CreateContainer(CompositeShape parent)
        {
            return colorObjectsFactory.createContainer(parent);
        }

        public void CreateCircle(CompositeShape parent, int x, int y, int r, string color)
        {
            colorObjectsFactory.createCircle(parent, x, y, r, color);
        }

        public void CreateLine(CompositeShape parent, int xs, int ys, int xe, int ye, string color)
        {
            colorObjectsFactory.createLine(parent, xs, ys, xe, ye, color);
        }

        public void CreatePoint(CompositeShape parent, int x, int y, string color)
        {
            colorObjectsFactory.createDefaultPoint(parent);
        }


        public void CreateTriangle(CompositeShape parent, int xa, int ya, int xb, int yb, int xc, int yc, string color)
        {
            colorObjectsFactory.createTriangle(parent, xa, ya, xb, yb, xc, yc, color);
        }

        public void ShowWork()
        {
            Scene.Instance.Draw();
        }

        public void Serialise()
        {
            Scene.Instance.ExportToXML();
        }
    }
}
