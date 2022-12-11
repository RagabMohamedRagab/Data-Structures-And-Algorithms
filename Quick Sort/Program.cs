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
                if (A[Pivot] > A[r]){
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
                if (A[Pivot] < A[l])
                {
                    Swap(ref A[Pivot],ref A[l]);
                    Pivot = l;
                }
            } 
            return Pivot;
        }
    }
    public class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
