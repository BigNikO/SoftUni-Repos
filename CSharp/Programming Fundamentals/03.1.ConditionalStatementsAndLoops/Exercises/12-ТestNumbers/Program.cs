using System;

namespace Exe12testNumbers
{
    class ТestNumbers
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            for (int i = number1; i >= 1; i--)
            {
                for (int j = 1; j <= number2; j++)
                {
                    if (sum >= maxSum)
                    {
                        break;
                    }
                    sum = sum + 3 * j * i;
                    counter++;
                }
            }
            Console.WriteLine($"{counter} combinations");
            if (sum >= maxSum)
            {
                Console.WriteLine($"Sum: {sum} >= {maxSum}");
            }
            else
                Console.WriteLine($"Sum: {sum}");

        }
    }
}
