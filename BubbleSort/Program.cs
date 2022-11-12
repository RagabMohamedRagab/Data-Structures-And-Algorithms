// Time Complexity O(N^2)
// Space Complexity O(1)
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
 *  if(arr[j]>arr[j+1]  // 4>1 true - 1>3 false - 1>9 false 1>9 false  
 *   { 
 *   swap(arr[j],arr[j+1])
 *    }
 *    
 *    ------
 *    #path2
 *    index : 0 1 2 3 4
 *    value  : 1 4 3 9 7
 *    min=4 3
 *    i=1
 *    j=2 3 4
 *    if(arr[j]>arr[j+1] 4>3 true - 3>9 false - 3>7 false
 *    {
 *     swap(arr[j],arr[j+1])
 *    }
 *    swap(4,3)
 *    -----------
 *    #path3
 *    index:  0 1 2 3 4 
 *    value:   1 3 4 9 7
 *    min=4
 *    i=2
 *    j=3 9
 *    if(arr[j]>arr[j+1]) 4>9 false -4>7  
 *    {
 *       swap(arr[j],arr[j+1])
 *    }
 *    swap(4,4)
 *    --------
 *    #path4
 *    index : 0 1 2 3 4
 *    value :  1 3 4 9 7 
 *    min=9 7
 *    i=3
 *    j=4
 *    if(arr[j]>arr[j+1]) 9>7 true   
 *    {
 *       swap(arr[j],arr[j+1])
 *    }
 *    swap(9,7)
 *    ----
 *    finally
 *    
 *    ------------------
 *    Result :  1 3 4 7 9 
 */
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

