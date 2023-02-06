/* 
 * Graph : It Combines from Vertices and Edges.
 * Representation Grap 
 *      1- Matrix : Easy Code - Space Complexity O(V^2)
 *      2- List  : Complex Code - Space Complexity O(V+E) - Dictionary
 * Date   6-2-2023 10:04 PM
*/
using System;
namespace GraphDb {
    public class Vertice
    {
        public int key { get; set; }
        public Vertice Next { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Vertice> Graph=new Dictionary<string, Vertice>();

        }
    }
}
