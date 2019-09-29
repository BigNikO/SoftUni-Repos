using System;
using System.Text.RegularExpressions;

namespace Ex3SoftUniBarIncome
{
    class SoftUniBarIncome
    {
        static void Main(string[] args)
        {
           
            string pattern = @"^\%([A-Z]{1}[a-z]+)\%[^.?$,]*<([\w]+)>[^.?$,]*\|([\d]+)\|[^\d.?$,]*([\d]+\.{0,1}[0-9]*)\$$";
            double income = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of shift")
                {
                    break;
                }
                Match validation = Regex.Match(input, pattern);
                if (validation.Success)
                {
                    string customerName = validation.Groups[1].Value;
                    string product = validation.Groups[2].Value;
                    double totalPrice = double.Parse(validation.Groups[4].Value) * int.Parse(validation.Groups[3].Value);
                    income += totalPrice;
                    Console.WriteLine($"{customerName}: {product} - {totalPrice:f2}");
                }
            }
            Console.WriteLine($"Total income: {income:f2}");

        }
    }
}
