using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex6ReverseAndExclude
{
    class ReverseAndExclude
    {
        static void Main(string[] args)
        {
            Action<List<int>, int> actions = (numbers, divider) => Console.WriteLine(String
                .Join(" ", numbers
                .Where(number => number % divider != 0)
                .Reverse()));
            actions(Console.ReadLine().Split().Select(int.Parse).ToList(), int.Parse(Console.ReadLine()));
        }
    }
}