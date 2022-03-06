// I will Implement Queue By used LinkedList
using System;
using System.Runtime.ConstrainedExecution;

namespace LinkedQueue
{   
    
    public class Node
    {
        // Data Of Node
        public int key { get; set; }
        // To refer at Another Node
        public Node Nodes { get; set; }
        // Constructor 
        public Node(int key)
        {
            this.key = key;
            Nodes = null;
        }
    }
    public class LinkedListQueue
    {
        Node Rear, Front;
        // Rear is used To EnQueue 
        // Front is Used To DeQueue
        public LinkedListQueue()
        {
            Rear = Front = null;
        }
        public void EnQueue(int Key)
        {
          
         
                Node node = new Node(Key);
                if (this.Rear == null)
                {
                    this.Front = this.Rear = node;
                    return;
                }
                else if (this.Rear.Nodes == null)
                {
                    this.Rear.Nodes = node;
                    this.Rear = node;
                    return;
                }
                
        
        }

        // DeQueue 
        public void DeQueue()
        {
            if (this.Front.Nodes == null)
            {
                Console.WriteLine("LinkedQueue Is Empty.");
                return;
            }
            else
            {
                this.Front = this.Front.Nodes;
                GC.Collect();
                return;
            }
        }

       public void Print()
        {
            if (this.Front == this.Rear)
                Console.WriteLine("LinkedQueu is Empty");

            while (true)
            {
                if (this.Front == null)
                {
                    return;
                }
                Console.WriteLine($"Item-:{this.Front.key}\t");
                this.Front = this.Front.Nodes;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueue queue = new LinkedListQueue();
            Console.Write("Enter Size Of Elemet:");
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Item-:");
                int item = Convert.ToInt32(Console.ReadLine());
                queue.EnQueue(item);

            }
            Console.Write("Delete Number:");
            int del = int.Parse(Console.ReadLine());
            for (int i = 0; i < del; i++)
            {
                queue.DeQueue();
            }
            queue.Print();
        }
    }
}
