using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        //  Recursion Derictly
        public static int Fac(int N)
        {
            if (N == 0 || N == 1)
                return N;
            else
                return Fac(N - 2) + Fac(N - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fac(7));
        }
    }
}
