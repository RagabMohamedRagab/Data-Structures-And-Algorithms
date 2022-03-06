/*  - Bubble Sort 
 *  - Complexity Time Big O Notaion (N^2)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Bubble
    {
        // Create Bubble Sort
        // Big O(N^2).
        public void BubbleSort(int []Arr)
        {
            int i = 0;
            while (i<Arr.Length)
            {
                for (int j = 0; j < Arr.Length-i-1; j++)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        Swap(ref Arr[j], ref Arr[j + 1]);
                    }
                }
                i++;
            }
        }
        // Swap
        // Big O(1)
        static void Swap(ref int large, ref int Min)
        {
            int tem = large;
            large = Min;
            Min = tem;
        }
        // Print 
        // Big O(N)
        public void Print(int[] Arr)
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
            int[] Arr = new int[8] { 7, 3, 1, 2, 0, 5, 4, 3 };
            Bubble bubble = new Bubble();
            Console.WriteLine("Before Sort..");
            bubble.Print(Arr);
            bubble.BubbleSort(Arr);
            Console.WriteLine("\nAfter Sort..");
            bubble.Print(Arr);
            Console.WriteLine();
            // Space Complexity = 8*4
        }
    }
}
