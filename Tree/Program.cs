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
        public void GetMaxHelper()
        {
            Temp = Root;
            if (Temp == null)
            {
                Console.WriteLine("Tree is Empty.");
            }
            //Console.WriteLine(MaxHelper(Temp));
        }
        //public long MaxHelper(Node temp)
        //{
        //    if (temp == null)
        //    {
        //        return Previous.Key;
        //    }
        //    Previous = temp;
        //    MaxHelper(temp.Right);
        //    return 0;
        //}
    }
    class Program {

        static void Main(string[] args)
        {
            BST bST = new BST();
            for (int i = 0; i < 4; i++)
            {
                bST.AddHelper(i);
            }
            Console.WriteLine(bST.GetMax());
            bST.GetMaxHelper();
        }
    }
}



