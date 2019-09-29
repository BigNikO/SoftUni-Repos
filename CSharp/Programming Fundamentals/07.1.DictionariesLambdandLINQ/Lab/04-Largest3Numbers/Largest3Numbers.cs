using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ", numbers.OrderBy(x => -x).Take(3)));
        }
    }
}
