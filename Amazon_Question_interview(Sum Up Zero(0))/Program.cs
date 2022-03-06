using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon_Question_interview_Sum_Up_Zero_0__
{
    // Here we will Create Nodes...
    class Nodes
    {
        public int Data { get; set; } // Data/Value in the node
        public Nodes Next { get; set; } // pointer to others Nodes
        public Nodes() // To inilialze Node
        { 
            Data = 0;
            Next = null;
        }
    }
    public class LinkedList
    {
        Nodes Head = null; // The First Node ,It is very Important To Iterate at All Nodes 
                           // Add in Front in Linked List

        public void AddFromFront(int Val)
        {
            Nodes nodes = new Nodes();
            nodes.Data = Val;
            nodes.Next = null;
            Head = nodes;
        }
        // Adding in back of Node
        public void Addingback(int val)
        {
            Nodes Ptr = Head;
            while (true)
            {
                if (Ptr.Next == null)
                {
                    Nodes nodes = new Nodes();
                    nodes.Data = val;
                    Ptr.Next = nodes;
                    nodes.Next = null;
                    break;
                }
                Ptr = Ptr.Next;
            }
        }
        // Sum up Zero 
        public void SumUpZero()
        {
            Nodes Outer = Head;
            while (Outer != null)
            {
                Nodes Inner = Outer.Next;
                while (Inner != null)
                {
                    if (Outer.Data + Inner.Data == 0)
                    {
                       
                        Del(Outer);
                        Del(Inner);
                    }
                    else
                    {
                        Nodes Lexical = Inner.Next;
                        while (Lexical != null)
                        {
                            if (Outer.Data + Inner.Data + Lexical.Data == 0)
                            {
                                Del(Outer);
                                Del(Inner);
                                Del(Lexical);
                            }
                            Lexical = Lexical.Next;
                        }
                    }
                    break;
                   
                }

                Outer = Outer.Next;
            }
              
        }
        // Searching To Deleting
        void Del(Nodes nodes)
        {
            Nodes Search = Head;
            Nodes Perivous ;
            while (Search != null)
            {
                Perivous = Search;
                if (Search.Data == nodes.Data)
                {
                    Perivous.Next= Search.Next;
                    break;
                }
                
                Search = Search.Next;
            }
        }
      
        // print
        public void Print()
        {
            Nodes Ptr = Head;
            while (true)
            {
                if (Ptr == null)
                {
                    break;
                }
                Console.WriteLine($"Val => {Ptr.Data}");
                Ptr = Ptr.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            int Data ;
            linkedList.AddFromFront(6);
            for (int i = 0; i < 9; i++)
            {
                Console.Write("Enter Val:");
                Data = Int32.Parse(Console.ReadLine());
                linkedList.Addingback(Data);
            }
            linkedList.SumUpZero();
            linkedList.Print();
        }
    }
}

