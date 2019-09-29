using System;
using System.Text.RegularExpressions;

namespace Lab2matchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |\-)2(\1)[0-9]{3}(\1)[0-9]{4}\b";
            string phones = Console.ReadLine();
            MatchCollection phoneMatches = Regex.Matches(phones, pattern);
            Console.WriteLine(string.Join(", ",phoneMatches));
        }
    }
}
