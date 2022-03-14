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
        public static int Num = 1;

        // Direct Recursion
        #region
        // Complexity Time :O(Power(2,N))
        // Complexity Space :O(1)
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
        // Direct Method
        // Complexity Time :O(Power(1,N))
        // Complexity Space :O(1)
        public static int Fact(int N)
        {
            if (N == 1) return 1;
            else
                return N * Fact(N - 1);
        }
        #endregion
        // Void Main
        #region
        // Complexity Time :O(1)
        // Complexity Space :O(1)
        static void Main(string[] args)
        {
            //Console.WriteLine(Fact(5));
            //Console.WriteLine(Fabi(5));
            Odd();
        }
        #endregion
        // Indirect Recursion
        #region
        // Complexity Time :O(1)
        // Complexity Space :O(1)
        public static void Odd()
        {
            if (Num <= 10)
            {
                Console.WriteLine(Num+1);
                Num++;
                Even();
            }
            
        }
        // Complexity Time :O(1)
        // Complexity Space :O(1)
        public static void Even()
        {
            if (Num <= 10)
            {
                Console.WriteLine(Num -1);
                Num++;
                Odd();
            }
           
        }
        #endregion









    }
}
