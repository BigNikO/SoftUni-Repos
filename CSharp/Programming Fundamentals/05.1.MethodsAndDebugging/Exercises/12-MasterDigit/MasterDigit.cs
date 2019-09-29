using System;

namespace Exe12MasterDigit
{
    class MasterDigit

    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endNumber; i++)
            {
                if (CheckPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool CheckPalindrome(int num)
        {
            bool isPalindrome = true;
            string number = num.ToString();
            for (int i = 1; i < number.Length; i++)
            {
                if (number[i-1] != number[number.Length - i])
                {
                    isPalindrome = false;
                }
            }

            return isPalindrome;
       
        }

        static bool SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }

            return false;
        }

        static bool ContainsEvenDigit(int num)
        {
            while (num > 0)
            {
                byte digit = (byte)(num % 10);
                if (digit % 2 == 0)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }
    }
}
