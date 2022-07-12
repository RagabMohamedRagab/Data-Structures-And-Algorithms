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
    // Yup.. This is Structred of Tree
    class Node {
        public long key;
        public Node Left;
        public Node Right;
        public Node(int Key)
        {
            this.key= Key;
            this.Left = null;
            this.Right = null;
        }
    }
    // Yup .. This is Implementing of Binary Tree
    class BTS {
        public Node Root = null;
        public Node Temp=null;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (Root == null) // if tree is Empty
            {
                node.Left = null;
                node.Right = null;
                Root = node;
                Temp = Root;
                return;
            }
            Temp = Root;
            if (Temp.key <= data)
            {
                while (Temp.Right!=null)
                {
                    Temp= Temp.Right;
                }
                node.Left = null;
                node.Right = null;
                Temp.Right = node;
            }
            else
            {
                while (Temp.Left != null)
                {
                    Temp=Temp.Left;
                }
                node.Left= null;
                node.Right = null;
                Temp.Left = node;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          BTS bTS = new BTS();
            bTS.Add(1);
            bTS.Add(2);
            bTS.Add(3);
            bTS.Add(-1);
            bTS.Add(0);
        }
    }
}
