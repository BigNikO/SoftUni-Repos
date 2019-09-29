using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace Ex8UseYourChainsBuddy
{
    class UseYourChainsBuddy
    {
        static void Main(string[] args)
        {
            string tagPattern = @"<p>(.*?)<\/p>";
            string patternToReplace = @"[^a-z0-9]+";
            string htmlText = Console.ReadLine();
            MatchCollection tags = Regex.Matches(htmlText, tagPattern);
            string tagText = "";
            foreach (Match tag in tags)
            {
                tagText += Regex.Replace(tag.Groups[1].Value, patternToReplace, " ");
            }
            char[] textArray = new char[tagText.Length];
            for (int i = 0; i < tagText.Length; i++)
            {
                if ((tagText[i] != ' ')&&!char.IsDigit(tagText[i]))
                {
                    if (tagText[i] <= 'm')
                    {
                        textArray[i] = (char)(tagText[i] + 13);
                    }
                    else
                    {
                        textArray[i] = (char)(tagText[i] - 13);

                    }
                }
                else
                {
                    textArray[i] = tagText[i];
                }
            }
            tagText = string.Join(null, textArray.Select(x => x));
            Console.WriteLine(tagText);
        }
    }
}
