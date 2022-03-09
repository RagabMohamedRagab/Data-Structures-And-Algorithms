/* - Recursive : Which is method calls Itself Directly or Indirectly 
 *         1- Base Case : it will terminate Recursion
 *         2- Recursion Procedure : It Calls ItSelfs 
 *  Complexity Time X Power Of Y
 *   X : Number Of Function 
 *   Y : Name Of Parameter
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace Recursion
{
    class Program
    {
        public static int Fabi(int N)
        {
            if (N < 2)
            {
                return N;
            }
            else
            {
                return Fabi(N - 1) + Fabi(N - 2);
            }
        }
        public static int Fact(int N)
        {
            if (N == 1) return 1;
            else
                return N * Fact(N - 1);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Fact(5));
            Console.WriteLine(Fabi(6));
        }
    }
}
