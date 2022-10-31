// Date : 31-10-2022
namespace SelectionSort {
   public class Selection {
        // Attributes
        // Time Complexity O(N^2)
        // Space Complexity || Aulxiliary Space  O(1)
        public void Action(int[]A,int size)
        {
            int min;
            for(int x = 0; x < size-1; x++)
            {
                min = x;
                int y = x + 1;
                 while(y < size)
                {
                    if (A[min] > A[y])
                    {
                        min = y;
                    }
                    y++;
                }

                Swap(ref A[x], ref A[min]);
            }
        }
        // Time and Space Complexity O(1)
        void Swap(ref int first,ref int second)
        {
            int swap = first;
            first = second;
            second = swap;
        }
        // Time Complexity O(N)
        // Space Complexity O(N)
        public void Display(int []A,int size)
        {
            int a = 0;
            while(a < size)
            {
                Console.Write($"{A[a]} " );
                a++;
            }
        }
    }
   public class Program {
        // Time Complexity O(N)
        // Space Complexity O(N)
      static void Main(string[] args)
        {
            int size = Int32.Parse(Console.ReadLine());
            int[] Arr = new int[size];
            int a = 0;
            while(a < Arr.Length)
            {
                Arr[a] = Int32.Parse(Console.ReadLine());
                a++;
            }
            Selection selection = new Selection();
            selection.Display(Arr,size);
            selection.Action(Arr, size);
            Console.WriteLine();
            selection.Display(Arr, size);
        }
    }
}
