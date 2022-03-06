/*Problem Solving 
 * =>Write a function that counts the number of times a given int occurs in a Linked List
 * DateTime => 9-11-2020 11:25:56 pm
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Occurence_Number_In_LinkedList
{
    

    // Here I will Create Multiple Of Nodes PLZ Follow Me ....... 
    class Nodes
    {
        // Val Of Node
         public int Data { get; set; }
        public Nodes node; // Pointer Of Another Node
        public Nodes()
        {
            Data = 0;
            node = null;
            
        }
    }
    // I will Create Operations Of Linked List
    class LinkedList
    {
        Nodes Head = null;
        public int count = 0;
        // Create First  Node
        public void  FrontNode(int Val)
        {
            Nodes nodes = new Nodes();
            nodes.Data = Val;
            nodes.node = null;
            Head = nodes;
            count++;
        }
        // Adding 
        public void AddNodes(int Val)
        {
            Nodes nodes = Head;
            while (true)
            {
                if (nodes.node == null)
                {
                    Nodes nodes1 = new Nodes();
                    nodes1.Data = Val;
                    nodes1.node = null;
                    nodes.node = nodes1;
                    count++;
                    break;
                }
                nodes = nodes.node;
            }
        }
        //Algorithms
        public void FindAccurence(int val) {
            Nodes First = Head;
            int Index = 0;
            while (true)
            {
                if (First.Data == val) {
                    Index++;
                }
                if (First.node==null)
                {
                    Console.WriteLine($"{val}=>{Index}");
                    break;
                }
                First = First.node;
            }
        }
        public void Print()
        {
            Nodes p = Head;
            while (p != null)
            {

                Console.WriteLine(p.Data);

                p = p.node;
            }
        }
        // Big O(n)
    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.FrontNode(10);
            Console.Write("Enter Size :");
            int size = int.Parse(Console.ReadLine());
            int val;
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Num-{i+1}:");
                val = int.Parse(Console.ReadLine());
                linkedList.AddNodes(val);
            }
            Console.WriteLine("Print Numbers:");
            linkedList.Print();
            Console.Write("Enter Num:");
            int Num = int.Parse(Console.ReadLine());
            linkedList.FindAccurence(Num);
        }
    }
}
