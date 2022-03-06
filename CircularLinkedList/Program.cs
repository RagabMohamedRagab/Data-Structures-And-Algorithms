// I will Implement Circular Single Linked List

using System;
using System.Collections.Generic;

namespace CircularLinkedList
{
    // This is A Node
    #region
    public class Node
    {
        public int Key { get; set; }
        public Node Next { get; set; }
        public Node(int key)
        {
            this.Key = key;
            Next = null;
        }
    }
    #endregion
    // This is Circular Linked List
    #region
    public class CirLinkedList
    {
        // Properties
        #region
        public Node Head { get; set; } // First
        public Node Tail { get; set; } // Last

        public CirLinkedList()
        {
            this.Head = null;
            this.Tail = null;
        }
        #endregion
        // Methods
        #region
        //ISEmpty
        bool ISEmpty()
        {
            return this.Head == null && this.Tail == null;
        }
        // Complexity Time  :  Big O( 1 + N ) = O(N)
        // Complexity Space :  O(1)
        public void AddNode(int key)
        {
            Node newNode = new Node(key);
            if (ISEmpty())
            {
                Head = newNode; // refer into Head
                newNode.Next = Head;
                Tail = newNode; // refer into Tail
                return;
            }
            Tail.Next = newNode;
            Tail = newNode;
            newNode.Next = Head;
            return;
        }
        // Search Of Position
        // Complexity Time  = O( 1 + N ) = O(N)
        // Complexity Space = O(1)
        public List<Node> GetPosition(int Pos)
        {
            Node Ptr = this.Head;
            Node Previous = null;
            int Index = 0;
            while (++Index != Pos)
            {
                Previous = Ptr;
                Ptr = Ptr.Next;
            }
            return new List<Node> { Previous, Ptr };
        }
        // Insert In N-TH Position 
        // Complexity Time  = O(1) = O(1)
        // Complexity Space = O(1)
        public void NthInsertNode(int pos, int Key)
        {
            var refer = GetPosition(pos); 
            Node newNode = new Node(Key);
            newNode.Next = refer[1];
            refer[0].Next = newNode;

        }
        // Complexity Time  = O(1) = O(1)
        // Complexity Space = O(1)
        public void DeleteNode(int Pos)
        {
            var refer = GetPosition(Pos);
            refer[0].Next =refer[1].Next;
            GC.Collect();
        }

        #endregion
        // Print
        #region
        // Print Circular Linked List
        // Complexity Time  :  Big O( 1 + N ) = O(N)
        // Complexity Space :  O(1)
        public void Print()
        {
            Node Ptr = Head;
            while (Ptr.Next != Head)
            {
                Console.WriteLine($"Item- :{Ptr.Key}");
                Ptr = Ptr.Next;
            }
            Console.WriteLine($"Item- :{Ptr.Key}");
        }

        #endregion



    }
    #endregion
    // Void Main()
    #region
    public class Program
    {
        static void Main()
        {
            CirLinkedList cirLinked = new CirLinkedList();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter: ");
                int item = int.Parse(Console.ReadLine());
                cirLinked.AddNode(item);
            }
            Console.Write("Enter Position :");
            int Pos = Int16.Parse(Console.ReadLine());
            Console.Write("Enter Item-: ");
            int Item = Int16.Parse(Console.ReadLine());
            cirLinked.NthInsertNode(Pos, Item);
            Console.WriteLine("Enter Position:");
            int Pos2 = int.Parse(Console.ReadLine());
            cirLinked.DeleteNode(Pos2);
            Console.WriteLine("Print Items:");
            cirLinked.Print();
        }
    }
    #endregion
}




