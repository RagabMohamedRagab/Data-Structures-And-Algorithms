using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleQueue
{
    class Queue
    {
        int Front;
        int Rear;
        int[] Arr = new int[5];
        public Queue()
        {
            Front = 0;
            Rear = -1;
        }
        // If Queue Is Empty
        bool IsEmpty(int front)
        {
            return (front == Rear + 1);
        }
        // Circular Queue
        bool IsFullCircular(int front, int rear)
        {
            return (Front != 0 && Rear == Arr.Length - 1);
        }
        bool GetFully(int Front, int Rear)
        {
            return (Front == 0 && Rear == Arr.Length - 1);
        }
        //EnQueue Method
        public void EnQueue(int Element)
        {
            if (GetFully(Front, Rear))
            {
                Console.WriteLine("Queue Is Fully");
            }
            else if (IsFullCircular(Front, Rear))
            {

                Rear = (Rear + 1) % Arr.Length;
                Arr[Rear++] = Element;
            }
            else
            {
                Arr[++Rear] = Element;
            }
        }
        // DeQueue Method
        public void DeQueue()
        {
            if (IsEmpty(Front))
            {
                Console.WriteLine("Queue Is Empty????>>>");
            }
            else if (Front == Arr.Length)
            {
                Front = 0;
            }
            else
            {
                Front++;
            }
        }
        // Getting Rear of Queue 
        public int GetRear()
        {
            return Arr[Rear];
        }
        // Getting Front of Queue
        public int GeTFront()
        {
            return Arr[Front];
        }
        // Print All Item Queue
        public void Display()
        {
            if (Front > Rear)
            {
                for(int i = 0; i < Rear; i++)
                {
                    Console.WriteLine(Arr[i]);
                }
                for (int i = Front; i < Arr.Length; i++)
                {
                    Console.WriteLine(Arr[i]);
                }
            }
            else
            {
                for (int i = Front; i <= Rear; i++)
                {
                    Console.WriteLine(Arr[i]);
                }
            }
        } 
    }


    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.EnQueue(10);
            queue.EnQueue(20);
            queue.EnQueue(30);
            queue.EnQueue(40);
            queue.EnQueue(50);
            queue.DeQueue();
            queue.DeQueue();
            queue.EnQueue(10);
            queue.Display();
        }
    }
}

