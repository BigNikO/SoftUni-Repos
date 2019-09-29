using System;
using System.Text.RegularExpressions;

namespace Lab5MatchNumbers
{
    class MatchNumbers
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            string text = Console.ReadLine();
            MatchCollection numbers = Regex.Matches(text, pattern);
            Console.WriteLine(String.Join(", ",numbers));
        }
    }
}
