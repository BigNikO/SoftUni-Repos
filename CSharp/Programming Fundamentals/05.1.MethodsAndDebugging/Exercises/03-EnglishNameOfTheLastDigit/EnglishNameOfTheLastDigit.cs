using System;

namespace Ex3EnglishNameOfTheLastDigit
{
    class EnglishNameOfTheLastDigit
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            EnglishNameOfDigit(number);
        }

        static void EnglishNameOfDigit(long number)
        {
            number = Math.Abs(number % 10);
            string result = string.Empty;
            switch (number)
            {
                case 1:
                    {
                        result = "one";
                    }
                    break;
                case 2:
                    {
                        result = "two";
                    }
                    break;
                case 3:
                    {
                        result = "three";
                    }
                    break;
                case 4:
                    {
                        result = "four";
                    }
                    break;
                case 5:
                    {
                        result = "fife";
                    }
                    break;
                case 6:
                    {
                        result = "six";
                    }
                    break;
                case 7:
                    {
                        result = "seven";
                    }
                    break;
                case 8:
                    {
                        result = "eight";
                    }
                    break;
                case 9:
                    {
                        result = "nine";
                    }
                    break;
                case 0:
                    {
                        result = "zero";
                    }
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
