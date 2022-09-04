// I'm using Recursion for all Traversal of tree
using System;
using System.Collections;
using System.Collections.Generic;

namespace BFS {

    public class Node {
        public long key;
        public Node Left;
        public Node Right;
        public static long Count = 0;
        public Node(long key)
        {
            this.key = key;
            Left = null;
            Right = null;
            Count++;
        }
    }
    public class Tree {
        #region Properties
        Node Root = null;
        Node Root2 = null;
        Node Temp = null;
        Node Temp2 = null;
        Node Current = null;
        Node Current2 = null;
        Queue<Node> MyQueue = new Queue<Node>();
        Queue<Node> MyQueue2 = new Queue<Node>();
        public ArrayList arr1 = new ArrayList();
        Node Previous = null;
        Node Previous2 = null;
        #endregion
        #region Insert First
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
        #endregion #region Insert

        #region Insert Doth
        public void AddDothNode(long key)
        {
            if (Root2 == null)
            {
                Node node = new Node(key);
                Root2 = node;
                Temp2 = Root2;
                return;
            }
            Temp2 = Root2;
            AddDothRecursion(Temp2, key);
        }
        void AddDothRecursion(Node temp, long data)
        {
            if (temp == null)
            {
                Node node = new Node(data);
                if (Previous2.key < data)
                {
                    Previous2.Right = node;
                }
                else
                {
                    Previous2.Left = node;
                }
                return;
            }
            else if (temp.key < data)
            {
                Previous2 = temp;
                AddDothRecursion(temp.Right, data);
            }
            else
            {
                Previous2 = temp;
                AddDothRecursion(temp.Left, data);
            }
        }
        #endregion

        #region BFS1
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

        #region BFS2
        // Dealing With Queue in Tree
        public void BFSDoth()
        {
            Temp2 = Root2;
            MyQueue2.Enqueue(Temp2);
            while (MyQueue2.Count > 0)
            {
                Current2 = MyQueue2.Dequeue();
                Console.Write(Current2.key + " ");

                if (Current2.Left != null)
                {
                    MyQueue2.Enqueue(Current2.Left);
                }
                if (Current2.Right != null)
                {
                    MyQueue2.Enqueue(Current2.Right);
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
                    break;
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
                    return;
                }
                else
                {
                    Previous.Right = null;
                    Console.WriteLine("Done.");
                    return;
                }
            }
            #endregion

            #region Case2
            // If Right is null and Left is not Null or Right Is not Null and Left is Null;
            if (Current.Left == null && Current.Right != null)
            {
                if (Previous.Right != null)
                {
                    if (Previous.Right.key == Current.key)
                    {
                        Previous.Right = Current.Right;
                        GC.Collect();
                        return;
                    }

                }
                if (Previous.Left != null)
                {
                    if (Previous.Left.key == Current.key)
                    {
                        Previous.Left = Current.Right;
                        GC.Collect();
                        return;
                    }
                }

            }
            if (Current.Left != null && Current.Right == null)
            {
                if (Previous.Right != null)
                {
                    if (Previous.Right.key == Current.key)
                    {
                        Previous.Right = Current.Left;
                        GC.Collect();
                        return;
                    }

                }
                if (Previous.Left != null)
                {
                    if (Previous.Left.key == Current.key)
                    {

                        Previous.Left = Current.Left;
                        GC.Collect();
                        return;
                    }
                }

            }

            #endregion
            // Here Error in this case3
            #region Case3
            // if Right And Left aren't Null
            if (Current.Right != null && Current.Left != null)
            {
                // Find Minumum Node in Right Sup Tree or Maxumum Node in Left Sup Tree 
                Node PreR = null;
                if (Previous.Left.key == Current.key)
                {
                    while (Temp != null)
                    {
                        PreR = Temp;
                        Temp = Temp.Right;
                    }
                }

                Node PreL = null;
                if (Previous.Right.key == Current.key)
                {
                    while (Temp != null)
                    {
                        PreL = Temp;
                        Temp = Temp.Left;
                 
                    }
                }

                if (PreL.key == 0)
                {
                    Current.key = PreR.key;
                }
                else
                {
                    Current.key = PreL.key;
                }
            }
        }
        #endregion


