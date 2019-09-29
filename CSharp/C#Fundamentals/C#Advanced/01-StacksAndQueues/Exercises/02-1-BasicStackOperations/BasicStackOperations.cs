using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex2BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int elementsToPusn = int.Parse(input[0]);
            int elementsToPop = int.Parse(input[1]);
            if (elementsToPusn == elementsToPop)
            {
                Console.WriteLine(0);
                return;
            }
            int checkNumber = int.Parse(input[2]);
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < elementsToPusn; i++)
            {
                stack.Push(numbers[i]);
            }
            int minElement = numbers[0];
            for (int i = 0; i < elementsToPusn; i++)
            {
                if (0 < elementsToPop)
                {
                    stack.Pop();
                    elementsToPop--;
                }
                else if (stack.Peek() == checkNumber)
                {
                    Console.WriteLine("true");
                    return;
                }
                else
                {
                    if (stack.Peek() < minElement)
                    {
                        minElement = stack.Pop();
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }
            Console.WriteLine(minElement);
        }
    }
}
