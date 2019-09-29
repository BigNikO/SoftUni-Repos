using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab6SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<int> checkedNumbers = new List<int>();
            
            for (int i = 0; i < numbers.Count; i++)
            {
                double checkSqrt = (int)Math.Sqrt(numbers[i]);
                if (checkSqrt==Math.Sqrt(numbers[i]))
                {
                    checkedNumbers.Add((int)numbers[i]);
                }
            }
            checkedNumbers.Sort();
            checkedNumbers.Reverse();
            Console.WriteLine(String.Join(" ", checkedNumbers));
        }
    }
}
