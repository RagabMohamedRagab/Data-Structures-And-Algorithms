/* Problem Solving => Postfix | Prefix | Infix
* Day => 12-8-2021
* Complexity Time Is 
*  T(n) belong To O(n)
*/
using System;
using System.Collections.Generic;

namespace Infix_PreFix_PostFix {
    // I Will Create  A Static Class
    static class PIP {
        static string[] GetOper = new string[100];
        static int top = -1; // Must be iniliazes -1
        public static void Push(char Ch)
        {
            if (!(top++ == GetOper.Length - 1))
                GetOper[top] = Ch.ToString();
            else
                Console.WriteLine("Stack Is Full>>");

        }
        // Get  Top Of The Stack
        public static string FirstTop()
        {
            return GetOper[top];
        }

        // Then Delete First And Second Top Of tHE Stack
        public static void Pop()
        {
            if (!(top == -1))
                top--;
            else
                Console.WriteLine("Empty Stack>>");
        }


    }
    class Program {
        static void Main(string[] args)
        {
            string Postfixstring = "382/+5-";
            Console.WriteLine(GetResult(Postfixstring));

        }
        public static dynamic GetResult(string str)
        {
            foreach (var ch in str)
            {
                if (Char.IsDigit(ch))
                {
                    PIP.Push(ch);
                }
                else if (Char.IsLetter(ch))
                {
                    throw new FormatException("Invalid Charactre!");
                }
                else
                {
                    var op2 = PIP.FirstTop();
                    PIP.Pop();
                    var op1 = PIP.FirstTop();
                    PIP.Pop();
                    dynamic Result = (Operations(op1, op2, ch)).ToString();
                    PIP.Push(Convert.ToChar(Result));
                }

            }
            return PIP.FirstTop();
        }
        public static double Operations(dynamic op1, dynamic op2, int op)
        {
            if (op == '+')
                return op1 + op2;
            else if (op == '-')
                return op1 - op2;
            else if (op == '*')
                return op1 * op2;
            else if (op == '%')
                return op1 % op2;
            else
                return op1 / op2;
        }

    }
}
