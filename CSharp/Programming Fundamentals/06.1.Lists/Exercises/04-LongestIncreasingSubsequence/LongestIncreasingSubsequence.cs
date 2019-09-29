using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex4LongestIncreasingSubsequence
{
    class LongestIncreasingSubsequence
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int length = numbers.Count;
            int[] len = new int[length];
            List<int> LIS = new List<int>();
            int[] previous = new int[length];
            int maxLength = 0;
            int lastEnd = -1;
            for (int i = 0; i < length; i++)
            {
                len[i] = 1;
                previous[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j]<numbers[i] && len[j]>=len[i])
                    {
                        len[i] = 1 + len[j];
                        previous[i] = j;
                    }
                }
                if (maxLength<len[i])
                {
                    maxLength = len[i];
                    lastEnd = i;
                }
            }
            for (int i = 0; i < maxLength; i++)
            {
                LIS.Add(numbers[lastEnd]);
                lastEnd = previous[lastEnd];
            }
            LIS.Reverse();
            Console.WriteLine(string.Join(" ", LIS));
        }
    }
}
