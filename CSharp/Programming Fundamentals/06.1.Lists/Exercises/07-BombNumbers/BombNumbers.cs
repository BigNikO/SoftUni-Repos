using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex7BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bombPower = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = -1;
            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] == bombPower[0])
                {
                    index = i;
                    int left = index - bombPower[1];
                    if (left<0)
                    {
                        left = 0;
                    }
                    int rigth = index + bombPower[1];
                    if (rigth>sequence.Count-1)
                    {
                        rigth = sequence.Count - 1;
                    }
                    int length = rigth - left + 1;
                    sequence.RemoveRange(left, length);
                    i--;
                }
            }          
            Console.WriteLine(string.Join(" ", sequence.Sum()));
        }
    }
}
