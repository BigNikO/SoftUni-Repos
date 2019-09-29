using System;

namespace Lab9RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            bool check = false;
            for (int i = 1; i <= numbers; i++)
            {
                int currentNumber = i;
                int checkSpecial = 0;
                while (currentNumber > 0)
                {
                    checkSpecial += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }
                check = (checkSpecial == 5) || (checkSpecial == 7) || (checkSpecial == 11);
                Console.WriteLine($"{i} -> {check}");
            }

        }
    }
}
