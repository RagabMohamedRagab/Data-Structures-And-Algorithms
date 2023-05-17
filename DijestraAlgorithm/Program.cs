/* Dijkestra Algorithm - Shortest Path 
 -  Time Complexity O(V^2)
 - Aulixary Complexity O(V)
 */
using System.Security.Cryptography.X509Certificates;

namespace DijestraAlgorithm {
  public  class Graph
    {
        public int v;
        public List<(int, int)>[] dksta;
        public Graph(int V)
        {
            v = V;
            dksta=new List<(int, int)>[V];
            for(int i = 0; i < V; i++)
            {
                dksta[i] = new List<(int, int)>();
            }
        }
        public void AddEdge(int e,int v,int w)
        {
            dksta[v].Add((e, w));
            dksta[e].Add((v, w));
        }
        // Time Complexity O(N^3)
        public int[] Dijkestra(int init)
        {
            bool[] visited= new bool[v];
            int[]dist= new int[v];
            for(int a=0; a<v; a++)
            {
                dist[a] = int.MaxValue;
            }
            dist[init] = 0;
            for(int k = 0; k < v - 1; k++)
            {
                int u = minimDistance(dist, visited);// Distance Between initial Vertice And neigbour Vertices;
                visited[u]=true;
                foreach ((int, int) edge in dksta[u])
                {
                    int v = edge.Item1;
                    int w= edge.Item2;
                    if (!visited[v] && dist[u] + w <= dist[v])
                    {
                        dist[v] = dist[u] + w;
                    }
                }
            }
            return dist;
        }
        public int minimDistance(int[] distance, bool[]vistited)
        {
            int minimValue = int.MaxValue;
            int minimIndex = -1;
            for(int b = 0; b < v; b++)
            {
                if (!vistited[b] && distance[b] <= minimValue)
                {
                    minimValue = distance[b];
                    minimIndex = b;
                }
            }
            return minimIndex;
        }
    }
    class Program
    {
        private static void Main(string[]args)
        {
            Graph graph = new Graph(9);
            graph.AddEdge(0, 1, 4);
            graph.AddEdge(0, 7, 8);
            graph.AddEdge(1, 2, 8);
            graph.AddEdge(1, 7, 11);
            graph.AddEdge(2, 3, 7);
            graph.AddEdge(2, 8, 2);
            graph.AddEdge(2, 5, 4);
            graph.AddEdge(3, 4, 9);
            graph.AddEdge(3, 5, 14);
            graph.AddEdge(4, 5, 10);
            graph.AddEdge(5, 6, 2);
            graph.AddEdge(6, 7, 1);
            graph.AddEdge(6, 8, 6);
            graph.AddEdge(7, 8, 7);
            int[] dist = graph.Dijkestra(0);

            Console.WriteLine("Vertex Distance from Source");
            for (int i = 0; i < dist.Length; i++)
            {
                Console.WriteLine("{0}\t\t{1}", i, dist[i]);
            }

        }
    }
}