using System;
using System.Collections.Generic;
using System.Linq;
namespace Ex2OddFilter
{
    class OddFilter
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers.Remove(numbers[i]);
                    i--;
                }
            }
            double average = numbers.Average();
            for (int i = 0; i < numbers.Count; i++)
            {                            
                if (numbers[i] > average)
                {
                    numbers[i] += 1;
                }
                else if (numbers[i] <= average)
                {
                    numbers[i] -= 1;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
