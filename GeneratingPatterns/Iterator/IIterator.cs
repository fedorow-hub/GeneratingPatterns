using GeneratingPatterns.GraphObjects;

namespace GeneratingPatterns.Iterator
{
    internal interface IIterator
    {
        GraphObject getNext();
        bool hasMore();
    }
}
