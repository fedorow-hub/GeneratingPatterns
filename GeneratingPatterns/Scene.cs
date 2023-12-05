using GeneratingPatterns.GraphObjects;

namespace GeneratingPatterns
{
    internal class Scene
    {
        private List<GraphObject> graphObjects;
        public List<GraphObject> GraphObjects { get { return graphObjects; } }

        private static volatile Scene _instance;
        private static readonly object _syncRoot = new object();

        private Scene()
        {
            graphObjects = new List<GraphObject>();
        }

        public static Scene Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new Scene();
                        }
                    }
                }
                return _instance;
            }
        }

        public void AddGraphObjectToScene(GraphObject graphObject)
        {
            graphObjects.Add(graphObject);
        }

        public void ClearScene()
        {
            graphObjects.Clear();
        }

        public void Draw()
        {
            foreach (GraphObject graphObject in graphObjects)
            {
                graphObject.Draw();
            }
        }
    }
}
