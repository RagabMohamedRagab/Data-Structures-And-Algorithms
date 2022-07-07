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
    

--- Types of Tree Binary Tree
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
    class BTS {
       public  class Node {
            public int key;
            public Node Left;
            public Node Right;
            public Node(int key)
            {
                this.key = key;

            }
        }
         public Node Temp=null;
        public Node Root=null;
        
        // Adding Node
        public void Add(int value)
        {
            Node node = new Node(value);
            //if (Root == null) {
            //    {
            //        node.Left = null;
            //        node.Right = null;
            //        Temp = node;
            //        Root = node;
            //        return;
            //    }
            //    while (true)
            //    {
            //        Temp = Root;
            //        if (Temp.key >= value)
            //        {
            //            Temp.Right = Root.Right;


            //        }
            //        else
            //        {

            //        }

            //    }


        }

    }
 
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
