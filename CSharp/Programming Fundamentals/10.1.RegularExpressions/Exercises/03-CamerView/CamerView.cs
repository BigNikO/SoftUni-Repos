using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ex3CamerView
{
    class CamerView
    {
        static void Main(string[] args)
        {
            string skipTake = Console.ReadLine();
            int skip = int.Parse(skipTake.Split()[0]);
            int take = int.Parse(skipTake.Split()[1]);
            string pattern = @"\|<\b\w{" + skip + @"}(\w{0," + take + @"})";           
            string text = Console.ReadLine();
            MatchCollection matches = Regex.Matches(text, pattern);
            Console.WriteLine(string.Join(", ", matches.Select(x => x.Groups[1].Value)));
        }
    }
}
