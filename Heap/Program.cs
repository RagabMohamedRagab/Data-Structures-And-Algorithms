/* Heap : Based on Complelete Binary Tree
   Complete Binary Tree : All level of the Binary Tree  is complete Expected The Last Level.
- Example : 15 5 10 25 30 35 20
               15
             /    \    
            5      10
           / \    /  \  
          10  25 30  35
         /
        20
           Complete Binary Tree
** Started From Index 1
 - How To Get Left Child Of Parent : Index*2
 - How To Get Right Child Of Parent: (Index*2)+1
 - How To Get Parent Of Node : Index/2 
 ** Started From Index 0
  - How To Get Left Child Of Parent : (Index*2)+1
  - How To Get Right Child Of Parent : (Index*2)+2
  - How To Get Parent Of Node : (Index/2)-1
** Types Of Heap
  - Max Heap (Ascending)
  - Min Heap (Descending)

- Max Heap : It is meaning Parent Must be greating than or Equal their childern.

                  15 
                 /  \
                10   5
- Min Heap : It is meaning Parent Must be less Than or Equal their Childern.

                   5
                  / \
                 20  30


-- Solve Heap -----------------
  1- Get Array 
  2- Convert into Complete Binary Tree
  3- Convert Complete Binary tree to Max Heap Or Min Heap  by using HeapIfy
  4- Sorting max Heap or min Heap.

   Example :

    Index   0 1 2 3 4  5
    Array   3 7 5 2 10 4
              <=|=>
               
  - Convert Array into Complete Binary Tree
     
                3
              /  \
             7    5
            / \  / 
           2  10 4

   - Get First Index 5/2 = 2
   1- Array[2]= 5 Start there         
              3
             / \
            7   5
           / \  /
          2  10 4
   
    2- Arr[1]= 7

           3
          / \
         10  5
        / \  /
       2  7  4

   3- Arr[0]=3
  
        10
       /  \
      3    5
     / \   /
    2  7  4
   

   4- Arr[1]=7
 
       10
      /  \
     7    5
    / \   /
   2  3  4

  Finally:Max - Acending Array : 10 7 5 2 3 4 
----------------------------------------------
 */
using System;
namespace Heap_Sort {
    public class Heap {
        public void Heapify(int[] A, int size, int pos)
        {
            int L = (pos * 2) + 1; // Left Child Of pos
            int R = (pos * 2) + 2; // Right Child Of Pos
            int max = pos;    // Max or comparer
            if (L < size && A[L] < A[max])
            {
                max = L;
            }
            if (R < size && A[R] < A[max])
            {
                max = R;
            }
            if (max != pos)
            {
                Swap(ref A[max], ref A[pos]); 
                Heapify(A, size, max);
            }
           
        }
        void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
        public void BuildMaxHeap(int[] A, int size) // max | min heap => Convert Complete Binary Tree to Max or Min Heap 
        {
            int b = (size / 2) - 1;
            while (b >= 0)
            {
                Heapify(A, size, b);
                b--;
            }
        }
        public void HeapSort(int[] A, int size)
        {
            BuildMaxHeap(A, size);
            for (int i = size - 1; i >= 0; i--)
            {
                Swap(ref A[0], ref A[i]);
                Heapify(A, size, 0);
            }
        }
        public void Display(int[] A)
        {
            foreach (var item in A)
            {
                Console.Write(item + " ");
            }
        }
    }
    public class Program {
        static void Main(string[] args)
        {
            int[] A = new int[] { 90, 10, 40, 70, 5 };
            Heap heap = new Heap();
            heap.HeapSort(A, A.Length);
            heap.Display(A);
        }
    }

}

