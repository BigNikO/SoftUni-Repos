using System;

namespace Lab4DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintHeaderRow(number);
            for (int i = 2; i <= number-1; i++)
            {
                PrintMiddleRow(number);
                Console.WriteLine();
            }
            PrintHeaderRow(number);

        }

        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));

        }
        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            Console.Write("\\/");
            Console.Write('-');
        }

    }
}
