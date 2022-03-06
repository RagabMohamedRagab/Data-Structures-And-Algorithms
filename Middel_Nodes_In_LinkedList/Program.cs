/*Problem Solving :
 * =>Find the middle of a given linked list
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middel_Nodes_In_LinkedList
{
    // Here, I will Create  Node to specify Name of it and  Space. 
    /*
     *  [Head/List]->Node->Node->Node->Node->Node->null
     *  Node[val,Next] 
     */
    class ListOfNodes
    {
        public int val;
        public ListOfNodes Next;
       
        // Here I would Like To initial Two Fields
        public ListOfNodes()
        {
            val = 0;
            Next = null;
            
        }
    }
    class LinkedList
    {
        ListOfNodes Head = null;
       public int count = 0;
        // First Add Node_Front 
        public void Node_Front(int Val)
        {
            ListOfNodes nodes = new ListOfNodes();
            nodes.val = Val;
            nodes.Next = null;
            Head = nodes;
            count++;
        }
        // Big o Notation O(1)=1
        // Add Last_Node
        public void Node_Last(int Val)
        {
            ListOfNodes nodes = Head;
            while (true)
            {
                if (nodes.Next == null)
                {
                    ListOfNodes node = new ListOfNodes();
                    node.val = Val;
                    node.Next = null;
                    nodes.Next = node;
                    count++;
                    break;
                }
                nodes = nodes.Next;
            }
        }
        // Big o Notation Big O(n)
        // Get Middle Node 
        public void Middle()
        {
            int Lenght = count /2;
            if (Lenght == 0)
            {
                MiddleEven(Head, Lenght);
            }
            else
            {
                MiddleOdd(Head, Lenght);
            }
        }
        // Big O(1)
        public void MiddleEven(ListOfNodes list,int Lenght)
        {
            ListOfNodes list1 = list;
            int index = 0;
            while (Lenght==index++)
            {
                list1 = list1.Next; 
                Console.Write((list1.Next).val);
            }
        }
        // Big O(n)
        public void MiddleOdd(ListOfNodes list, int Lenght)
        {
            ListOfNodes list1 = list;
            int index = 0;
            while (true)
            {
                if (Lenght == index++)
                {

                    Console.Write(list1.val);
                    break;
                }
                list1 = list1.Next; 

            }
        }
        // Big O(n)
        // Print Nodes
        public void Print()
        {
            ListOfNodes p = Head;
            while (p != null)
            {

                Console.WriteLine(p.val);

                p = p.Next;
            }
        }
        // Big O(n)
    }


    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Node_Front(10);
            list.Node_Last(20);
            list.Node_Last(30);
            list.Node_Last(40);
            list.Node_Last(50);
            list.Node_Last(60);
            list.Node_Last(70);
            list.Print();
            Console.Write("The Middle Of LinkedList Is :");
            list.Middle();
            Console.WriteLine();
        }
    }
}