        #endregion


        #region Problem Solving 
        #endregion

        #region Check if two binary trees are identical or not
        ///****** Notes*******///
        // Root1 and Temp 1 Are tree1
        // Root2 and Temp 2 Are tree1
        ///*****Notes********///
        bool IsEqual = false;
        public void ProblemI()
        {
            if (Root == null && Root2 == null)
            {
                Console.WriteLine("Trees are Empty");
            }
            Temp = Root;
            Temp2 = Root2;
            ProblemIHelper(Temp, Temp2);
            if (IsEqual)
            {
                Console.WriteLine("They are Identical");
            }
            else
            {
                Console.WriteLine("They are not Identical");
            }
        }
        void ProblemIHelper(Node temp1, Node temp2)
        {
            try
            {
                if (temp1 == null && temp2 == null)
                {
                    IsEqual = true;
                    return;
                }
                else if (temp1.key == temp2.key)
                {
                    ProblemIHelper(temp1.Left, temp2.Left);
                    ProblemIHelper(temp1.Right, temp2.Right);
                }
                else
                {
                    IsEqual = false;
                }

            }
            catch (Exception)
            {
                IsEqual = false;
                return;
            }

        }
        #endregion

        #region Print bottom view of a binary tree
       

        public void PrintLeavies()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Tree Is Empty..");
            }
            Temp = Root;
            PrintLeaviesHelper(Temp);
        }
        void PrintLeaviesHelper(Node temp)
        {
            if (temp.Left == null && temp.Right == null)
            {
                Console.Write(temp.key + " ");
                return;
            }
            else if (temp.Left == null && temp.Right != null)
            {
                PrintLeaviesHelper(temp.Right);
            }
            else if (temp.Left != null && temp.Right == null)
            {
                PrintLeaviesHelper(temp.Left);
            }
            else
            {
                PrintLeaviesHelper(temp.Left);
                PrintLeaviesHelper(temp.Right);
            }
        }

        #endregion



    }
    public class Program {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            Console.Write("Plz Enter Count Of Node IN Binary Tree:");
            int Count = Int32.Parse(Console.ReadLine());
            Console.WriteLine("PLZ Enter Node Value:");
            for (int i = 1; i <= Count; i++)
            {
                long Item = Int64.Parse(Console.ReadLine());
                tree.AddNode(Item);
            }
            Console.WriteLine("PLZ Enter Nodes Value:");
            for (int i = 1; i <= Count; i++)
            {

                long Item = Int64.Parse(Console.ReadLine());
                tree.AddDothNode(Item);
            }
            Console.WriteLine("\nTraversal By using Breadth First :");
            tree.BFS();
            Console.WriteLine("\nTraversal By using Depth First=>Pre Order :");
            tree.DFS_PreOrder();
            Console.WriteLine("\nTraversal By using Depth First=>Post Order :");
            tree.DFS_POSTOrder();
            Console.Write("\nPlZ Enter Search Number :");
            long search_num = Int64.Parse(Console.ReadLine());
            tree.Search(search_num);
            Console.Write("\nDeleting Node in tree :");
            long Delete_num = Int64.Parse(Console.ReadLine());
            tree.Deletion(Delete_num);
            Console.WriteLine("\nTraversal By using Depth First=>In Order :");
            tree.DFS_INOrder();


            Console.WriteLine("\nMy Problem  Solving ............................");

            tree.BFS();
            Console.WriteLine();
            tree.BFSDoth();
            Console.WriteLine();
            Console.Write("Two Trees :");
            tree.ProblemI();
            tree.PrintLeavies();
        }
    }

}


