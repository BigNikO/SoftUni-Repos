using System;
using System.Numerics;

namespace Exe13Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            FactorialMethod(number);
        }
        static void FactorialMethod(BigInteger number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
