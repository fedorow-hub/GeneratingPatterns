using GeneratingPatterns.GraphObjects;

namespace GeneratingPatterns.CreateObjects
{
    internal class BlackObjectFactory : GraphObjectsFactory
    {
        public Point DEFAULT_POINT = new Point(0, 0, "black");
        public override Circle createCircle(int x, int y, int r, string color = "black")
        {
            Circle c = new Circle(x, y, r, color);
            Scene.Instance.AddGraphObjectToScene(c);
            return c;
        }

        public override Point createDefaultPoint()
        {
            Point p = DEFAULT_POINT.Clone() as Point;
            Scene.Instance.AddGraphObjectToScene(p);
            return p;
        }

        public override Line createLine(int xs, int ys, int xe, int ye, string color = "black")
        {
            Line l = new Line(xs, ys, xe, ye, color);
            Scene.Instance.AddGraphObjectToScene(l);
            return l;
        }

        public override Point createPoint(int x, int y, string color = "black")
        {
            Point p = new Point(x, y, color);
            Scene.Instance.AddGraphObjectToScene(p);
            return p;
        }

        public override TriangleAdapter createTriangle(int xa, int ya, int xb, int yb, int xc, int yc, string color = "black")
        {
            TriangleAdapter t = new TriangleAdapter(new Triangle(xa, ya, xb, yb, xc, yc, color));
            Scene.Instance.AddGraphObjectToScene(t);
            return t;
        }
    }
}
