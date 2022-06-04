/* Problem Solving :Balanced Parntheses
*  Date => 27-7-2021
*  Complexity Time Is 
*  T(n) belong To O(n)
*/
using System;
namespace Practies_DataStructures_And_Algorithm {
    // First Create class Stack
    class Stack {
        public int Top; // Top In Stack
        public int SizeOfArr;
        public int[] Items;
        public Stack()
        {
            Top = -1;
            SizeOfArr = 100;
            Items = new int[SizeOfArr];
        }
        // Test If Full Stack
        public bool IsFull(int Top)
        {
            return Top > SizeOfArr - 1;
        }
        // Test If Empty
        public bool IsEmpty(int Top)
        {
            return Top == -1;
        }
        // To Push Items In Stack
        public void Push(int Number)
        {
            if (IsFull(Top))
                Console.WriteLine("Stack Is Full");
            else
                Items[++Top] = Number;
        }
        public int Pop()
        {
            if (IsEmpty(Top))
                Console.WriteLine("Stack Is Empty..");
            else
                return Items[Top--];

            return 0;
        }
        // To Count Length Of Stack Use This Method
        int index = 0;
        public int GetLengthOfStack()
        {
            for (int i = Top; i >= 0; i--) ++index;

            return index;
        }
    }
    class Program {

        static void Main(string[] args)
        {
            char[] brackets = new char[] { '{', '(', ')', '}', '[', ']' };

            // Test
            if (AreBracketsBalanced(brackets))
                Console.WriteLine("Balance");
            else
                Console.WriteLine("No-Balance");


        }
        public static bool AreBracketsBalanced(char[] Bar)
        {
            Stack stack = new Stack();
            foreach (var item in Bar)
            {
                // Check Open Parnthses -brackets-braces
                if (item == '[' || item == '{' || item == '(')
                {
                    stack.Push(item);
                }
                // Check If Stack Is Empty
                if (stack.Top == -1)
                {
                    return false;
                }
                // Close Open Parnthses -brackets-braces
                else if (item == ']' || item == ')' || item == '}')
                {

                    if (!Compare((char)stack.Pop(), item)) // Current Items If Equals (Current-1) then True ,Otherwise False
                        return false;
                }

            };
            return (stack.Top == -1);
        }
        // Test For [  ] | { } | ( )
        public static bool Compare(char item, char pop)
        {
            if (item == '{' || pop == '}')
                return true;
            else if (item == '[' || pop == ']')
                return true;
            else if (item == '(' || pop == ')')
                return true;

            return false;

        }
    }
}