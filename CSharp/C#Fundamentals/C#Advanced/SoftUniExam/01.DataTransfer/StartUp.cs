using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DataTransfer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"^s:(.+);r:(.+);m--""([A-Za-z ]+)""$";
            int dataTransfered = 0;

            List<string> validMatches = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match validMatch = Regex.Match(input, pattern);
                if (validMatch.Success)
                {
                    foreach (Match match in Regex.Matches(validMatch.ToString(),@"[0-9]"))
                    {
                        dataTransfered += int.Parse(match.ToString());
                    }
                    string sender = String.Join("", Regex.Matches(validMatch.Groups[1].Value, @"[A-Za-z ]"));
                    string receiver = String.Join("", Regex.Matches(validMatch.Groups[2].Value, @"[A-Za-z ]"));
                    string message = String.Join("", Regex.Matches(validMatch.Groups[3].Value, @"[A-Za-z ]"));
                    Console.WriteLine($"{sender} says \"{message}\" to {receiver}");
                }
            }
            Console.WriteLine($"Total data transferred: {dataTransfered}MB");
        }
    }
}
