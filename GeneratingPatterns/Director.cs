using GeneratingPatterns.Builders;
using GeneratingPatterns.GraphObjects;

namespace GeneratingPatterns
{
    internal class Director
    {
        private IBuilder _builder;
        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void make (bool needTriangle)
        {
            CompositeShape root = _builder.CreateRoot();
            CompositeShape container = _builder.CreateContainer(root);
            _builder.CreatePoint(container, 1, 2, "red");
            _builder.CreateLine(container, 1, 2, 3, 4, "blue");
            _builder.CreateCircle(container, 1,2,3, "yelow");
            if (needTriangle == true)
            {
                _builder.CreateTriangle(container, 1, 2, 3, 4, 5, 6, "brown");
            }
            _builder.ShowWork();
        }
    }
}
