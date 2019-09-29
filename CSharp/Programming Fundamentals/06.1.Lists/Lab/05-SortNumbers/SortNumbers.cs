using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            numbers.Sort();
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i]);
                if (i<numbers.Count-1)
                {
                    Console.Write(" <= ");
                }
            }
            Console.WriteLine();
        }
    }
}
