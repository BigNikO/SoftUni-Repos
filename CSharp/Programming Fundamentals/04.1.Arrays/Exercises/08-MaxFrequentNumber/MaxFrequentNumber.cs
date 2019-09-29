using System;
using System.Linq;

namespace Exe8MaxFrequentNumber
{
    class MaxFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] elementsArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bestStart = 0;
            int bestLength = 1;
            for (int i = 0; i < elementsArray.Length; i++)
            {
                int startPoint = i;
                int length = 1;
                for (int j = 0; j < elementsArray.Length; j++)
                {

                    if (elementsArray[i] == elementsArray[j])
                    {
                        length++;
                        if (length > bestLength)
                        {
                            bestLength = length;
                            bestStart = startPoint;
                        }
                    }
                }

            }
            Console.WriteLine(elementsArray[bestStart]);
        }
    }
}
