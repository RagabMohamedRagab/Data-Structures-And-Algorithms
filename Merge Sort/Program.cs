/* Worst Average NlogN
 * Space Complexity O(N)
 * - What Is Merge ?
 * That Mains Combine Between Two Arrays in the another Array become Sorting.
 * - How is it ?
 * while(i<sizeofA1&&j<sizeofA2){
 *   if(A1[i]<A2[j]){
 *     A3[k]=A[i];
 *     i++;
 *   }else{
 *     A3[k]=A[j];
 *     j++;
 *   }
 *   k++;
 * }
 * while(i<sizeofA1){
 *   A3[k]=A1[i];
 *   i++;
 *   k++;
 * }
 * while(j<sizeofA2){
 *  A3[k]=A2[j];
 *  j++;
 *  k++;
 * }
 * 
 */
using System;
namespace Merge {
  public  class MegeSort
    {
        public void Sort(int[] A, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (int a = 0; a < n1; a++)
            {
                L[a] = A[a + l];
            }
            for (int b = 0; b < n2; b++)
            {
                R[b] = A[m + 1 + b];
            }
            int i = 0, j = 0, k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    A[k] = L[i];
                    i++;
                }
                else
                {
                    A[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                A[k] = L[i];
                k++;
                i++;
            }
            while (j < n2)
            {
                A[k] = R[j];
                j++;
                k++;
            }
        }
        public void ActionHelper(int[] A, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                ActionHelper(A, l, m);
                ActionHelper(A, m+1, r);
                Sort(A, l, m, r);
            }
        }
        public void Display(int []A)
        {
            foreach (var item in A)
            {
                Console.Write(item+" ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 30, 20, 40, 5, 90, 80, 10 };
            MegeSort megeSort = new MegeSort();
            megeSort.Display(A);
            megeSort.ActionHelper(A, 0, 6);
            Console.WriteLine();
            megeSort.Display(A);
        }
    }

}
