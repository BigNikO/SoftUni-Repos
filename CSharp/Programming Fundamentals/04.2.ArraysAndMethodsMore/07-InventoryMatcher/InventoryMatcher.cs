using System;
using System.Linq;

namespace Ex7InventoryMatcher
{
    class InventoryMatcher
    {
        static void Main(string[] args)
        {
            string[] productsNames = Console.ReadLine().Split(' ');
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            string command = "";
            while (command != "done")
            {
                command = Console.ReadLine();
                if (productsNames.Contains(command))
                {
                    int index = Array.IndexOf(productsNames, command);
                    Console.WriteLine($"{productsNames[index]} costs: {prices[index]}; Available quantity: {quantities[index]}");
                }
            }
        }
    }
}