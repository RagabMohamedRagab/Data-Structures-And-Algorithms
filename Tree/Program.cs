using System;
namespace Tree {
    // This is Structured of Node 
    class Node {
        public long Key;
        public Node Left;
        public Node Right;
        public Node(int data)
        {
            Key = data;
            Left = null;
            Right = null;
        }
    }

    class BST {
        public Node Temp = null; // To Iterate at Tree
        public Node Root = null; // To refer First Node
        public Node Previous = null;  // holds Previous Node
        public void Add(int key)
        {
            Node node = new Node(key);
            node.Left = null;
            node.Right = null;
            if (Root == null)  // If Tree is Empty
            {
                Root = node;
                Temp = Root;
                return;
            }

            Temp = Root;
            while (Temp != null)
            {
                Previous = Temp;
                if (Temp.Key < key)
                {
                    Temp = Temp.Right;
                }
                else
                {
                    Temp = Temp.Left;
                }
            }
            if (Previous.Key < key)
            {

                Previous.Right = node;
            }
            else
            {
                Previous.Left = node;
            }
        }
        public void AddHelper(int key)
        {
            Node node = new Node(key);
            if (Root == null)  // If Tree is Empty
            {
                Root = node;
                Temp = Root;
                return;
            }
            else
            {
                Temp = Root;
                Helper(Temp, key);
            }

        }
        // Recusrion 
        public void Helper(Node temp, int data)
        {

            if (temp == null)
            {
                Node node = new Node(data);
                if (Previous.Key < data)
                {
                    Previous.Right = node;
                }

                else
                {
                    Previous.Left = node;
                }
                return;
            }
            else
            {
                Previous = temp;
                if (temp.Key < data)
                {
                    temp = temp.Right;
                    Helper(temp, data);
                }
                else
                {
                    temp = temp.Left;
                    Helper(temp, data);
                }
            }
        }
        // Max
        public long GetMax()
        {
            Temp = Root;
            if (Temp == null)
            {
                Console.WriteLine("Tree is Empty.");
            }
            while (Temp != null)
            {
                Previous = Temp;
                Temp = Temp.Right;
            }
            return Previous.Key;
        }
       // Max Recursion
       public void GetMaxRec()
        {
            Temp = Root;
            if(Temp == null)
            {
                Console.WriteLine("Tree Is Empty..");
            }
            else
            {
                GetMaxHelper(Temp);

            }
        }
       public void GetMaxHelper(Node Temp)
        {
            if (Temp.Right == null)
            {
                Console.WriteLine("Max :"+Previous.Key);
            }
            else
            {
                Previous = Temp.Right;
                GetMaxHelper(Temp.Right);
            }
        }
        //Min 
       public long GetMin()
        {
            Temp = Root;
            if (Temp == null)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                while (Temp!=null) {
                    Previous = Temp;
                    Temp=Temp.Left;
                }
            }
            return Previous.Key;

        }
       public void GetMinHelper()
        {
            Temp = Root;
            if (Temp == null)
            {
                Console.WriteLine("tree Is Empty.");
            }
            else
            {
                MinHelper(Temp.Left);
            }
        }

        public void MinHelper(Node Temp)
        {
            if (Temp == null)
            {
                Console.WriteLine(Previous.Key);
            }
            else
            {
                Previous = Temp;
                MinHelper(Temp.Left);
            }
        }

    }
    class Program {

        static void Main(string[] args)
        {
            BST bST = new BST();
            for (int i = 0; i < 4; i++)
            {
                bST.AddHelper(i);
            }
            Console.WriteLine("Max by iteration:" + bST.GetMax());
            Console.Write("Recursion:");
            bST.GetMaxRec();
            for (int i = -3; i <= 0; i++)
            {
                bST.Add(i);
            }
            Console.WriteLine("Min by iteration: :" + bST.GetMin());
            Console.Write("Recursion:");
            bST.GetMinHelper();
        }
    }
}



