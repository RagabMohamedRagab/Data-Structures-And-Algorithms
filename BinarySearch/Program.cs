// Happy Fuken Code
// Collection Must Be Sorting ..
// Time Complexity O((logn)^2)
// Space Complexity O(1)
using System;
namespace BinarySearch {
    class Binary
    {
        // Time Complexity (Logn)^2
        public int Search(int[]A,int L,int R,int Key)
        {
            while (L <= R)
            {
                int mid = L + (R - L) / 2;
                // (L+R)/2
                if (A[mid] == Key)
                {
                    return mid;
                }else if (A[mid] < Key)
                {
                    L = mid + 1;
                }
                else
                {
                    R = mid - 1;
                }
            }
            return -1;
        }
    }
    class Program
    {
        // Time Complexity O(1)
        static void Main(string[] args)
        {
            int[] Arr = new int[] { 1, 6, 10, 15, 18, 22, 31, 40, 55, 60, 70, 80 };
            Binary binary = new Binary();
            int key = Int32.Parse(Console.ReadLine());
          int result=binary.Search(Arr, 0, Arr.Length - 1, key);
            if (result == -1)
            {
                Console.WriteLine($"Not Found Item {key}");
            }
            else
            {
                Console.Write($"Found item : {key} in Index : {result}");
            }
        }
    }
}