namespace GeneratingPatterns.GraphObjects
{
    internal class Circle : SimpleShape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }
        public Circle(int x, int y, int radius, string color)
        {
            X = x;
            Y = y;
            Radius = radius;
            Color = color;
        }

        public override object Clone()
        {
            return new Circle(X, Y, Radius, Color);
        }

        public override void Draw()
        {
            Console.WriteLine($"Рисуем круг с центром в точке с координатами X: {X}, Y: {Y}, радиусом: {Radius} цвет: {Color}");
        }

    }
}
