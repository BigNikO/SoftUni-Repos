using System;
using System.Linq;

namespace Ex8CustomComparator
{
    class CustomComparator
    {
        static void Main(string[] args)
        {
            Action<int[]> print = numbers => Console.WriteLine(String.Join(" ", numbers
                .OrderBy(x => x)
                .Where(x => x % 2 == 0)
                .Concat(numbers
                .OrderBy(x => x)
                .Where(x => x % 2 != 0))));
            print(Console.ReadLine().Split().Select(int.Parse).ToArray());
        }
    }
}