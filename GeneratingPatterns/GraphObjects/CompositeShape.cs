using GeneratingPatterns.Iterator;

namespace GeneratingPatterns.GraphObjects
{
    internal class CompositeShape : GraphObject, IIterableGraphObjectCollection
    {
        private List<GraphObject> children;

        public List<GraphObject> getChildren()
        {
            if (children == null)
                children = new List<GraphObject>();
            return children;
        }

        public override void Draw()
        {
            foreach (GraphObject g in getChildren())
            {
                g.Draw();
            }
        }

        public IIterator getIterator()
        {
           return new CompositeShapeIterator(this);
        }
    }
}
