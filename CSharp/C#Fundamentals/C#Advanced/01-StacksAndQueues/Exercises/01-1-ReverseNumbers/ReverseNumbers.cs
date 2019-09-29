using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex1ReverseNumbers
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            while (stack.Count>0)
            {
                Console.Write(stack.Pop() + " ");
            }
        }
    }
}
