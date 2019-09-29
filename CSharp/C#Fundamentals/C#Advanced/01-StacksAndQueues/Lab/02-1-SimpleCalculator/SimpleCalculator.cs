using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2SimpleCalculator
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            var values = Console.ReadLine().Split(' ');
            Stack<string> stack = new Stack<string>(values.Reverse());

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string operation = stack.Pop();
                int second = int.Parse(stack.Pop());
                switch (operation)
                {
                    case "+":
                        {
                            stack.Push((first + second).ToString());
                        }
                        break;
                    case "-":
                        {
                            stack.Push((first - second).ToString());
                        }
                        break;
                }

            }
            Console.WriteLine(stack.Pop());
        }
    }
}

