using System;

namespace Ex7MultiplayBigNumbers
{
    class MultiplayBigNumbers
    {
        static void Main(string[] args)
        {
            string numberOne = Console.ReadLine().TrimStart('0');
            int numberTwo = int.Parse(Console.ReadLine());
            int sum = 0;
            string result = "";
            for (int i = numberOne.Length - 1; i >= 0; i--)
            {
                sum += (int)char.GetNumericValue(numberOne[i]) * numberTwo ;
                if (sum >= 10)
                {
                    result = sum % 10 + result;
                    sum = sum/10;
                }
                else
                {
                    result = sum + result;
                    sum = 0;
                }
            }
            if (sum >= 1)
            {
                result = sum + result;
            }
            if (numberTwo==0)
            {
                result = "0";
            }
            Console.WriteLine(result);
        }
    }
}
