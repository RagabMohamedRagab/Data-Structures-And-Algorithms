using System;

namespace MergeLinkedList
{
    public class Node
    {
        public int key { get; set; }
        public Node Next { get; set; }
        public Node(int Key)
        {
            this.key = key;
            this.Next = null;
        }
    }
    public class MergeTwoLinkedList
    {
        public Node Head = null;
     static  Node LinkedListMerge = null;
        // To Add Item
        // O(N)
        public void Add(int key)
        {
            Node node = new Node(key);
            if (Head == null)
            {
                node.Next = null;
                Head = node;
                return;
            }
            // If We Iterat at Collection We Must ReAssignt into Another Variable from The Same DataType
            Node Ptr = Head;
            while (true)
            {
                if (Ptr == null)
                {
                    node.Next = null;
                    Ptr.Next = node;
                    return;
                }
                Ptr = Ptr.Next;
            }
        }
        // Insert A new Linked lIST 
        // O(N)
        public void AddNodd(int key)
        {
            Node node = new Node(key);
            if (LinkedListMerge == null)
            {
                node.Next = null;
                LinkedListMerge = node;
                return;
            }

            Node Ptr = LinkedListMerge;
            while (true)
            {
                if (Ptr == null)
                {
                    node.Next = null;
                    Ptr.Next = node;
                    return;
                }
                Ptr = Ptr.Next;
            }
        }
        // Merge Between Two LinkedList
        // O(N+N+N)=(3N)=O(N)
        public Node Mege(Node First, Node Second)
        {
            Node P1 = First, P2 = Second;
            if (P1 == null && P2 == null)
                return null;
            while (P1 != null && P2 != null)
            {
                if (P1.key < P2.key)
                {
                    this.AddNodd(P1.key);
                    P1 = P1.Next;
                }
                else
                {
                    this.AddNodd(P2.key);
                    P2 = P2.Next;
                }
            }
            while (P1 != null)
            {

                this.AddNodd(P1.key);
                P1 = P1.Next;
            }
            while (P2 != null)
            {

                this.AddNodd(P2.key);
                P2 = P2.Next;
            }




            return LinkedListMerge;




        }
        // Complexity Time O(N)
       public static void Print()
        {
            Node Ptr = LinkedListMerge;
            while (Ptr != null)
            {
                Console.Write($"Item-:{Ptr.key}");
                Ptr = Ptr.Next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            MergeTwoLinkedList First = new MergeTwoLinkedList();
            Console.Write("Size:");
            int Size = int.Parse(Console.ReadLine());
            for (int i = 0; i < Size; i++)
            {
                Console.Write("Enter Item:");
                int Item = int.Parse(Console.ReadLine());
                First.Add(Item);
            }
            MergeTwoLinkedList Second = new MergeTwoLinkedList();
            Console.Write("Size:");
            int Size2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < Size2; i++)
            {
                Console.Write("Enter Item:");
                int Item = int.Parse(Console.ReadLine());
                First.Add(Item);
            }
            MergeTwoLinkedList.Print();
        }
    }
}














