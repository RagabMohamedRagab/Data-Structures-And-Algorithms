// 24 -11-2022 : 12:50 Am
// Insertion Algorithm.
// Time Complexity : O(N^2) 
/* Example
 * # Path1 key =2
 * 5 2 10 1 9 30 4 20 0
 * 5 5 10 1 9 30 4 20 0
 * 2 5 10 1 9 30 4 20 0
 * # Path2 key =10
 * 2 5 10 1 9 30 4 20 0
 * # Path3 key = 1
 * 2 5 10 1 9 30 4 20 0
 * 2 5 10 10 9 30 4 20 0
 * 2 5 5 10  9 30 4 20 0
 * 2 2 5 10  9 30 4 20 0
 * 1 2 5 10  9 30 4 20 0
 * # Path4 key=9
 * 1 2  5 10 10 30 4 20 0
 * 1 2  5 9  10 30 4 20 0
 * # Path5  Key=30
 * 1 2 5 9 10 30 4 20 0
 * # Path6 key=4
 * 1 2 5 9 10 30 30 20 0
 * 1 2 5 9 10 10 30 20 0
 * 1 2 5 9 9 10 30 20 0
 * 1 2 5 5 9 10 30 20 0
 * 1 2 4 5 9 10 30 20 0
 * # Path7 key= 20
 * 1 2 4 5 9 10 30 30 0
 * 1 2 4 5 9 10 20 30 0
 * # Path8 Key=0
 * 1 2 4 5 9 10 20 30 30
 * 1 2 4 5 9 10 20 20 30
 * 1 2 4 5 9 10 10 20 30
 * 1 2 4 5 9 9 10 20 30
 * 1 2 4 5 5 9 10 20 30
 * 1 2 4 4 5 9 10 20 30
 * 1 2 2 4 5 9 10 20 30
 * 1 1 2 4 5 9 10 20 30
 * 0 1 2 4 5 9 10 20 30
  Result = 0 1 2 4 5 9 10 20 30
 */

using System;

namespace Sort {
    public class Insertion
    {
        // Time Complexity O(N^2)
        // Space Complexity + Auxiliary Space = O(N)
        public void Action(int []Arr,int size)
        {
            int i = 1;
            while(i< size)
            {
                int key = Arr[i];
                int j = i - 1;
                while (j >= 0 && key < Arr[j])
                {
                    Arr[j + 1] = Arr[j];
                    j= j - 1;
                }
                Arr[j + 1] = key;
                i++;
            }
        }
        // Time Complexity O(N)
        // Time Complexity O(N)
        public void Display(int []Arr,int size)
        {
            foreach (var item in Arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }

   public class Program
    {
        // Time Complexity O(N)
        // Space Complexity O(1)
        static void Main(string[] args)
        {
            int N;
            bool Istrue;
            Console.WriteLine("PLZ Enter Correct N:");
            do
            {
                Istrue = Int32.TryParse(Console.ReadLine(), out N);
            }while(!Istrue);
            int[]Arr=new int[N];
            for(int i=0; i<N; i++)
            {
                Arr[i] = Int32.Parse(Console.ReadLine());
            }
            Insertion inser = new Insertion();
            inser.Display(Arr, N);
            inser.Action(Arr, N);
            inser.Display(Arr, N);
        }
    }
}
