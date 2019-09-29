using System;

namespace Exe4SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool[] checkPrimeArray = new bool[number + 1];
            int br = 0;

            for (int i = 2; i <= number; i++)
            {
                checkPrimeArray[i] = true;
            }
            for (int i = 0; i <= number; i++)
            {
                if (checkPrimeArray[i])
                {
                    for (int j = 2; j * i <= number; j++)
                    {
                        checkPrimeArray[j * i] = false;
                    }
                }
            }
            for (int prime = 0; prime <= number; prime++)
            {
                if (checkPrimeArray[prime])
                {
                    if (br > 6)
                    {
                        br=0;
                        Console.WriteLine();
                    }
                    Console.Write(prime + " ");
                    br++;
                }
            }
            Console.WriteLine();
        }
    }
}
