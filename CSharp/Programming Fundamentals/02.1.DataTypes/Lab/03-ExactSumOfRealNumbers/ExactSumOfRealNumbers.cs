using System;

namespace Lab3ExactSumOfRealNumbers
{
    class ExactSumOfRealNumbers
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            decimal exactSum = 0;
            for (byte i = 1; i <= n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                exactSum += number;
            }
            Console.WriteLine(exactSum);
        }
    }
}
