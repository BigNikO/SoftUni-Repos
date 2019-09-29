using System;
using System.Linq;

namespace Lab5RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = ReadNumbers();
            int[] roundedNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNumbers[i] = (int)(Math.Round(numbers[i], MidpointRounding.AwayFromZero));
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} -> {roundedNumbers[i]}");
            }               

        }
        static double[] ReadNumbers()
        {
            double[] arrNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            return arrNumbers;
        }
    }
}
