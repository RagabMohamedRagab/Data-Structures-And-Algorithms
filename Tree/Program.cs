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
  - Pre-order-traversal[root Left right ]
 
 */

using System;
namespace Tree
{
   // Structute of Tree
  public class Node {
        public int Key;
        public Node left;
        public Node right;
        public Node(int key)
        {
            Key = key;
            left = null;
            right = null;
        }
    }
    public class Tree {
        public static Node refer = null;
         static Tree() // From Static Constructor we created Root Of the tree
        {
            Node root=new Node(1);
            refer= root;
            root.left = null;
            root.right = null;
        }

     }
    class Program
    {
        static void Main(string[] args)
        {
           Tree tree=new Tree();
        }
    }
}
