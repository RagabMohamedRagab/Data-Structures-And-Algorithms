using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Nodes
    {
        public int data;
        public Nodes nodes;
        public static int count = 0;
        public Nodes()
        {
            nodes = null;
            count++;
        }
    }
    class LinkedListNode
    {
        private Nodes Head;
        public void AddNodeFront(int Val)
        {
            Nodes nodes = new Nodes();
            nodes.data = Val;
            nodes.nodes = null;
            Head = nodes;
        }
        public void AddNodeBack(int Val)
        {
            Nodes Running = Head;
            while (true)
            {
                if (Running.nodes == null)
                {
                    Nodes nodes = new Nodes();
                    nodes.nodes = null;
                    nodes.data = Val;
                    Running.nodes = nodes;
                    break;
                }

                Running = Running.nodes;
            }
        }
        public void AddFromMiddle(int ValSearch, int Val)
        {
            Nodes Running = Head;
            Nodes Strore_Nodes = null;
            while (true)
            {
                if (Running.data == ValSearch)
                {
                    Nodes nodes = new Nodes();
                    nodes.data = Val;
                    nodes.nodes = Strore_Nodes.nodes;
                    Strore_Nodes.nodes = nodes;
                    break;
                }
                Strore_Nodes = Running;
                Running = Running.nodes;
            }
        }
        public void DelFromFront(int SearchVal)
        {
            Nodes list = Head;
            Nodes LastVal = null;
            int Lenght = 0;
            while (true)
            {
                if (list.data == SearchVal)
                {
                    LastVal.nodes = list.nodes;
                }
                if (Nodes.count == Lenght+1)
                {
                    break;
                }
                Lenght++;
                LastVal = list;
                list = list.nodes;

            }
        }


        public void Print()
        {
            Nodes Running = Head;
            while (Running != null)
            {
                Console.WriteLine(Running.data + "\n");
                Running = Running.nodes;
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            LinkedListNode linkedList = new LinkedListNode();
            linkedList.AddNodeFront(1);
            linkedList.AddNodeBack(2);
            linkedList.AddNodeBack(3);
            linkedList.AddNodeBack(4);
            linkedList.AddFromMiddle(2, 20);
            linkedList.AddNodeBack(5);
            linkedList.AddFromMiddle(5, 20);
            linkedList.DelFromFront(20);
            linkedList.Print();
        }
    }
}


