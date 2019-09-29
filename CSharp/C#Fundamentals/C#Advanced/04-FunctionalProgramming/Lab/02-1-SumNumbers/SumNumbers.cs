using System;
using System.Linq;

namespace Lab2SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Console.WriteLine(input.Length);
            Console.WriteLine(input
                .Select(int.Parse)
                .ToArray()
                .Aggregate((a, b) => a + b));
        }
    }
} 