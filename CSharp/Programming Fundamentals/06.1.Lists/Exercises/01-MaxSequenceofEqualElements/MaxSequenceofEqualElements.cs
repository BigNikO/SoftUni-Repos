using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex1MaxSequenceofEqualElements
{
    class MaxSequenceofEqualElements
    {
        static void Main(string[] args)
        {
            List<int> inputLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int bestCounter = 0;
            int bestStart = 0;
            int bestEnd = 0;
            for (int i = 0; i < inputLine.Count-1; i++)
            {
                int counter = 1;
                int start = i;
                while (i < inputLine.Count - 1 && inputLine[i] == inputLine[i+1])
                {
                    counter++;
                    i++;

                }
                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    if (bestStart<start)
                    {
                        bestStart = start;
                    }
                    bestEnd = i;
                }
            }
            for (int i = bestStart; i <= bestEnd; i++)
            {
                Console.Write(inputLine[i] + " ");
            }
        }
    }
}
