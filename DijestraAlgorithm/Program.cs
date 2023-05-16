/* Dijkestra Algorithm 
 -  Time Complexity O(V^2)
 - Aulixary Complexity O(V)
 */
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
    }
    class Program
    {
        private static void Main(string[]args)
        {
          
           
        }
    }
}