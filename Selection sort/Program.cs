/*  - Logical Of Selection Sort
 *  - Big O Notaion  O(N^2)
 *  - Space Complexity O(N) || O(1)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_sort
{
    class Select
    {
        public  void Sort(int[] Arr)
        {
            int j, i;
            for (i = 0; i < Arr.Length-1; i++)
            {
                int Min = i;
                for ( j = i+1; j <=Arr.Length-1 ;j++ )
                {
                    if (Arr[j] < Arr[Min])
                    {
                        Min = j;
                    }
                }
                Swap(ref Arr[i],ref Arr[Min]);
            }
        }
        static void Swap(ref int large,ref int Min)
        {
            int tem = large;
            large = Min;
            Min = tem;
        }
        public  void Print(int[] Arr)
        {
            foreach (var item in Arr)
            {
                Console.Write(item+" ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[8] { 7, 3, 1, 2, 0 ,5,4,3}; // O(1)
            Select select = new Select(); // O(1)
            Console.WriteLine("\nBefore Sorting.."); // O(1)
            select.Print(Arr); //  O(N) 
            select.Sort(Arr);  // (N+1-1)= N * (N+1-1)=N*N= O(N^2) 
            Console.WriteLine("\nAfter Sorting.."); // O(1)
            select.Print(Arr); // O(N)
            Console.WriteLine(); // O(1)
            // Complexity Time = O(1)+O(1)+O(1)+O(N)+O(N^2)+O(1)+O(N)+O(1)
            //                = 1+1+1+N+N^2+1+N+1=  N^2+2N
            //                = Big O(N^2)
            //
        }
    }
}
