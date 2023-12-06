namespace GeneratingPatterns.GraphObjects
{
    internal class Line : SimpleShape
    {
        public int XStart { get; set; }
        public int YStart { get; set; }
        public int XEnd { get; set; }
        public int YEnd { get; set; }
        public Line(int xs, int ys, int xe, int ye, string color)
        {
            XStart = xs;
            YStart = ys;
            XEnd = xe;
            YEnd = ye;
            Color = color;
        }

        public override object Clone()
        {
            return new Line(XStart, YStart, XEnd, YEnd, Color);
        }

        public override void Draw()
        {
            Console.WriteLine($"Рисуем линию с координатами: начала X: {XStart}, Y: {YStart}, окончания X: {XEnd}, Y: {YEnd}, цвет: {Color}");
        }
    }
}
