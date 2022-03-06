///  How To Merge Between Two Collections Arrays-List-Collection-ArrayList  [Array]
    
//        While(i<Size1&&j<Size2)
//         { 
//            if(Arr1[i]<Arr[j]){
//              Arr[k]=Arr[i];
//              i++;
//              }else{
//                Arr[K]=Arr[j];
//                j++;
//               }
//               K++;
//           }
           
//           while(i<Size1){
//             Arr[k]=Arr[i];
//             K++;
//             i++;
//            }
//            while(j<Size2){
//              Arr[k]=Arr[j];
//              K++;
//              j++;
//              }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    class Merge
    {
        public void MergeSort(int []Arr,int L,int R)
        {
            if (L < R)
            {
                int Mid = L + (R - L) / 2;
                MergeSort(Arr,L, Mid);
                MergeSort(Arr,Mid+1, R);
                MargeExe(Arr, L, Mid, R);
            }
        }
        public void MargeExe(int []Arr,int L , int Mid,int R)
        {
            int n1 = L + Mid + 1;
            int n2 = Mid + R;
            int[] Arr1 = new int[n1];
            int[] Arr2 = new int[n2];
            for (int i = 0; i < n1; i++)
            {
                Arr1[i] = Arr[i+L];
            }
            for (int j = 0; j < n2; j++)
            {
                Arr2[j] = Arr[j + Mid + R];
            }





        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[] { 4, 3, 5, 1, 2 };
            Merge merge = new Merge();
            merge.MergeSort(Arr, Arr.GetLowerBound(0), Arr.GetUpperBound(0));
        }
    }
}
