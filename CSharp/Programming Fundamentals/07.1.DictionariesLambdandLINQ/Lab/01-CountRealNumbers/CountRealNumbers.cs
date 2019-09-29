using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var counts = new SortedDictionary<double, int>();
            foreach (var number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts[number] = 1;
                }
            }
            foreach (var item in counts)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
