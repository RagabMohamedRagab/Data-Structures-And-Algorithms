/*
   1- Complexity Running Time.?
     - Complexity Time [Performace]
     - Complexity Space [Memory]  
  
  2- To Compute Complexity Running Time ?
     - Omega Notation [Best Case] - [Lower Case ]
     - Theta Notation [Average Case] - [Middel Case]
     - Big Order Notaion [Worst Case] -[Upper Case]


  3- When We Give ACollection Of The Items 
          <!-----Constant Time ::Statement::Operations---> T(n) belong To O(1)=1
          <!---- Iterate Each Items -----> :: T(n) belong To O(n)
          <!---- Iterate Part From Collection -----> :: T(n) belong to O(logn) 
          <!-----Recursion Method-------->:: T(n) belong To O(2^n) When Sum And Sub
          <!-----Recursion Method-------->:: T(n) belong To O(Logn) When Div And Multi     
 */

using System;
namespace Complexity_Running_Time
{

    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            double Result = n * (n + 1) / 2;
            // Complexity Time = 1 = 1
            // T(n) Belong To Big O(1)=1

            for (int i = 0; i < n; i++)
            {
                // Your Statement
            }
            // Complexity Time = 1 + n = n
            // T(n) Belong To Big O(n)

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //Your Statement 
                }
            }
            // Complexity Time = 1 + n *n = 1 + n^2 
            // T(n) Belong To Big O(n^2)

            for (int i = 0; i < n; i /= 2)
            {
                // Your Statement
            }
            // Complexity Time = 1 + logn =log n 
            // T(n) Belong To Big O(log n)

            for (int i = 0; i < n; i /= 2)
            {
                for (int j = 0; j < n; j /= 2)
                {
                    // Your Statement
                }
            }
            // Complexity Time = logn * logn =logn^2 
            // T(n) Belong To Big O(logn^2)

            for (int i = 0; i < n; i /= 2)
            {
                for (int j = 0; j < n; j++)
                {
                    //Your Statement 
                }
            }

            // Complexity Time = logn * n = nlogn 
            // T(n) Belong To Big O(nlogn)

        }
        public static int Fact(int N)
        {
            if (N == 1)
                return 1;
            else
                return N * Fact(N - 1);
        }

        // Complexity Time =  1 ^ N
        //  T(n) Belong To Big O(1 ^ N)
        public static int FIb(int N)
        {
            if (N == 1)
                return 1;
            else
                return FIb(N - 1) + FIb(N - 2);
        }

        // Complexity Time =  2 ^ N
        //  T(n) Belong To Big O(2 ^ N)
        public static double Div(double N)
        {
            if (N == 0)
                return 1;
            else
                return Div(N / 2);
        }

        // Complexity Time = logn
        //  T(n) Belong To Big O(logn) 
        public static void Infinite()
        {
            for(int i=0; ; i++)
            {
                // Your Statement
            }
        }
        // Complexity Time = O(∞)
        // T(n) Belong to Big  O(∞)
    }
}
