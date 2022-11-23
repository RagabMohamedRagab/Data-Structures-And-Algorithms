// 24 -11-2022 : 12:50 Am
// Insertion Algorithm.
// Time Complexity : O(N^2) 

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
                int key = i;
                int j = i - 1;
                while (j >= 0 && Arr[key] < Arr[j])
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
