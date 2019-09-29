using System;
using System.Collections.Generic;
using System.Linq;
namespace Pb2CaminoFactory
{
    class CaminoFactory
    {
        static void Main(string[] args)
        {
            int sequenceLength = int.Parse(Console.ReadLine());
            int bestSum = 0;
            int bestIndex = 0;
            int bestLen = 0;
            int bestSample = 1;
            int sample = 0;
            string bestDNA="";
            for (int i = 0; i < sequenceLength; i++)
            {
                bestDNA += "0 ";
            }
            string input;
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                List<int> DNA = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                int currentLen = 0;
                int currentSum = DNA.Sum(x => x);
                int currentIndex = 1;              
                sample++;
                for (int i = 0; i < sequenceLength; i++)
                {
                    if (DNA[i] == 1)
                    {
                        currentLen++;
                        if (currentLen > bestLen)
                        {
                            bestLen = currentLen;
                            bestIndex = currentIndex;
                            bestSum = currentSum;
                            bestDNA = string.Join(" ", DNA);
                            bestSample = sample;
                        }
                        if (currentLen == bestLen && bestIndex > currentIndex)
                        {
                            bestIndex = currentIndex;
                            bestSum = currentSum;
                            bestDNA = string.Join(" ", DNA);
                            bestSample = sample;
                        }
                        else if (currentLen == bestLen && currentSum > bestSum)
                        {
                            bestSum = currentSum;
                            bestDNA = string.Join(" ", DNA);
                            bestSample = sample;
                        }                       
                    }
                    else
                    {
                        currentIndex = i + 2;
                        currentLen = 0;
                    }
                }              
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine(bestDNA);
        }
    }
}
