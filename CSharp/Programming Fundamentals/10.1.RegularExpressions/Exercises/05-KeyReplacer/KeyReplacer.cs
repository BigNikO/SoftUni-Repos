using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace Ex5KeyReplacer
{
    class KeyReplacer
    {
        static void Main(string[] args)
        {
            string mainPattern = @"^([A-z]+)[<\|\\](.*)+[<\|\\]([A-z]+)$";
            string startEnd = Console.ReadLine();
            Match startEndMatch = Regex.Match(startEnd, mainPattern);
            string textPattern = $@"{startEndMatch.Groups[1]}(.*?){startEndMatch.Groups[3]}";
            string text = Console.ReadLine();
            MatchCollection textMatches = Regex.Matches(text, textPattern);
            string result = string.Join(null, textMatches.Select(x=>x.Groups[1]));
            if (result==string.Empty)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(result);
            }       
        }
    }
}
