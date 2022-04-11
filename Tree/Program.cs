/*
  Tree : It is used to resprsent Data As Hirecaly Format 
     1- Root
     2- Leafs
     3- Node
     4- Parent
     5- Children
     6- Length | Hight 
     7- Size 
     8- Internal Nodes
     9- OutDegree
    10- Indegree
    12- Edges
    13- brunches
    11- Total Degree
    

--- Types of Tree 
 - Binary Tree
   1- Full Binary Tree : The Parent has zero or two children . 
   2- Complete Binary Tree : All level is completed expect last level is started from left.
   3- Perfect Binary Tree : All Level is Completed ... Parent has Two Children .
   4- Balanced Binary Tree : Hight of tree is Log(n) ... | H(Left Side) - H(Right Side) | <=1
   5- Degenerate Binary Tree [physilogical] : Every Node has one Nodes ..

 ** Implement tree
  - Method will Add From Left And Another from Right 
 
 */

using System;
namespace Tree
{
    // Structure of Tree
   public class Tree
    {
        public int Key { get; set; } // Data Of A node
        public Tree Left { get; set; } // Left Pointer 
        public Tree Right { get; set; } // Right Pointer 
        public Tree(int key)
        {
            this.Key = key;
            this.Left = null;
            this.Right = null;
        }
    }
    // Implement Tree 
    public class Node
    {
        public Tree First { get; set; } // refer to Right 
        public Tree Second { get; set; } // refer to left
        public Node() // Initial for two properties
        {
            First = null;
            Second = null;
        }
        // Initial Node 
        public Node(int key)
        {
            Tree tree = new Tree(key);
            tree.Left = null;
            tree.Right = null;
            this.First = tree;
            this.Second = tree;
        }
        // Push From Right..... 
        public void PushFrompmRight(int key)
        {
            Tree Ptr = this.First;
            while (Ptr.Right!=null)
            {
                Ptr = Ptr.Right;
            }
            Tree tree = new Tree(key);
            Ptr.Right = tree;
            tree.Right = null;
        }

        // Push from Right ....
        public void PushFrompmLeft(int key)
        {
            Tree Ptr = this.Second;
            while (Ptr.Left != null)
            {
                Ptr = Ptr.Left;
            }
            Tree tree = new Tree(key);
            Ptr.Left = tree;
            tree.Left = null;
        }

















    }
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(1);
            for (int i = 0; i < 3; i++)
            {
             node.PushFrompmRight(2);
             node.PushFrompmLeft(3);
            }
           
        }
    }
}
