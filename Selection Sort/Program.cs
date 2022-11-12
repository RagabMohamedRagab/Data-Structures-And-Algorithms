// Date : 31-10-2022
/*
 * Time Complexity : O(N^2)
 * Space Complexity : O(1)
 * 
 * Example :
 * arr[] = {4, 1, 3, 9, 7}
 *  #Path 1
 * index :    0   1  2  3   4  
 * value :    4   1  3  9  7
 * 
 *  min=4 1 
 *  i=0
 *  j=1 2 3 4
 *  if(min>arr[j]  // 4>1 true - 1>3 false - 1>9 false 1>9 false  
 *   { 
 *     min=arr[j];
 *    }
 *    swap(4,1)
 *    ------
 *    #path2
 *    index : 0 1 2 3 4
 *    value  : 1 4 3 9 7
 *    min=4 3
 *    i=1
 *    j=2 3 4
 *    if(min>arr[j] 4>3 true - 3>9 false - 3>7 false
 *    {
 *      min=arr[j];
 *    }
 *    swap(4,3)
 *    -----------
 *    #path3
 *    index:  0 1 2 3 4 
 *    value:   1 3 4 9 7
 *    min=4
 *    i=2
 *    j=3 9
 *    if(min>arr[j]) 4>9 false -4>7  
 *    {
 *      min=arr[j];
 *    }
 *    swap(4,4)
 *    --------
 *    #path4
 *    index : 0 1 2 3 4
 *    value :  1 3 4 9 7 
 *    min=9 7
 *    i=3
 *    j=4
 *    if(min>arr[j]) 9>7 true   
 *    {
 *      min=arr[j];
 *    }
 *    swap(9,7)
 *    ----
 *    finally
 *    
 *    ------------------
 *    Result :  1 3 4 7 9 
 */
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
