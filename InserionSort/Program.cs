using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InserionSort
{
    class Insertion
    {
        // Create Insertion 
        public void Sort(int[] Arr)
        {

            int Size = Arr.Length;
            for(int i = 1; i < Size; i++)
            {
                int Key = Arr[i];
                int j = i - 1;
                while (j >= 0 && Arr[j] > Key) 
                {
                    Arr[j + 1] = Arr[j];
                    j -= 1;
                }
                Arr[j + 1] = Key;
            }
        }
        public void Print(int[] Arr)
        {
            foreach (var item in Arr)
            {
                Console.Write(item+" ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Insertion insertion = new Insertion();
            int[] Arr = new int[] { 4, 3, 2, 1 };
            Console.WriteLine("Before Sort:");
            insertion.Print(Arr);
            insertion.Sort(Arr);
            Console.WriteLine("\nAfter Sort:\n");
            insertion.Print(Arr);
            Console.WriteLine();
        }
    }
}
