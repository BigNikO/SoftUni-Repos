using System;
using System.Linq;

namespace Ex1ArraysStatistics
{
    class ArraysStatistics
    {
        static void Main(string[] args)
        {
            int[] theArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int minNumber = theArray[0];
            int maxNumber = theArray[0];
            int sumNumbers = theArray[0];
            for (int i = 1; i < theArray.Length; i++)
            {
                sumNumbers += theArray[i];
                minNumber = Math.Min(theArray[i],minNumber);
                maxNumber = Math.Max(theArray[i], maxNumber);
            }
            double averageNumber = (double)sumNumbers / theArray.Length;
            Console.WriteLine("Min = " + minNumber);
            Console.WriteLine("Max = " + maxNumber);
            Console.WriteLine("Sum = " + sumNumbers);
            Console.WriteLine("Average = " + averageNumber);
        }
    }
}
