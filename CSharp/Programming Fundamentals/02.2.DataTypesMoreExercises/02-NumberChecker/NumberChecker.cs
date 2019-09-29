using System;

namespace Ex2NumberChecker
{
    class NumberChecker
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            long intNumber = (long)number;
            if (intNumber == number)
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
