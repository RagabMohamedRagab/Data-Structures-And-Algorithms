// Breadth First Search
// Time Complexity O(V+E)
// Space Complexity O(V)
namespace GraphBFS {
    public class BFS
    {
        private int vertice;
        private LinkedList<int>[] bfs;
      
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
        public void BFSSearch(int v)
        {
            bool[]Vistited=new bool[vertice];
            LinkedList<int> list=new LinkedList<int>();
            Vistited[v]=true;
            list.AddLast(v);
          
            while(list.Count > 0)
            {
                int i = list.First.Value;
                Console.WriteLine(i);
                LinkedList<int> childrens = bfs[i];
                list.RemoveFirst();
                foreach (var item in childrens)
                {
                    if (!Vistited[item])
                    {
                        Vistited[item] = true;
                        list.AddLast(item);
                    }
                }
                childrens.Clear();
            }
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
            BFS g = new BFS(4);

            g.Add(0, 1);
            g.Add(0, 2);
            g.Add(1, 2);
            g.Add(2, 0);
            g.Add(2, 3);
            g.Add(3, 3);
            g.BFSSearch(2);
        }
    }
}