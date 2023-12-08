using GeneratingPatterns.Exports;

namespace GeneratingPatterns.GraphObjects
{
    internal abstract class GraphObject: ICloneable
    {
        public string Color { get; set; } = "black";

        public virtual object Clone()
        {
            throw new NotImplementedException();
        }

        public virtual void Draw()
        {
            Console.WriteLine("Рисую графический объект");
        }

    }
}
