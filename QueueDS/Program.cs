/* 1- Queue Data Structure.
 *   Queue In Data Structues Is Stander on First in First Out(FIFO)
 *   It's has Two Pointers.
 * 2- Operation Of Queue Data Structures
 *    - EnQueue(int Items)
 *    - DeQueue()
 *    - IsEmpty()
 *    - GetFront()
 *  
 *  3- Complexity Time=>Bigo Notaion belongs to T(1) 
 *  
 *  
 *  
 */
using System;
using System.Collections.Generic;

namespace QueueDS
{

   public class Queue
    {
        // Front-Head Of Queue 
        int Front;
        // Rear-Tail Of Queue
        int Rear;
        const int size = 10;
        int[] QueArr = new int[size];
        // Her We Must Inilialize Front And  Rear 
        public Queue()
        {
            Front = -1;
            Rear = 0;
        }
        // EnQueue Items In Queue Ds
        public void Enqueue(int item)
        {
            if (ISFull())
                QueArr[Rear++] = item;
            else
                Console.WriteLine("Queue Is Full");
        }
        // Test If Full
        bool ISFull()
        {
            return Rear != size;
        }
        // Dequeue Items From Queue Ds
        public void DeQueue()
        {
            if (!IsEmpty())
                Front++;
            else
                Console.WriteLine("Queue Is Empty");

        }
        // Test If Empty
        bool IsEmpty()
        {
            return Rear == Front || Rear == Front + 1;
        }
        // Print Item Of Queue
        public void Print()
        {
            for (int i = Front+1; i < Rear; i++)
                Console.WriteLine($"item-{i}:{QueArr[i]}");

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.DeQueue();
            queue.Enqueue(40);
            queue.Print();
        }
    }
}


