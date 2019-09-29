using System;
using System.Linq;

namespace Exe6MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] elementsArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int startPoint = 0;
            int length = 1;
            int bestStart = startPoint;
            int bestLength = length;
            for (int i = 1; i < elementsArray.Length; i++)
            {
                if (elementsArray[i] == elementsArray[i - 1])
                {
                    length++;
                    if (length>bestLength)
                    {
                        bestLength = length;
                        bestStart = startPoint;
                    }
                }
                else
                {
                    length = 1;
                    startPoint = i;
                }
            }
            for (int i = 0; i < bestLength; i++)
            {
                Console.Write(elementsArray[i+bestStart] + " ");
            }
        }
    }
}
