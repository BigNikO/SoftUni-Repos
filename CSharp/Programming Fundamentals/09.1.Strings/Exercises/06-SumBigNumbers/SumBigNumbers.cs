using System;

namespace Ex6SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {            
            string numberOne = Console.ReadLine().TrimStart('0');
            string numberTwo = Console.ReadLine().TrimStart('0');
            int sum = 0;
            string result = "";
            int differenceLength = Math.Max(numberOne.Length, numberTwo.Length) - Math.Min(numberOne.Length, numberTwo.Length);
            if (numberOne.Length<numberTwo.Length)
            {
                result = numberTwo;
                numberTwo = numberOne;
                numberOne = result;
                result = "";
            }
            for (int i = numberOne.Length-1; i >= differenceLength; i--)
            {
                sum += (int)char.GetNumericValue(numberOne[i]) + (int)char.GetNumericValue(numberTwo[i-differenceLength]); ;
                if (sum >= 10)
                {
                    result = sum % 10 +result;
                    sum = 1;
                }
                else
                {
                    result = sum + result;
                    sum = 0;
                }
            }
            for (int i = differenceLength - 1; i >= 0; i--)
            {

                sum += (int)char.GetNumericValue(numberOne[i]);
                if (sum >= 10)
                {
                    result = sum % 10 + result;
                    sum = 1;
                }
                else
                {
                    result = sum + result;
                    sum = 0;
                }
            }
            if (sum==1)
            {
                result = sum + result;
            }
            Console.WriteLine(result);
        }
    }
}

 
