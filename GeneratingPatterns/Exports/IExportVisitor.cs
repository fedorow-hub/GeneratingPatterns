using GeneratingPatterns.GraphObjects;

namespace GeneratingPatterns.Exports
{
    internal interface IExportVisitor
    {
        void exportGraphObject(Point p);
        void exportGraphObject(Line l);
        void exportGraphObject(Circle c);
        void exportGraphObject(Triangle p);

    }
}
