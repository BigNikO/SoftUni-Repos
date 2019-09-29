using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex6SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                int number = 0;
                while (numbers[i]>0)
                {
                    number = number*10 + numbers[i] % 10;
                    numbers[i] = numbers[i] / 10;
                }
                sum += number;               
            }
            Console.WriteLine(sum);
        }
    }
}
