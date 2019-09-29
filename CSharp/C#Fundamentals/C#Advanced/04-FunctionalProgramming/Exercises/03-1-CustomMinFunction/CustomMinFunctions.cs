using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex3CustomMinFunction
{
    class CustomMinFunctions
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Func<int[], int> minNumber = numbers => numbers.Min();
            Console.WriteLine(minNumber(input));
        }
    }
}