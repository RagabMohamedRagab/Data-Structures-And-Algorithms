// Breadth First Search
// Time Complexity O(V+E)
// Space Complexity O(V)
namespace GraphBFS {
    public class BFS
    {
        private int vertice;
        private LinkedList<int>[] bfs;
        /*
         * {
         *    new LinkedList<int>{1,2},
         *    new LinkedList<int>{1,2},
         *    new LinkedList<int>{1,2},
         *    new LinkedList<int>{1,2}
         * }
         * 
         * 
         * 
         */
        public BFS(int V)
        {
            vertice= V;
            bfs=new LinkedList<int>[vertice];
            for(int i = 0; i < V; i++)
            {
                bfs[i]=new LinkedList<int>();
            }
        }


        // Add Ede
        public void Add(int v,int e)
        {
            bfs[v].AddLast(e);
        }
        public void Print()
        {
            foreach (var item in bfs)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Program
    {
        private static void Main(string[] args)
        {
           BFS fS=new BFS(2);
            fS.Print();
         
        }
    }
}