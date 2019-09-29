using System;

namespace Lab5SpecialNumber
{
    class SpecialNumber
    {
        static void Main(string[] args)
        {
            int n = byte.Parse(Console.ReadLine());

            for (int number = 1; number <= n; number++)
            {
                bool check = false;
                int sum = 0;
                int j = number;
                while (j != 0)
                {
                    sum = sum + (j % 10);
                    j = j / 10;
                }
                if ((sum == 7) || (sum == 5) || (sum == 11))
                {
                    check = true;
                }
                Console.WriteLine($"{number} -> {check}");
            }

        }
    }
}
