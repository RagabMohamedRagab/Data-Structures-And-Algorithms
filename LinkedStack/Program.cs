// Implement Stack by using LinkedList 
// LinkedStack

using System;

namespace LinkedStack
{
    // This is initialzation of LinkedList
    public class Node
    {
        // Data Of Node
        public int Data { get; set; }
        // Address of Pointer
        public Node Next { get; set; }
        // Parameter Construcor. initial Values.
        public Node(int key)
        {
            this.Data = key;
            this.Next = null;

        }
    }
    public class LinkedStack
    {
        Node Top;
        public LinkedStack()
        {
            this.Top = null;
        }
        // Test If LinkedStack Empty
        // O(1)
         bool IsEmpty()
        {
            return this.Top == null;
        }

        // Adding Value to LinkedStack
        // O(1)
        public void Push(int key)
        {
            Node node = new Node(key);
            if (IsEmpty())
            {
                this.Top = node;
                this.Top.Next = null;
                return;
            }
            Node Pervious = this.Top;
            this.Top = node;
            this.Top.Next = Pervious;
        }
        // O(1)
        public void Pop()
        {
            if (IsEmpty())
            {
                Console.Write("LinkedStack is Empty..");
                return;
            }
            this.Top = this.Top.Next;
            GC.Collect();
        }
        // To Get Top 
        // O(1)
        public void Peek()
        {
            if (!IsEmpty())
            {
                Console.WriteLine($"Top-Item-:{this.Top.Data}");
            }
        }
        // Print
        // O(N)
        public void Print()
        {

            while (true)
            {
                if (!IsEmpty())
                {
                    Console.WriteLine($"Item-:{this.Top.Data}");
                    this.Top = this.Top.Next;
                }
                else
                {
                    return;
                }
                
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedStack stack = new LinkedStack();
            Console.Write("Enter size:");
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Item-:");
                int item = int.Parse(Console.ReadLine());
                stack.Push(item);
            }
            stack.Peek();
            Console.Write("Del:");
            int Del = int.Parse(Console.ReadLine());
            for (int i = 0; i < Del; i++)
            {
                stack.Pop();
            }
            stack.Print();

        }
    }
}
