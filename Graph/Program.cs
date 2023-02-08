/* 
 * Graph : It Combines from Vertices and Edges.
 * Representation Grap 
 *      1- Matrix : Easy Code - Space Complexity O(V^2)
 *      2- List  : Complex Code - Space Complexity O(V+E) - Dictionary
 * Date   6-2-2023 10:04 PM
*/
namespace Graph {
    public  class Vertice
    {
        public int  Key { get; set; }
        public Vertice  Edge { get; set; }
        public Vertice()
        {
            Edge = null;
        }
    }
    public class GraphList
    {
       static Dictionary<string, Vertice> GraphDb = new Dictionary<string, Vertice>();

        public static void Push(string vertice, int data)
        {
            Vertice newVertice = new Vertice() { Key = data };
            if (GraphDb.ContainsKey(vertice))
            {
                Vertice v = GraphDb[vertice];
                Vertice temp = v;
                while (temp.Edge != null)
                {
                    temp = temp.Edge;
                }

                temp.Edge = newVertice;
            }
            else
            {
                GraphDb.Add(vertice, newVertice);
            }
        }
    }
    class Program
    {
        static void Main(string[] args) {
            Console.Write("Number of Vertice:");
            int size = Int32.Parse(Console.ReadLine());
            int b = 0;
            while(b< size)
            {
                Console.Write("Enter Vertice:");
                string vertice=Console.ReadLine();
                Console.Write("Enter Key");
                int key=Int32.Parse(Console.ReadLine());
                GraphList.Push(vertice, key);
                b++;
            }

        }
       
       
    }
}
