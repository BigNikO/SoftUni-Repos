using System;

namespace Exe1LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            {
                string[] first = Console.ReadLine().Split();
                string[] secound = Console.ReadLine().Split();
                int leftCounter = 0;
                int rightCounter = 0;

                int smallLenght = Math.Min(first.Length, secound.Length);

                for (int i = 0; i < smallLenght; i++)
                {
                    if (first[i] == secound[i])
                    {
                        leftCounter++;
                    }
                    if (first[first.Length - 1 - i] == secound[secound.Length - 1 - i])
                    {
                        rightCounter++;
                    }
                }
                Console.WriteLine(Math.Max(leftCounter, rightCounter));
            }

        }
    }
}

