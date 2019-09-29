using System;

namespace Ex4NumberInReversedOrder
{
    class NumberInReversedOrder
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            FinalReverse(number);
        }
        static void FinalReverse(decimal number)
        {
            int checkNumber = (int)(number);
            int counter = 0;
            bool check = (checkNumber==((int)(Math.Ceiling(number))));
            while (!check)
            {
                number *= 10;
                counter++;
                checkNumber = (int)number;
                check = (checkNumber == ((int)(Math.Ceiling(number))));
            }
            number = (ReverseMethod(checkNumber, counter));
            Console.WriteLine(number);
        }
        static decimal ReverseMethod(int checkNumber, int counter)
        {
            decimal result=0;
            decimal multiplay = 1;
            int counterCheck=counter;
            while (checkNumber>0)
            {
                result = result*10 +  (checkNumber % 10);             
                checkNumber = checkNumber / 10;
                if (counterCheck>0)
                {
                    counter--;
                }
            }
            for (int i = 1; i <= Math.Abs(counter); i++)
            {
                multiplay *= 10;
            }
            return result/multiplay;
        }

    }
}

