using System;
using System.Collections.Generic;


namespace Ex3MaximumElement
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            int queries = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            Stack<int> maxValues = new Stack<int>();
            for (int i = 0; i < queries; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                if (line[0] == "1")
                {
                    stack.Push(int.Parse(line[1]));
                    if (maxValues.Count == 0 || maxValues.Peek() < stack.Peek())
                    {
                        maxValues.Push(stack.Peek());
                    }
                }
                else if (line[0] == "2")
                {
                    if (maxValues.Peek() == stack.Pop())
                    {
                        maxValues.Pop();
                    }
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(maxValues.Peek());
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
