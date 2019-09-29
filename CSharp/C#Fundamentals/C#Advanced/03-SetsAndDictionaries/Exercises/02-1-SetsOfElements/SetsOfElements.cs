using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex2SetsOfElements
{
    class SetsOfElements
    {
        static void Main(string[] args)
        {
            int[] hashSetSizes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            HashSet<int> firstHashSet = new HashSet<int>();
            HashSet<int> secondHashSet = new HashSet<int>();

            AddNumbers(hashSetSizes[0], firstHashSet);
            AddNumbers(hashSetSizes[1], secondHashSet);

            IEnumerable<int> result = firstHashSet.Intersect(secondHashSet);

            Console.WriteLine(String.Join(" ", result));

        }

        private static void AddNumbers(int size, HashSet<int> numbers )
        {
            for (int i = 0; i < size; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
        }
    }
}
