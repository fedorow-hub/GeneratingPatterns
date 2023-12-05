using GeneratingPatterns.CreateObjects;

namespace GeneratingPatterns.Builders
{
    internal class BuildRealScene : IBuilder
    {
        ColorObjectsFactory colorObjectsFactory = new ColorObjectsFactory();
        public void CreateCircle()
        {
            colorObjectsFactory.createCircle(4, 5, 8, "blue");
        }

        public void CreateLine()
        {
            colorObjectsFactory.createLine(0, 0, 100, 100, "green");
        }

        public void CreatePoint()
        {
            colorObjectsFactory.createDefaultPoint();
        }

        public void ShowWork()
        {
            Scene.Instance.Draw();
        }
    }
}
