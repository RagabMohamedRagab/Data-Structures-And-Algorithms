/* 
 * Graph : It Combines from Vertices and Edges.
 * Representation Grap 
 *      1- Matrix : Easy Code - Space Complexity O(V^2)
 *      2- List  : Complex Code - Space Complexity O(V+E) - Dictionary
 * Date   6-2-2023 10:04 PM
*/
using System.Numerics;

namespace Graph {
    public class Vertice {
        public string Key { get; set; }
        public Vertice refer { get; set; }
        public bool vistited { get; set; }
        public Vertice()
        {
            refer = null;
            vistited= false;
        }
    }
    // Represent Graph By List (Dictionary)
    public class GraphList {
        static Dictionary<string, Vertice> GraphDb = new Dictionary<string, Vertice>();
        // Time Complexity
        //  Worst Case : O(N)
        // Average Case : O(N)
        // Best Case : O(1)
        // Space Complexity O(1)
        public static void Push(string edeg, string vertice)
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
            foreach (var key in GraphDb.Keys)
            {
                Vertice temp = GraphDb[key];
                Console.Write($"{key}: ");
                while (temp != null)
                {
                    Console.Write($"{temp.Key} ");
                    temp = temp.refer;
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
                while (temp != null)
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
    // Represent Graph By Matrix
    public class GraphMatrix {
        int size;
        static int[,] Matrix = null;
        public GraphMatrix(int N)
        {
            this.size = N;
            Matrix = new int[size, size];
        }
        // Time Complexity O(1)
        public static void Pop(int e,int v)
        {
            Matrix[e, v] = 0;
            Matrix[v, e] = 0;
        }
        // Time Complexity O(1)
        public static string Search(string[]Arr,string vertice)
        {
            var data = Arr.SingleOrDefault(b => b == vertice);
            return data is null ? "Not Found" : $"Found {vertice}";
        }
        // Time Complexity O(1)
        public static void Push(int v, int e, int w)
        {
            Matrix[v, e] = w;
            Matrix[e, v] = w;
        }
        // Time Complexity O(N^2)
        public static void GetAll()
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    class Program {
        // Time Complexity O(N^3)
        static void Main(string[] args)
        {
            Console.Write("Number of Vertice:");
            int size = Int32.Parse(Console.ReadLine());
            int y = 0;
            while (y < size)
            {
                Console.Write("Enter Edge:");
                string edg = Console.ReadLine().ToUpper();
                Console.Write("Enter Vertice:");
                string vertice1 = Console.ReadLine().ToUpper();

                GraphList.Push(edg, vertice1);
                y++;
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
            // ----------------------------Represent by Matrix-----------------------
            Console.Write("Size of Matrix:");
            int matrix = Int32.Parse(Console.ReadLine());
            GraphMatrix graphMatrix = new GraphMatrix(matrix);
            string[] Vertic = new string[matrix];
            for (int i = 0; i < Vertic.Length; i++)
            {
                Vertic[i] = Console.ReadLine();
            }
            for (int a = 0; a < Vertic.Length; a++)
            {
                for (int b = 0; b < Vertic.Length; b++)
                {
                    Console.Write("Enter Edge:");
                    string u = Console.ReadLine();
                    Console.Write("Enter Vertice:");
                    string v = Console.ReadLine();
                    Console.Write("Weight :");
                    int w = Int32.Parse(Console.ReadLine());
                   int []Arr= GetEdgesAndVer(Vertic, v, u);
                    GraphMatrix.Push(Arr[1], Arr[0], w);
                }
            }
            GraphMatrix.GetAll();
            Console.Write("Enter Edge You Removed It:");
            string e = Console.ReadLine();
            Console.Write("Enter Vertice You Removed It:");
            string v2 = Console.ReadLine();
            int[]A=GetEdgesAndVer(Vertic, v2, e);
            GraphMatrix.Pop(A[0], A[1]);
            Console.Write("Enter Vertice:");
             string vertice=Console.ReadLine();
            Console.WriteLine(GraphMatrix.Search(Vertic, vertice));
            GraphMatrix.GetAll();
        }
        // Time Complexity O(N)
        public static int [] GetEdgesAndVer(string[]Vertices,string ver,string e) 
        {
            int vindex = 0, eindex = 0;
            for (int j = 0; j < Vertices.Length; j++)
            {
                if (Vertices[j] == e)
                {
                    eindex = j;
                }
                if (Vertices[j] == ver)
                {
                    vindex = j;
                }   
            }
            return new int[]{ eindex,vindex };
        }
        
    }
}




