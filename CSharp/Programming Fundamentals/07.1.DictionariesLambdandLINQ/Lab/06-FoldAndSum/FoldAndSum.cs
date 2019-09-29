using System;
using System.Linq;

namespace Lab6FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = (numbers.Length) / 4;
            int[] leftRow = numbers.Take(k).Reverse().ToArray();
            int[] rightRow = numbers.Reverse().Take(k).ToArray();
            int[] firstRow = leftRow.Concat(rightRow).ToArray();
            int[] secondRow = numbers.Skip(k).Take(2 * k).ToArray();
            Console.WriteLine(string.Join(" ",firstRow.Select((x, index) => x + secondRow[index])));
        }
    }
}
