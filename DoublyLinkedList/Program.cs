/*
* Date : 10-2-2022 12:00 AM  
  Here I will be Creating Implementation Of Doubly LinkedList
 */
using System;
namespace DoublyLinkedList
{
    // This is a Node
    #region
    public class Node
    {
        public int Key { get; set; }
        public Node Previous { get; set; }
        public Node Next { get; set; }

        public Node(int key)
        {
            this.Key = key;
            Previous = null;
            Next = null;

        }

    }
    #endregion
    // This is a Doubly LinkedList
    #region
    public class Doubly
    {
        public Node First { get; set; }
        public Node Last { get; set; }

        public Doubly()
        {
            this.Last = null;
            this.First = null;


        }
        bool IsEmpty()
        {
            return this.First == null && this.Last == null;
        }
        // Add Node From Node From First Doubly Linkedlist
        // Complexity Time  :  Big O( 1 + N ) = O(N)
        // Complexity Space :  O(1)
        public void AddNodeFromFirstAndEnd(int key)
        {
            Node newNode = new Node(key);
            if (IsEmpty())
            {
                newNode.Previous = null;
                newNode.Next = null;
                this.Last = newNode;
                this.First = newNode;
                return;
            }
            else
            {
                Node Ptr = this.First;
                while (Ptr.Next != null)
                {
                    Ptr = Ptr.Next;
                }
                newNode.Previous = this.Last;
                newNode.Next = null;
                this.Last.Next = newNode;
                this.Last = newNode;
                return;
            }

        }
        //Insert In N-Th Of Nodes
        // Complexity Time  :  Big O(1+N) = O(N)
        // Complexity Space :  O(1)
        public void NthAddNode(int key, int Pos)
        {
            Node Ptr = this.First;
            int index = 0;
            while (++index != Pos)
            {
                Ptr = Ptr.Next;
            }
            Node newNode = new Node(key);
            newNode.Previous = Ptr.Previous;
            Ptr.Previous.Next = newNode;
            newNode.Next = Ptr;
            Ptr.Previous = newNode;
            return;
        }
        // Del Node from First of Doubly LinkedList
        // Complexity Time  :  Big O(1) = O(1)
        // Complexity Space :  O(1)
        public void DelNodeFromFirst()
        {
            Node Ptr = this.First;
            if (IsEmpty())
                return;
            if (Ptr.Next == null)
                return;
            this.First = Ptr.Next;
            this.First.Previous = null;
            GC.Collect();
        }
        // Del Node From Last Of Doubly LinkedList
        // Complexity Time  :  Big O(1) = O(1)
        // Complexity Space :  O(1)
        public void DelNodeFromLast()
        {
            Node Ptr = this.Last;
            if (IsEmpty())
                return;
            if (this.Last.Previous == null)
                return;
            this.Last = Ptr.Previous;
            this.Last.Next = null;
            GC.Collect();
        }
        // Del From Specify Position In Doubly LinkedList
        // Complexity Time  :  Big O( 1 + N ) = O(N)
        // Complexity Space :  O(1)
        public void DelAt(int Pos)
        {
            Node Ptr = this.First;
            int Index = 0;
            while (++Index != Pos)
            {
                Ptr = Ptr.Next;
            }
            Ptr.Previous.Next = Ptr.Next;
            Ptr.Next.Previous = Ptr.Previous;
            GC.Collect();
        }
        // Complexity Time  :  Big O(1 + N + N) = O(1 + 2N)=O(N)
        // Complexity Space :  O(1)
        public void Print()
        {
            Node Ptr = this.First;
            while (Ptr != null)
            {
                Console.WriteLine($"Item-:{Ptr.Key}");
                Ptr = Ptr.Next;
            }
            Console.WriteLine("Print Reverse Of Doubly Linked List:");
            Node Ptr2 = this.Last;
            while (Ptr2 != null)
            {
                Console.WriteLine($"Item-:{Ptr2.Key}");
                Ptr2 = Ptr2.Previous;
            }
        }
    }
    #endregion
    // This is a Void Main
    #region
    class Program
    {
        static void Main(string[] args)
        {
            Doubly doubly = new Doubly();
            Console.Write("Size Of Doubly Linked:");
            int size = Int16.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.Write("Item-:");
                int item = int.Parse(Console.ReadLine());
                doubly.AddNodeFromFirstAndEnd(item);
            }
            Console.WriteLine("Adding In Specify Place :");
            // Insert In Nth Node
            Console.Write("Enter Position:");
            int Pos = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Val:");
            int Item = Int32.Parse(Console.ReadLine());
            doubly.NthAddNode(Item, Pos);
            doubly.DelNodeFromFirst();
            doubly.DelNodeFromLast();
            Console.Write("Enter Position tO Del:");
            int Position = int.Parse(Console.ReadLine());
            doubly.DelAt(Position);
            Console.WriteLine("After Creating CRUD Operation At Doubly LinkedList : ");
            doubly.Print();
        }
    }
    #endregion
}