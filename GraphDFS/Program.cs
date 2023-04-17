/* - Depth First Search..
 * Time Complexity O(V+E)
 */
using System;
namespace GraphDFS {
    public class Graph {
        private int V;
        public LinkedList<int>[] dfs;
        public bool[] Vistited;
        public Graph(int v)
        {
            V = v;
            Vistited=new bool[V];
            dfs = new LinkedList<int>[v];
            for (int i = 0; i < v; i++)
            {
                dfs[i] = new LinkedList<int>();
            }
        }
        public void addEdge(int v, int e)
        {
            dfs[v].AddLast(e);
        }
        // DFS by Iterations.
        public void DFS(int v)
        {
             LinkedList<int> list = new LinkedList<int>();  
            list.AddLast(v);
            Vistited[v]= true;
            while (list.Count > 0)
            {
                int i = list.Last.Value;
                Console.Write($"{i} ");
                list.RemoveLast();
                foreach (var item in dfs[i])
                {
                    if (!Vistited[item])
                    {
                        list.AddLast(item);
                        Vistited[item] = true;
                    }
                }
            }
        }
        // By Recurive .. 
        public void RecursiveDFS(int v)
        {
            Vistited[v] = true;
             Console.Write($"{v} ");
            foreach (var item in dfs[v])
            {
                if (!Vistited[item])
                {
                 
                    RecursiveDFS(item);
                }
            }
        }
    }

    public class Program {
        private static void Main(string[] args)
        {
            Graph g = new Graph(4);
            g.addEdge(0, 1);
            g.addEdge(0, 2);
            g.addEdge(1, 2);
            g.addEdge(2, 3);
            g.DFS(0);
            g.RecursiveDFS(0);
        }
    }
}
