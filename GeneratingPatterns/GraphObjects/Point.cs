using GeneratingPatterns.Exports;

namespace GeneratingPatterns.GraphObjects
{
    internal class Point : SimpleShape, IExportable
    {        
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y, string color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public override void Draw()
        {
            Console.WriteLine($"Рисуем точку с координатами X: {X}, Y: {Y}, цвет {Color}"); ;
        }

        public override object Clone()
        {
            return new Point(X, Y, Color);
        }

        public void accept(IExportVisitor v)
        {
            v.exportGraphObject(this);
        }
    }
}
