using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4Palidrome
{
    class Palidrome
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> result = new List<string>();
            for(var i = 0; i<input.Length;i++)
            {
                if (IsPalindrom(input[i]))
                {
                    result.Add(input[i]);
                }
            }
            Console.WriteLine(string.Join(", ", result.Distinct().OrderBy(x=>x)));
        }
        static bool IsPalindrom(string word)
        {
            var reversed = new string(word.Reverse().ToArray());
            return reversed == word;
        }
    }
}
