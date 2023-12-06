namespace GeneratingPatterns.GraphObjects
{
    internal class Triangle
    {
        public int XA { get; set; }
        public int YA { get; set; }
        public int XB { get; set; }
        public int YB { get; set; }
        public int XC { get; set; }
        public int YC { get; set; }

        public string Color { get; set; }
        public Triangle(int xa, int ya, int xb, int yb, int xc, int yc, string color)
        {
            XA = xa;
            YA = ya;
            XB = xb;
            YB = yb;
            XC = xc;
            YC = yc;
            Color = color;
        }
    }
}
