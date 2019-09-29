using System;
using System.Numerics;

namespace Exe14TrailingZeros
{
    class TrailingZeros
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            CheckZeros(number);
        }
        static BigInteger Factorial(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        static void CheckZeros(int number)
        {
            int counter=0;
            BigInteger factorialNumber = Factorial(number);
            while(factorialNumber%10 == 0)
            {
                factorialNumber = factorialNumber / 10;
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
