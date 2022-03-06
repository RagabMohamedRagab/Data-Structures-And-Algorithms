/*
Stack DataStructures
     It Is Temprory Momery
     Some Of Operations In The Stack
         1-Push()
         2-Pop()
         3-Print()
         4-Top Start Top=-1
         5-IsFull When Top==size-1
         6-IsEmpty When Top==-1
 */
using System;
namespace Stack
{
   public class Stack
    {
        public int Top { get; set; }
        public int sizeOFArr { get; set; }
        public int[]Arr;
        //(1)
        public Stack(int Top, int sizeOFArr)
        {
            this.Top = Top;
            this.sizeOFArr = sizeOFArr;
            Arr = new int[sizeOFArr];
        }
        // Method  Adding Item In Stack
        //O(1)
        public void Push(int Number)
        {
            if (ISFULL())
                Console.WriteLine("Stack Is Full....");
            else
               Arr[++Top] = Number; // Increase And Adding
        }
        // Method  Pop Item In Stack
       //O(1)
        public void Pop()
        {
            if(!ISEMPLTY())
                Top--;
            else
                Console.WriteLine("Stack Is Empty>>>>");

        }
        // Test Is Full Or Not
        //O(1)
        bool ISFULL()
        {
            return this.Top == sizeOFArr - 1;
        }
        // Test Is Empty Or Not
        // O(1)
        bool ISEMPLTY()
        {
            return this.Top == -1;
        }
        // Method To Print O(N)
        public void Print()
        {
            for (int i = Top; i >= 0; i--)
                Console.WriteLine("Items-:" + Arr[i]);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(-1, 50);
            Console.Write("Enter Size:");
            int size = int.Parse(Console.ReadLine()); // O(1)
            // O(N)
            for (int i = 0; i < size;i++)
            {
                Console.Write("Item-:");
                int item = int.Parse(Console.ReadLine());
                stack.Push(item);
            }
            int Del = int.Parse(Console.ReadLine());
            // O(N)
            for (int i = 0; i < Del; i++)
            {
                stack.Pop();

            }
            stack.Print();
        }
    }
}
