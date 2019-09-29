using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex8LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            string upperCase = "abcdefghijklmnopqrstuvwxyz".ToUpper();
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            List<decimal> sum = new List<decimal>();
            foreach (var item in input)
            {

                char firstLetter = item[0];
                char secondLetter = item[item.Length - 1];
                string stringNumber = null;
                for (int i = 1; i < item.Length - 1; i++)
                {
                    stringNumber += item[i];
                }
                decimal number = decimal.Parse(string.Join(null, stringNumber));
                if (char.IsUpper(firstLetter))
                {
                    number = number / (upperCase.IndexOf(firstLetter) + 1);
                }
                else
                {
                    number = number * (lowerCase.IndexOf(firstLetter) + 1);
                }
                if (char.IsUpper(secondLetter))
                {
                    number = number - (upperCase.IndexOf(secondLetter) + 1);
                }
                else
                {
                    number = number + (lowerCase.IndexOf(secondLetter) + 1);
                }
                sum.Add(number);
            }
            decimal result = sum.Sum(x => x);
            Console.WriteLine($"{result:f2}");
        }
    }
}
