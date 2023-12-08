using GeneratingPatterns.Exports;
using GeneratingPatterns.GraphObjects;
using GeneratingPatterns.Iterator;

namespace GeneratingPatterns
{
    internal class Scene
    {        
        public GraphObject Root { get; set; }

        private static volatile Scene _instance;
        private static readonly object _syncRoot = new object();

        private Scene()
        {
        }

        public static Scene Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        _instance = new Scene();
                    }
                }
                return _instance;
            }
        }

        public void AddObjectToScene(CompositeShape p, GraphObject o)
        {
            if (p == null && Root is CompositeShape)
            {
                p = (CompositeShape)Root;
            }                
            if (p == null)
                Root = o;
            else
                p.getChildren().Add(o);
        }

        public void ClearScene()
        {
            Root = null;
        }

        public void Draw()
        {
            if (Root != null)
                Root.Draw();
        }

        public void ExportToXML()
        {
            XMLSerialisationVisitor visitor = new XMLSerialisationVisitor();
            var scene = this.Root as CompositeShape;
            if (scene != null)
            {
                IIterator iter = scene.getIterator();
                Console.WriteLine("<scene>");                
                while(iter.hasMore())
                {
                    GraphObject g = iter.getNext();
                    if (g != null)
                    {
                        ((IExportable)g).accept(visitor);                        
                    }
                }
                Console.WriteLine("</scene>");
            }
        }

    }
}
