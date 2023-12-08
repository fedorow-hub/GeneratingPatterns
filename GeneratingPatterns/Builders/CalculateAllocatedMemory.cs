using GeneratingPatterns.CreateObjects;
using GeneratingPatterns.GraphObjects;

namespace GeneratingPatterns.Builders
{
    internal class CalculateAllocatedMemory : IBuilder
    {
        ColorObjectsFactory colorObjectsFactory = new ColorObjectsFactory();
        private int totalAllocatedMemory;

        public CompositeShape CreateRoot()
        {
            totalAllocatedMemory += 1000;
            return colorObjectsFactory.createRoot();
        }

        public CompositeShape CreateContainer(CompositeShape parent)
        {
            totalAllocatedMemory += 1000;
            return colorObjectsFactory.createContainer(parent);
        }

        public void CreateCircle(CompositeShape parent, int x, int y, int r, string color)
        {
            totalAllocatedMemory += 1000;
        }

        public void CreateLine(CompositeShape parent, int xs, int ys, int xe, int ye, string color)
        {
            totalAllocatedMemory += 500;
        }

        public void CreatePoint(CompositeShape parent, int x, int y, string color)
        {
            totalAllocatedMemory += 100;
        }
                

        public void CreateTriangle(CompositeShape parent, int xa, int ya, int xb, int yb, int xc, int yc, string color)
        {
            totalAllocatedMemory += 2000;
        }

        public void Serialise()
        {
            totalAllocatedMemory += 20;
        }

        public void ShowWork()
        {
            Console.WriteLine(totalAllocatedMemory);
        }

    }
}
