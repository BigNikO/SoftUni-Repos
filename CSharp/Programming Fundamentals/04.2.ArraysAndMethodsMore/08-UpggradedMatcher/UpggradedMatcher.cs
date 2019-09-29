using System;
using System.Linq;

namespace Ex8UpggradedMatcher
{
    class UpggradedMatcher
    {
        static void Main(string[] args)
        {
            string[] productsNames = Console.ReadLine().Split(' ');
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            string[] command = new string[1];
            while (command[0] != "done")
            {
                command = Console.ReadLine().Split(' ');
                if (productsNames.Contains(command[0]))
                {
                    int index = Array.IndexOf(productsNames, command[0]);
                    if (quantities.Length - 1 < index)
                    {
                        Console.WriteLine($"We do not have enough {productsNames[index]} ");
                    }
                    else if (quantities[index] - long.Parse(command[1]) < 0)
                    {
                        Console.WriteLine($"We do not have enough {productsNames[index]} ");
                    }
                    else
                    {
                        Console.WriteLine($"{productsNames[index]} x {command[1]} costs {prices[index] * decimal.Parse(command[1]):f2}");
                        quantities[index] -= long.Parse(command[1]);
                    }
                }
            }
        }
    }
}
