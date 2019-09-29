using System;

namespace Lab9MultiplyEvenOdd
{
    class MultiplyEvenOdd
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            MultiplayEvenAndOdd(num);
        }
        static void MultiplayEvenAndOdd(int number)
        {
            int sumEven = 0;
            int sumOdd = 0;
            while (number > 0)
            {
                if ((number % 10) % 2 != 0)
                {
                    sumOdd += (number % 10);
                }
                else
                {
                    sumEven += (number % 10);
                }
                
                number = number / 10;
            }
            int multiplay = sumEven * sumOdd;
            Console.WriteLine(multiplay);
        }
    }
}
