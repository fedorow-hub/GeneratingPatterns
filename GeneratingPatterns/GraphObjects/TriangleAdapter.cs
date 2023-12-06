namespace GeneratingPatterns.GraphObjects
{
    internal class TriangleAdapter : GraphObject
    {
        private Triangle _triangle;
        public TriangleAdapter(Triangle triangle)
        {
            _triangle = triangle;
            Color = triangle.Color;
        }

        public override object Clone()
        {
            return new TriangleAdapter(_triangle);
        }

        public override void Draw()
        {
            Console.WriteLine($"Рисую треугольник с вершинами в точках А:{_triangle.XA},{_triangle.YA}, B:{_triangle.XB},{_triangle.YB}, C:{_triangle.XC},{_triangle.YC}, цвет: {_triangle.Color}");
        }
    }
}
