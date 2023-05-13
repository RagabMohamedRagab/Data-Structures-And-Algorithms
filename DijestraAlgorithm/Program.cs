/* Dijkestra Algorithm 
 -  Time Complexity O(V^2)
 - Aulixary Complexity O(V)
 */
namespace DijestraAlgorithm {
    class Vertice
    {
        public int Edge;
        public int Weight;
    }
    class Graph
    {
        private LinkedList<Vertice>[] dkstra;
        private int vertice;
        public Graph(int v)
        {
            vertice = v;
            dkstra= new LinkedList<Vertice>[vertice];
            for(int i = 0; i < v; i++)
            {
                dkstra[i]= new LinkedList<Vertice>();
            }
        }
        public void Add(int V,Vertice v) {
            dkstra[V].AddLast(v);
        }
    }
    class Program
    {
        private static void Main(string[]args)
        {
            int v = 5;
            Graph g = new Graph(v);
            for(int i = 0; i < v; i++)
            {
                Console.Write("Enter Vertice :");
                int ver = Int32.Parse(Console.ReadLine());
                Console.Write("Enter Weight :");
                int w = Int32.Parse(Console.ReadLine());
                Console.Write("Enter Edge: ");
                int E=Int32.Parse(Console.ReadLine());
                Vertice vertice = new Vertice
                {
                    Edge = E,
                    Weight = w
                };
                g.Add(ver, vertice);
            }
           
        }
    }
}