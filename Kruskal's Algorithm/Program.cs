using System;
namespace KruskalAlgorithms {
    public class Graph {
        public int Vertice1 { get; set; }
        public int Vertice2 { get; set; }
        public int Weight { get; set; }
    }
    public class Kruskal {
        public List<Graph> graphs;
        public Kruskal()
        {
                graphs = new List<Graph>();
        }
        public void Add(int v1, int v2, int w)
        {
            Graph ob = new Graph();
           ob.Vertice1 = v1;
           ob.Vertice2 = v2;
           ob.Weight = w;
            graphs.Add(ob);
        }
        public int Action(int v)
        {
            // Order By Wight 
            graphs = graphs.OrderBy(w => w.Weight).Take(v).ToList();
            return graphs.Sum(s => s.Weight);
        }
    }
    internal class Program {
        private static void Main(string[] args)
        {
                  Kruskal obj = new Kruskal();
            obj.Add(1, 3, 5);
            obj.Add(2,4, 7);
            obj.Add(2, 1, 2);
            obj.Add(3, 2, 3);
            obj.Add(0, 3, 3);
            obj.Add(4, 0, 12);
            int res = obj.Action(4);
            Console.WriteLine(res);
        }
    }
}
