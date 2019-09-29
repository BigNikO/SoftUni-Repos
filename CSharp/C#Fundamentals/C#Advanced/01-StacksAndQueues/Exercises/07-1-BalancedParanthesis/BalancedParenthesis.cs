using System;
using System.Collections.Generic;

namespace Lab7BalancedParanthesis
{
    class BalancedParenthesis
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();

            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == "{" ||
                    input[i].ToString() == "[" ||
                    input[i].ToString() == "(")
                {
                    stack.Push(input[i].ToString());
                    stack.Push(input[i].ToString());
                }
                else if (stack.Count == 0 ||
                    (stack.Peek() == "{" && input[i].ToString() != "}") ||
                     (stack.Peek() == "(" && input[i].ToString() != ")") ||
                     (stack.Peek() == "[" && input[i].ToString() != "]"))
                {
                    Console.WriteLine("NO");
                    return;
                }
                stack.Pop();
            }
            Console.WriteLine("YES");
        }
    }
}
