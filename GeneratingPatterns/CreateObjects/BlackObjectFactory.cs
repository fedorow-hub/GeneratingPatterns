using GeneratingPatterns.GraphObjects;

namespace GeneratingPatterns.CreateObjects
{
    internal class BlackObjectFactory : GraphObjectsFactory
    {
        public Point DEFAULT_POINT = new Point(0, 0, "black");

        public override CompositeShape createRoot()
        {
            CompositeShape root = new CompositeShape();
            Scene.Instance.AddObjectToScene(null, root);
            return root;
        }
        public override CompositeShape createContainer(CompositeShape parent)
        {
            CompositeShape cs = new CompositeShape();
            Scene.Instance.AddObjectToScene(parent, cs);
            return cs;
        }

        public override Circle createCircle(CompositeShape parent, int x, int y, int r, string color = "black")
        {
            Circle c = new Circle(x, y, r, color);
            Scene.Instance.AddObjectToScene(parent, c);
            return c;
        }


        public override Point createDefaultPoint(CompositeShape parent)
        {
            Point p = DEFAULT_POINT.Clone() as Point;
            Scene.Instance.AddObjectToScene(parent, p);
            return p;
        }

        public override Line createLine(CompositeShape parent, int xs, int ys, int xe, int ye, string color = "black")
        {
            Line l = new Line(xs, ys, xe, ye, color);
            Scene.Instance.AddObjectToScene(parent, l);
            return l;
        }

        public override Point createPoint(CompositeShape parent, int x, int y, string color = "black")
        {
            Point p = new Point(x, y, color);
            Scene.Instance.AddObjectToScene(parent, p);
            return p;
        }

        

        public override TriangleAdapter createTriangle(CompositeShape parent, int xa, int ya, int xb, int yb, int xc, int yc, string color = "black")
        {
            TriangleAdapter t = new TriangleAdapter(new Triangle(xa, ya, xb, yb, xc, yc, color));
            Scene.Instance.AddObjectToScene(parent, t);
            return t;
        }

    }
}
