using System;

namespace Ex5FibonachiNumbers
{
    class FibonachiNumbers
    {
        static void Main(string[] args)
        {
            FibonachiMethod();
        }
        static void FibonachiMethod()
        {
            long number = long.Parse(Console.ReadLine());
            long fibonachiFirst = 1;
            long fibonachiSecond = 1;
            for (int i = 1; i <= number; i++)
            {
                fibonachiSecond = fibonachiFirst - fibonachiSecond;
                fibonachiFirst += fibonachiSecond;
                
            }
            Console.WriteLine(fibonachiFirst);
        }
    }
}
