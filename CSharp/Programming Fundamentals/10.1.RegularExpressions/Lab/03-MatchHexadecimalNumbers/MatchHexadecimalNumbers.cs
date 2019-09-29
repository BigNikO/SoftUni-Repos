using System;
using System.Text.RegularExpressions;

namespace Lab3matchHexadecimalNumbers
{
    class MatchHexadecimalNumbers
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(0x)?[0-9A-F]+\b";
            //if there is 0x in the text, then catch it with the other part of the text, else, catch only the other part of the text.
            string input=Console.ReadLine();
            MatchCollection numbers = Regex.Matches(input, pattern);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
