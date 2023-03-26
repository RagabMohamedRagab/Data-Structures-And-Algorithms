using System;
namespace GraphDFS {
   public class Graph
    {
        private int V;
        public LinkedList<int>[] dfs;
        public Graph(int v)
        {
            V= v;
            dfs=new LinkedList<int>[v];
            for (int i = 0; i < v; i++)
            {
                dfs[i] = new LinkedList<int>();
            }
        }
        public void AddEge(int v,int e)
        {
            dfs[v].AddLast(e);
        }
        public void DFS(int v)
        {
            LinkedList<int> adjacent=new LinkedList<int>();
            bool[]Vistited= new bool[v];
            adjacent.AddLast(v);
            Vistited[v] = true;
            int pop = adjacent.Last();
            adjacent = dfs[pop];  
            adjacent.RemoveLast();
            foreach (var item in adjacent)
            {
                if (!Vistited[item])
                {
                    Vistited[item] = true;
                   adjacent.AddLast(item);
                }
            }
        }
    }
    
    public class Program
    {
        private static void Main(string[] args)
        {

        }
    }
}
