using GeneratingPatterns.Builders;

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
            _builder.CreatePoint();
            _builder.CreateLine();
            _builder.CreateCircle();
            if (needTriangle == true)
            {
                _builder.CreateTriangle();
            }
            _builder.ShowWork();
        }
    }
}
