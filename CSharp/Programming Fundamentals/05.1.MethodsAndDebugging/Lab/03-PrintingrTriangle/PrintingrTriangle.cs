using System;

namespace Lab3PrintingrTriangle
{
    class PrintingrTriangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                PrintTriangle(i);
            }
            for (int i = n-1; i >= 1; i--)
            {
                PrintTriangle(i);
            }
        }
        static void PrintTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}
