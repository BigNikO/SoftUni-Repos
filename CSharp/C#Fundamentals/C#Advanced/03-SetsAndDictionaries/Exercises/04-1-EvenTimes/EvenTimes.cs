using System;
using System.Collections.Generic;

namespace Ex4EvenTimes
{
    class EvenTimes
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            int iterations = int.Parse(Console.ReadLine());

            for (int i = 0; i < iterations; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (numbers.ContainsKey(currentNumber))
                {
                    numbers[currentNumber]++;
                }
                else
                {
                    numbers.Add(currentNumber, 1);
                }
            }

            foreach (var number in numbers)
            {
                if (number.Value%2==0)
                {
                    Console.WriteLine(number.Key);
                    break;
                }
            }
        }


    }
}
