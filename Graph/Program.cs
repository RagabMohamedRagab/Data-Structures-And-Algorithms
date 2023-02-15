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
        public Vertice()
        {
            refer = null;
        }
    }
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
    public class GraphMatrix {
        int size;
        static int[,] Matrix = null;
        public GraphMatrix(int N)
        {
            this.size = N;
            Matrix = new int[size, size];
        }
        public static void Push(int v, int e, int w)
        {
            Matrix[v, e] = w;
            Matrix[e, v] = w;
        }
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
        static void Main(string[] args)
        {
            //Console.Write("Number of Vertice:");
            //int size = Int32.Parse(Console.ReadLine());
            //int b = 0;
            //while (b < size)
            //{
            //    Console.Write("Enter Edge:");
            //    string edg = Console.ReadLine().ToUpper();
            //    Console.Write("Enter Vertice:");
            //    string vertice = Console.ReadLine().ToUpper();

            //    GraphList.Push(edg, vertice);
            //    b++;
            //}
            //Console.WriteLine();
            //Console.Write("Key you Would Like To Search: ");
            //string key = Console.ReadLine();
            //GraphList.Search(key);
            //Console.WriteLine();
            //GraphList.GetAll();
            //Console.Write("Enter Vertice you are removing it :");
            //string removeVertice = Console.ReadLine().ToUpper();
            //GraphList.Pop(removeVertice);
            //GraphList.GetAll();
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
                    int vindex = 0, eindex = 0;
                    for (int j = 0; j < Vertic.Length; j++)
                    {
                        if (Vertic[j] == u)
                        {
                            eindex = j;
                        }
                        if (Vertic[j] == v)
                        {
                            vindex = j;
                        }
                    }
                    GraphMatrix.Push(vindex, eindex, w);
                }
            }

            GraphMatrix.GetAll();
        }
    }
}

