// I'm using Recursion for all Traversal of tree
using System;
using System.Collections;
using System.Collections.Generic;

namespace BFS {
    public class Node {
        public long key;
        public Node Left;
        public Node Right;
        public Node(long key)
        {
            this.key = key;
            Left = null;
            Right = null;
        }
    }
    public class Tree {
        Node Root = null;
        Node Temp = null;
        Node Current = null;
        Queue<Node> Queu=new Queue<Node>();

        Node Previous = null;
        public void AddNode(long key)
        {
            if (Root == null)
            {
                Node node = new Node(key);
                Root = node;
                Temp = Root;
                return;
            }
            Temp = Root;
            AddRecursion(Temp, key);
        }
        void AddRecursion(Node temp, long data)
        {
            if (temp == null)
            {
                Node node = new Node(data);
                if (Previous.key < data)
                {
                    Previous.Right = node;
                }
                else
                {
                    Previous.Left = node;
                }
                return;
            }
            else if (temp.key < data)
            {
                Previous = temp;
                AddRecursion(temp.Right, data);
            }
            else
            {
                Previous = temp;
                AddRecursion(temp.Left, data);
            }
        }
      
        // Dealing With Queue in Tree
        public void BFS()
        {
            Temp = Root;
            if (Temp != null)
            {
                Queu.Enqueue(Temp);
              
                while (Queu.Count != 0)
                {
                    Current = Queu.Peek();
                    Queu.Dequeue();
                    Console.Write(Current.key + " ");
                    if (Current.Left != null)
                    {
                        Queu.Enqueue(Temp.Left);
                    }
                    else
                    {
                        Queu.Enqueue(Temp.Right);
                    }
                    if (Current.Right != null)
                    {
                        Queu.Enqueue(Temp.Right);
                    }
                    else
                    {
                        Queu.Enqueue(Temp.Left);
                    }
                }
                
            }

        }

    }
    public class Program {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.AddNode(3);
            tree.AddNode(4);
            tree.AddNode(2);
            tree.AddNode(5);
            tree.AddNode(1);
            tree.BFS();
        }
    }
}


