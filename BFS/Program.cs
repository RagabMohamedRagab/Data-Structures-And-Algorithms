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
        Queue<Node> MyQueue = new Queue<Node>();
        Node Previous = null;
        #region Insert
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
        #endregion
        #region BFS
        // Dealing With Queue in Tree
        public void BFS()
        {
            Temp = Root;
            MyQueue.Enqueue(Temp);
            while (MyQueue.Count > 0)
            {
                Current = MyQueue.Dequeue();
                Console.Write(Current.key + " ");

                if (Current.Left != null)
                {
                    MyQueue.Enqueue(Current.Left);
                }
                if (Current.Right != null)
                {
                    MyQueue.Enqueue(Current.Right);
                };

            }


        }
        #endregion
        #region VLR
        public void DFS_PreOrder()
        {
            Temp = Root;
            if (Temp == null)
            {
                Console.WriteLine("Your Tree Is Empty..");
            }
            PreOrderHelper(Temp);

        }
        void PreOrderHelper(Node temp)
        {
            if (temp == null)
            {
                return;
            }
            Console.Write(temp.key + " ");
            PreOrderHelper(temp.Left);
            PreOrderHelper(temp.Right);
        }
        #endregion
        #region LVR
        public void DFS_INOrder()
        {
            Temp = Root;
            if (Temp == null)
            {
                Console.WriteLine("Your Tree Is Empty..");
            }
            INOrderHelper(Temp);

        }
        void INOrderHelper(Node temp)
        {
            if (temp == null)
            {
                return;
            }
            INOrderHelper(temp.Left);
            Console.Write(temp.key + " ");
            INOrderHelper(temp.Right);
        }
        #endregion
        #region LRV
        public void DFS_POSTOrder()
        {
            Temp = Root;
            if (Temp == null)
            {
                Console.WriteLine("Your Tree Is Empty..");
            }
            POSTOrderHelper(Temp);

        }
        void POSTOrderHelper(Node temp)
        {
            if (temp == null)
            {
                return;
            }
            POSTOrderHelper(temp.Left);
            POSTOrderHelper(temp.Right);
            Console.Write(temp.key + " ");
        }
        bool IsEmpty()
        {
            return Root == null;
        }
        #endregion
        #region Search
        // Worest Case : O(N)
        // Besr Case :O(log n)
        public void Search(long data)
        {

            if (Root != null)
            {
                Temp = Root;
                SearchHelper(Temp, data);
            }

        }
        void SearchHelper(Node temp, long key)
        {
            if (temp == null)
            {
                Console.WriteLine("Not Found Key....?");
                return;
            }
            else if (temp.key == key)
            {
                Console.WriteLine($"Found key : {temp.key}");
                return;
            }
            else if (temp.key < key)
            {
                SearchHelper(temp.Right, key);
            }
            else if (temp.key >= key)
            {
                SearchHelper(temp.Left, key);
            }
        }


        #endregion
        #region Deletion
       public void Deletion(long key)
        {
            #region Test Case
            // Test Case for Empty Tree
            if (IsEmpty())
                {
                    Console.WriteLine("Tree Is Empty..");
                    return;
                }
            #endregion

            #region Searching For key
            Temp = Root;
                while (Temp != null)
                {
                    if (Temp.key == key)
                    {
                        Current = Temp;
                        Temp=Temp.Right;
                    }
                    else if (Temp.key < key)
                    {
                        Previous = Temp;
                        Temp = Temp.Right;
                    }
                    else
                    {
                        Previous = Temp;
                        Temp = Temp.Left;
                    }
                }
            #endregion
           
            #region Case1
                // IF Right And Left are Null;
            if (Current.Left == null && Current.Right == null)
            {
                if (Previous.Left == Current)
                {
                    Previous.Left = null;
                    Console.WriteLine("Done.");
                }
                else
                {
                    Previous.Right = null;
                    Console.WriteLine("Done.");
                }
            }
            #endregion

            #region Case2
            // If Right is null and Left is not Null or Right Is not Null and Left is Null;
            if ((Current.Right == null && Current.Left != null) || (Current.Right != null && Current.Left == null))
            {
                if (Current.Right != null)
                {
                    if (Previous.Right.key == Current.key)
                    {
                        Previous.Right = Current.Right;
                        Console.WriteLine("Done.");
                    }
                }
                else
                {
                    if(Previous.Left.key == Current.key)
                    {
                        Previous.Left= Current.Left;
                        Console.WriteLine("Done.");
                    }
                }
            }
            #endregion

            #region Case3
            // if Right And Left aren't Null
            if (Current.Right != null && Current.Left != null)
            {
                // Find Minumum Node in Right Sup Tree or Maxumum Node in Left Sup Tree 

                Temp = Current;
                while (Temp!=null) {
                    Previous = Temp;
                    Temp = Temp.Right;
                }
                Current.key = Temp.key;
                if(Previous.Right != null)
                {
                    if (Previous.Right.key == Temp.key)
                    {
                        Previous.Right = null;
                        Console.WriteLine("Done.");
                    }
                }
                else
                {
                    if (Previous.Left.key == Temp.key)
                    {
                        Previous.Left = null;
                        Console.WriteLine("Done.");
                    }
                }
            }
            #endregion

            GC.Collect();

        }

        #endregion
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
            Console.WriteLine("Traversal By using Breadth First :");
            tree.BFS();
            Console.WriteLine("\nTraversal By using Depth First=>Pre Order :");
            tree.DFS_PreOrder();
            Console.WriteLine("\nTraversal By using Depth First=>Post Order :");
            tree.DFS_POSTOrder();
            Console.Write("\nPlZ Enter Search Number :");
            long search_num = Int64.Parse(Console.ReadLine());
            tree.Search(search_num);
            Console.Write("\nDeleting Node in tree :");
            long Delete_num=Int64.Parse(Console.ReadLine());
            tree.Deletion(Delete_num);
            Console.WriteLine("\nTraversal By using Depth First=>In Order :");
            tree.DFS_INOrder();

        }
    }
}


