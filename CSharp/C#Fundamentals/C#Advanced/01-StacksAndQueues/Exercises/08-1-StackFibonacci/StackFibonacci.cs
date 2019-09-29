using System;
using System.Collections.Generic;

namespace Ex8StackFibonacci
{
    class StackFibonacci
    {
        static void Main(string[] args)
        {
            Stack<long> fibonacci = new Stack<long>();
            fibonacci.Push(0);
            fibonacci.Push(1);
            long count = long.Parse(Console.ReadLine());

            for (long i = 0; i < count-1; i++)
            {
                long popped = fibonacci.Pop();
                long newElement = popped + fibonacci.Peek();
                fibonacci.Push(popped);
                fibonacci.Push(newElement);
            }
            if (count==1)
            {
                Console.WriteLine(0);
                return;
            }
            Console.WriteLine(fibonacci.Peek());
        }
    }
}
