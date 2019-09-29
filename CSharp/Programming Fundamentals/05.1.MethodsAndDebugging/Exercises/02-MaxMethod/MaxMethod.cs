using System;

namespace Ex2MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int maxNumber = GetMaxNumber(firstNumber, secondNumber);
            maxNumber = GetMaxNumber(maxNumber, thirdNumber);
            Console.WriteLine(maxNumber);
        }

        static int GetMaxNumber(int firstNumber, int secondNumber)
        {
            int result = firstNumber;
            if (result < secondNumber)
            {
                result = secondNumber;
            }
            return result;
        }
    }
}
