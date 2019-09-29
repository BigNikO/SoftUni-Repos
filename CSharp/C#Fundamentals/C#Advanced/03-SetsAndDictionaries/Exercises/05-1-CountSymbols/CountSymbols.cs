using System;
using System.Collections.Generic;

namespace Ex5CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> symbolsDictionary = new SortedDictionary<char, int>();
            foreach (var symbol in input)
            {
                if (symbolsDictionary.ContainsKey(symbol))
                {
                    symbolsDictionary[symbol]++;
                }
                else
                {
                    symbolsDictionary[symbol] = 1;
                }
            }

            foreach (var symbol in symbolsDictionary)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
