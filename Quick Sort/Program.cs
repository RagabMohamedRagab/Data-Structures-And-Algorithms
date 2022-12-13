// Time Complexity O(Nlogn)
// Space Complexity O(1)
using System;
using System.Globalization;

namespace Quick_Sort {
    public class Quick
    {
        void Swap(ref int a,ref int b)
        {
            int t = a;
            a = b;
            b=t;
        }
        public int Action2(int[]A,int l,int r)
        {
            int pivot = A[l];
            int i = l,j = r;
            while (i < j)
            {
                do
                {
                    i++;
                } while (pivot >= A[i]);
                do
                {
                    j--;
                } while (pivot < A[j]);
                if (i < j)
                {
                    Swap(ref A[i], ref A[j]);
                }
              
                    Swap(ref A[j], ref A[l]);
                
            }
            return j;
        }
        public int Action(int[]A,int Bl,int Br)
        {
            int l = Bl;
            int r = Br;
            int Pivot = l;
            while (true)
            {
                while (A[Pivot] < A[r])
                {
                    r--;
                }
                if(Pivot==r)
                {
                    break;
                }
                else if (A[Pivot] > A[r]){
                    Swap(ref A[Pivot],ref A[r]);
                    Pivot = r;
                }
                while (A[Pivot] > A[l])
                {
                    l++;
                }

                if (Pivot == l)
                {
                    break;
                }
                else if (A[Pivot] < A[l])
                {
                    Swap(ref A[Pivot],ref A[l]);
                    Pivot = l;
                }
            } 
            return Pivot;
        }
        public void QuickSort(int[]A,int l,int r)
        {
            if (l < r)
            {
                int pivot=Action2(A,l,r);
                QuickSort(A,l,pivot-1);
                QuickSort(A,pivot+1,r);
            }
        }
        public void Display(int[] A)
        {
            foreach (var item in A)
            {
                Console.Write(item +" ");
            }
            Console.WriteLine();
        }
    }
    public class Program {
        static void Main(string[] args)
        {
            int[] Arr = new int[] { 40, 20, 60, 10, 30, 50 };
            Quick quick = new Quick();
            quick.Display(Arr);
            quick.QuickSort(Arr, 0, Arr.Length - 1);
            quick.Display(Arr);
        }
    }
}
