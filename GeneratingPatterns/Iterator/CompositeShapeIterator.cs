using GeneratingPatterns.GraphObjects;

namespace GeneratingPatterns.Iterator
{
    internal class CompositeShapeIterator : IIterator
    {
        //private CompositeShape sourse;
        public CompositeShape Composite { get; set; }
        public CompositeShapeIterator(CompositeShape composite)
        {
            Composite = composite;
        }

        protected Stack<GraphObject> elementsOfTree;
        private int uiIndex;

        protected void fillelementsOfTree(CompositeShape parent)
        {
            //elementsOfTree.Push(parent);
            foreach (GraphObject element in parent.getChildren()) 
            { 
                if(element is CompositeShape)
                {
                    fillelementsOfTree((CompositeShape)element);
                }
                else
                {
                    elementsOfTree.Push(element);
                }
            }
        }

        private void lazyInit()
        {
            if(elementsOfTree == null)
            {
                elementsOfTree = new Stack<GraphObject>();
                fillelementsOfTree(Composite);
                uiIndex = 0;
            }
        }
        
        public GraphObject getNext()
        {
            if (hasMore())
            {
                return elementsOfTree.Pop();
            }
            else return null;
        }

        public bool hasMore()
        {
            lazyInit();
            return uiIndex < elementsOfTree.Count;
        }
    }
}
