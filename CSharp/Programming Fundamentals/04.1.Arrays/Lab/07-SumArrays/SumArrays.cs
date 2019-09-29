using System;
using System.Linq;

namespace Lab7SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var secondArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int max = MaxMethod(firstArr.Length, secondArr.Length);
            long[] sumArray = new long[max];
            for (int i = 0; i < max; i++)
            {
                sumArray[i] = firstArr[i % firstArr.Length] + secondArr[i % secondArr.Length];
            }
            Console.WriteLine(string.Join(' ', sumArray));
        }
        static int MaxMethod(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
