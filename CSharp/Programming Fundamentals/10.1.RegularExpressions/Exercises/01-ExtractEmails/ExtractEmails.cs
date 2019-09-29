using System;
using System.Text.RegularExpressions;

namespace Ex1ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s)[a-z0-9]+([-._]\w+)*@{1}[a-z]+([-.]\w*)*(\.[a-z]+)";
            string text = Console.ReadLine();
            foreach (Match email in Regex.Matches(text,pattern))
            {
                Console.WriteLine(email);
            }
        }
    }
}
