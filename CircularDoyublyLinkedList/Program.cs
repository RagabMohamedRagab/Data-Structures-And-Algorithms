// Implement Circular Doubly Linked List
//DateTime : 6-3-2022
using System;

namespace CircularDoublyLinkedList
{
    // Create A Node
    #region
    public class Node
    {
        public int key { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }
        public Node(int key)
        {
            this.key = key;
            this.Previous = null;
            this.Next = null;
        }
    }
    #endregion
    // CRUD OPeration for Node
    #region
    public class CirDoublyLinedList
    {
        // Properties
        #region
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public CirDoublyLinedList()
        {
            this.Head = null;
            this.Tail = null;
        }
        #endregion 
        // Methods
        #region
       
        // ISEmpty
        bool ISEmpty()
        {
            return this.Head == null && this.Tail == null;
        }
        // Get Node
        // Complexity Time  :  Big O( 1 + N ) = O(N)
        // Complexity Space :  O(1)
        Node GetNode(int pos)
        {
            Node Ptr = this.Head;
            int Index = 0;
            while (++Index!=pos)
            {
                Ptr = Ptr.Next;
            }
            return Ptr;
        }
        // Insert A Node
        // Complexity Time  :  Big O( 1 + N ) = O(N)
        // Complexity Space :  O(1)
        public void Push(int key)
        {
            Node newNode = new Node(key);
            if (ISEmpty())
            {
                newNode.Next = newNode;
                newNode.Previous = newNode;
                this.Head = newNode; 
                this.Tail = newNode;
                return;
            }
            Node Ptr = this.Head;
            while (Ptr.Next!=Head)
            {
                Ptr = Ptr.Next;
            }
            this.Tail.Next = newNode;
            this.Tail = newNode;
            this.Tail.Previous = Ptr;
            this.Tail.Next = Head;
            this.Head.Previous = newNode;

        }
        // Insert in Nth in Circular Doubly Linked
        // Complexity Time  :  Big O( 1 + N ) = O(N)
        // Complexity Space :  O(1)
        public void NthInsertNode(int key,int pos)
        {
            Node Ptr = this.Head;
            int Index = 0;
            while (++Index!=pos)
            {
                Ptr = Ptr.Next;
            }
            Node newNode = new Node(key);
            Ptr.Previous.Next = newNode;
            newNode.Previous = Ptr.Previous;
            Ptr.Previous = newNode;
            newNode.Next = Ptr;
        }
        // Delete Node From Any Position
        // Complexity Time  :  Big O( 1 ) = O(1)
        // Complexity Space :  O(1)
        public void NthDelNode(int pos)
        {
            var delNode = GetNode(pos);
            if (delNode.Next == null)
            {
                delNode.Previous.Next = Head;
                GC.Collect();
                return;
            }
            else if(delNode.Previous==this.Tail)
            {
                this.Head = this.Head.Next;
                this.Head.Previous = Tail;
                GC.Collect();
                return;
            }
            delNode.Next.Previous = delNode.Previous;
            delNode.Previous.Next = delNode.Next;
            GC.Collect();
        }
        #endregion
        // Print 
        #region
        // Complexity Time  :  Big O( 1 + N ) = O(N)
        // Complexity Space :  O(1)
        public void Print()
        {
            Node Ptr = this.Head;
            while (Ptr.Next != Head)
            {
                Console.WriteLine($"Item-:{Ptr.key}");
                Ptr = Ptr.Next;
            }
            Console.WriteLine($"Item-:{Ptr.key}");
        }

        #endregion

    }
    #endregion
    // Void Main
    #region
    class Program
    {
        static void Main(string[] args)
        {
            CirDoublyLinedList cirDoubly = new CirDoublyLinedList();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter-:");
                int Item = int.Parse(Console.ReadLine());
                cirDoubly.Push(Item);
            }
            Console.Write("Position:");
            int pos = int.Parse(Console.ReadLine());
            Console.Write("Enter Value:");
            int val = int.Parse(Console.ReadLine());
            cirDoubly.NthInsertNode(val, pos);
            Console.WriteLine("before Adding A New Node");
            cirDoubly.Print();
            cirDoubly.NthDelNode(pos);
            Console.WriteLine("After Adding A New Node");
            cirDoubly.Print();
        }
    }
    #endregion
}
