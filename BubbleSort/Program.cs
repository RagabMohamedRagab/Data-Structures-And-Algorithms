using System;
namespace BubbleSorting {
    public class Bubble {
        // Time Complxity O(N^2)
        // Space Complexity || Auxiliary Space  O(N)
        bool flag = true;
        public void SortArr(int[] A, int size)
        {
            int a = 0;
            while (a < size)
            {
                int b = 0;
                while (b < size - a - 1)
                {
                    if (A[b] > A[b+1])
                    {
                        Swap(ref A[b], ref A[b+1]);
                        flag=false;
                    }
                    b++;
                }
                if (flag) // If Colllection is Sorted
                {
                    break;
                }
                a++;
            }
        }
        // Time Complexity O(1)
        // Space Complexity [Input] + Auxiliary Space [OutPut] =  O(1)
        void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
        public void Display(int[] A, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{A[i]} ");
            }
        }
    }
    class Program {
        static void Main(string[] args)
        {
            int size = Int32.Parse(Console.ReadLine());
            int[] A = new int[size];
            int i = 0;
            while (i < size)
            {
                A[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            Bubble bubble = new Bubble();
        
            bubble.Display(A, size);
            bubble.SortArr(A, size);
            Console.WriteLine();
            bubble.Display(A, size);
        }
    }
}

