using System;
using System.Text.RegularExpressions;

namespace Ex2ExtractSentancesByKeyWord
{
    class ExtractSentancesByKeyWord
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string pattern = $@"\b({word})\b";
            string[] text = Console.ReadLine().Split(new[] { '.', '?', '!' });

            foreach (var sentence in text)
            {
                Match match = Regex.Match(sentence, pattern);
                if (match.Success)
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
