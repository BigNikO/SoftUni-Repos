namespace Exe13GameOfNumbers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int lastNumber1 = 0;
            int lastNumber2 = 0;
            int counter = 0;
            int combinations = 0;

            for (int i = number1; i <= number2; i++)
            {
                for (int j = number1; j <= number2; j++)
                {
                    combinations++;
                    if (i+j == magicNumber)
                    {
                        lastNumber1 = i;
                        lastNumber2 = j;
                        counter++;
                    }                 
                }
            }
            if (counter > 0)
            {
                Console.WriteLine($"Number found! {lastNumber1} + {lastNumber2} = {magicNumber}");
            }
            else
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
        }
    }
}
