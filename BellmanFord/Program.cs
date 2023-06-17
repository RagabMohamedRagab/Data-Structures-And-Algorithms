// Directed Graph
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
        public void AddEdges(int v,int E,int w)
        {
            bellmanFord[v].Add((E,w));
        }
    }
    class Program {

        private static void Main(string[] args)
        {

        }
    }
}