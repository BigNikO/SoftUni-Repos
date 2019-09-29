using System;
using System.Text.RegularExpressions;

namespace Lab1MatchFullName
{
    class MatchFullName
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();

            foreach (Match m in Regex.Matches(names, pattern))
            {
                Console.Write(m+" ");
            }

        }
    }
}
