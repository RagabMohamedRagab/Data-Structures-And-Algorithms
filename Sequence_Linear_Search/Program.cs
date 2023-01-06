// Happy Code
// Time Complexity O(N) : best Case O(1) : Average case O(N)
// Space Complexity O(1)
using System;
namespace Sequence_Linear_Search {
   public class Linear
    {
        public int LinearSearch(int[]Arr,int size,int key)
        {
            for(int i = 0; i < size; i++)
            {
                if (Arr[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 90, 10, 50, 5 };
            Linear linear = new Linear();
            Console.Write("Enter Key:");
            int key = Int32.Parse(Console.ReadLine());
            int Result= linear.LinearSearch(arr, arr.Length, key);
            if (Result == -1)
            {
                Console.WriteLine($"Not Found Item {key}");
            }
            else
            {
                Console.Write($"Found item : {key} in Index : {Result}");
            }
        }
    }
}