namespace GeneratingPatterns.GraphObjects
{
    internal class SimpleShape : GraphObject
    {
        public static string DEFAULT_COLOR = "black";
        public string Color { get; set; }

        public SimpleShape()
        {
            Color = DEFAULT_COLOR;
        }
        public SimpleShape(string color)
        {
            Color = color;
        }
    }
}
