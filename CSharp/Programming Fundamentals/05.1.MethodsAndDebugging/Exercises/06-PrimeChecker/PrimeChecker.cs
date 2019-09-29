using System;

namespace Ex6PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            bool checkNumber = Checker(number);
            Console.WriteLine(checkNumber);
        }
        static bool Checker(long number)
        {
            bool check = true;
            if (number==0 || number == 1)
            {
                check = false;
            }
            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if ((number%i)==0)
                {
                    check = false;
                    break;
                }
            }
            return check;
        }
    }
}
