// Directed Graph   - Bellman Ford 
// Negative Weight ...
// Time Complexity O(V * E)
// Space Complexity O(V)
using System;
namespace BellmanFord {
    public class Bellman {
        public int verices;
        public List<(int, int)>[] bellmanFord;
        public Bellman(int v)
        {
             verices = v;
            bellmanFord=new List<(int, int)>[v];
            for(int i = 0; i < bellmanFord.Length; i++)
            {
                bellmanFord[i] = new List<(int, int)>();
            }
        }
        public void AddEdge(int v,int E,int w)
        {
            bellmanFord[v].Add((E,w));
        }
        public int[] BellManFordAlgorithm(int init)
        {
            bool[] visited = new bool[verices];
            int[] dist = new int[verices];
            for (int a = 0; a < verices; a++)
            {
                dist[a] = int.MaxValue;
            }
            dist[init] = 0;
            for (int k = 0; k < verices - 1; k++)
            {
                int u = FindMinumindistance(dist, visited);// Distance Between initial Vertice And neigbour Vertices;
                visited[u] = true;
                foreach ((int, int) edge in bellmanFord[u])
                {
                    int v = edge.Item1;
                    int w = edge.Item2;
                    if (!visited[v] && dist[u] + w <= dist[v])
                    {
                        dist[v] = dist[u] + w;
                    }
                }
            }
            return dist;
        } 
        private int FindMinumindistance(int[] distance, bool[] vistited)
        {
            int minimValue = int.MaxValue;
            int minimIndex = -1;
            for (int b = 0; b < verices; b++)
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
    class Program {

        private static void Main(string[] args)
        {
            Bellman graph = new Bellman(9);
            graph.AddEdge(0, 1, 4);
            graph.AddEdge(0, 7, 8);
            graph.AddEdge(1, 2, -8);
            graph.AddEdge(1, 7, 11);
            graph.AddEdge(2, 3, 7);
            graph.AddEdge(2, 8, 2);
            graph.AddEdge(2, 5, 4);
            graph.AddEdge(3, 4, -9);
            graph.AddEdge(3, 5, 14);
            graph.AddEdge(4, 5, -10);
            graph.AddEdge(5, 6, 2);
            graph.AddEdge(6, 7, -1);
            graph.AddEdge(6, 8, 6);
            graph.AddEdge(7, 8, -7);
            int[] dist = graph.BellManFordAlgorithm(0);

            Console.WriteLine("Vertex Distance from Source");
            for (int i = 0; i < dist.Length; i++)
            {
                Console.WriteLine("{0}\t\t{1}", i, dist[i]);
            }
        }
    }
}