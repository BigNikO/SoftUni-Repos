using System;
using System.Text.RegularExpressions;
namespace Lab4MatchDates
{
    class MatchDates
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>[0-9]{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";
            // When we name groups, the first unnamed group, becomes Group 1;
            // a way for naming groups - ?<name> - Now the goup has the name: "name"
            // we can repeat a condition using in a previuos group, by caling the group by name or by number.(/name;/1, etc.)

            string input = Console.ReadLine();
            var dates = Regex.Matches(input, pattern);
            foreach (Match date in dates)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
