using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex3MaximumElement
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            int queries = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < queries; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                if (line[0] == "1")
                {
                    stack.Push(int.Parse(line[1]));
                }
                else if (line[0] == "2")
                {
                    stack.Pop();
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
