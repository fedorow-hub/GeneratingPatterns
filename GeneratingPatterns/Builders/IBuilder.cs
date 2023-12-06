namespace GeneratingPatterns.Builders
{
    internal interface IBuilder
    {
        void CreatePoint();
        void CreateLine();
        void CreateCircle();
        void CreateTriangle();
        void ShowWork();
    }
}
