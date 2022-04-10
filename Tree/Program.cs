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
    11-Total Degree
    12-Edges
    

Types of Tree 
 - Binary Tree
   1- Full Binary Tree : The Parent has zero or two children . 
   2- Complete Binary Tree : All level is completed expect last level is started from left.
   3- Perfect Binary Tree : All Level is Completed ... Parent has Two Children .
   4- Balanced Binary Tree : Hight of tree is Log(n) ... | H(Left Side) - H(Right Side) | <=1
   5- Degenerate Binary Tree [physilogical] : Every Node has one Nodes ..
   
 
 
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
        public Tree()
        {
            this.Left = null;
            this.Right = null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
