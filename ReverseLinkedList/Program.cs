using System;

namespace ReverseLinkedList
{

    public class Node
    {
        public int Key { get; set; }
        public Node Next { get; set; }
        public Node(int Key)
        {
            this.Key = Key;
            this.Next = null;
        }
    }
    public class ReverseLinkedList
    {
        public Node Head { get; set; } // This is Head Of LinkedList
        public Node Pervoius { get; set; }
        public Node After { get; set; }

        // Constructor 
        public ReverseLinkedList()
        {
            this.Head = null;
            this.Pervoius = null;
            this.After = null;
        }

        // Add Node In Linked List
        public void Adding(int key)
        {
            Node node = new Node(key);
            if (this.Head == null) // This is first Node In LinkedList...
            {
                node.Next = null;
                Head = node;
                return;
            }
            Node Ptr = this.Head;
            while (true)
            {
                if (Ptr.Next == null)
                {
                    Ptr.Next = node;
                    node.Next = null;
                    return;
                }
                Ptr = Ptr.Next;
            }
        }

        // Print LinkedList 
        public void Print()
        {
            Node ptr = this.Head;
            int i = 1;
            while (ptr!= null)
            { 
                Console.WriteLine($"Item-{i}:{ptr.Key}");
                ptr = ptr.Next;
                i++;
            }
        }
        // Reverse Linked List
        public void Reverse()
        {
            if (this.Head == null)
                return;
            this.Pervoius = Head;
            this.After = this.Pervoius.Next; 
            this.Pervoius.Next = null;
            while (this.After != null)
            {
                this.Head = this.After;
                this.After = this.After.Next;
                this.Head.Next = this.Pervoius;
                this.Pervoius = this.Head;
            }
            this.Head = this.Pervoius; 

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ReverseLinkedList reverse = new ReverseLinkedList();
            Console.Write("Size:");
            int Size = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= Size)
            {
                Console.Write($"Enter Item-{i}:");
                int item = int.Parse(Console.ReadLine());
                reverse.Adding(item);
                i++;
            }
            Console.WriteLine("Print:");
            reverse.Print();
            Console.WriteLine("Reverse LinkedList..");
            reverse.Reverse();
            reverse.Print();
        }
    }
}
