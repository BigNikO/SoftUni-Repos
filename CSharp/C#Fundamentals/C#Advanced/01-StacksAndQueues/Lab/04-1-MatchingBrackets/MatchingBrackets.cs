using System;
using System.Collections.Generic;

namespace Lab4MatchingBrackets
{
    class MatchingBrackets
    {
        static void Main(string[] args)
        {
            List<string> result = new List<string>();
            Stack<int> stack = new Stack<int>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ('('))
                {
                    stack.Push(i);
                }

                if (input[i] == (')'))
                {
                    int startIndex = stack.Pop();
                    result.Add(input.Substring(startIndex, i - startIndex + 1));
                }
            }
            Console.WriteLine(String.Join(Environment.NewLine, result));
        }
    }
}
