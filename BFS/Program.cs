// I'm using Recursion for all Traversal of tree
using System;

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
        }
    }
}


