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
        public string  Key { get; set; }
        public Vertice  refer { get; set; }
        public Vertice()
        {
            refer = null;
        }
    }
    public class GraphList
    {
       static Dictionary<string, Vertice> GraphDb = new Dictionary<string, Vertice>();
        // Time Complexity
        //  Worst Case : O(N)
        // Average Case : O(N)
        // Best Case : O(1)
        // Space Complexity O(1)
        public static void Push(string edeg,string vertice)
        {
            Vertice newVertice = new Vertice() { Key = vertice };
            if (GraphDb.ContainsKey(edeg))
            {
                Vertice v = GraphDb[edeg];
                Vertice temp = v;
                while (temp.refer != null)
                {
                    temp = temp.refer;
                }

                temp.refer = newVertice;
            }
            else
            {
                GraphDb.Add(edeg, newVertice);
            }
        }
        // Time Complexity
        //  Worst Case : O(N)
        // Average Case : O(N)
        // Best Case : O(1)
        // Space Complexity O(1)
        public static void Pop(string vertice)
        {
            if (GraphDb.ContainsKey(vertice.ToUpper()))
            {
                GraphDb.Remove(vertice.ToUpper());
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
        // Time Complexity
        //  Worst Case : O(N^2)
        // Average Case : O(N^2)
        // Best Case : O(1)
        // Space Complexity O(1)
        public static void GetAll()
        {
            foreach(var key in GraphDb.Keys)
            {
                Vertice temp= GraphDb[key];
                Console.Write($"{key}: ");
                while (temp != null)
                {
                    Console.Write($"{temp.Key} ");
                    temp=temp.refer;
                }
                Console.WriteLine();
            }
        }
        // Time Complexity
        //  Worst Case : O(N)
        // Average Case : O(N)
        // Best Case : O(1)
        // Space Complexity O(1)
        public static void Search(string key)
        {
            if (GraphDb.ContainsKey(key))
            {
                Vertice temp = GraphDb[key];
                Console.Write($"{key}:");
                while(temp != null)
                {
                    Console.Write($"{temp.Key} ");
                    temp = temp.refer;
                };
            }
            else
            {
                Console.WriteLine("Not Found Key");
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
                Console.Write("Enter Edge:");
                string edg = Console.ReadLine().ToUpper();
                Console.Write("Enter Vertice:");
                string vertice=Console.ReadLine().ToUpper();
                
                GraphList.Push(edg,vertice);
                b++;
            }
            Console.WriteLine();
            Console.Write("Key you Would Like To Search: ");
            string key = Console.ReadLine();
            GraphList.Search(key);
            Console.WriteLine();
            GraphList.GetAll();
            Console.Write("Enter Vertice you are removing it :");
            string removeVertice = Console.ReadLine().ToUpper();
            GraphList.Pop(removeVertice);
            GraphList.GetAll();
        }
    }
}
