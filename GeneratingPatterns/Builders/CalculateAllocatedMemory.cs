namespace GeneratingPatterns.Builders
{
    internal class CalculateAllocatedMemory : IBuilder
    {
        private int totalAllocatedMemory;

        public void CreateCircle()
        {
            totalAllocatedMemory += 1000;
        }

        public void CreateLine()
        {
            totalAllocatedMemory += 500;
        }

        public void CreatePoint()
        {
            totalAllocatedMemory += 100;
        }

        public void CreateTriangle()
        {
            totalAllocatedMemory += 2000;
        }

        public void ShowWork()
        {
            Console.WriteLine(totalAllocatedMemory);
        }
    }
}
