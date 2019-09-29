using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Ex8Mines
{
    class Mines
    {
        static void Main(string[] args)
        {
            string blastPattern = @"<.{2}>";
            string text = Console.ReadLine();
            MatchCollection blasts = Regex.Matches(text, blastPattern);
            List<string> finalText = Regex.Split(text, blastPattern).ToList();
            int count = 0;
            int checkLenght = Regex.Match(text, blastPattern).Groups[1].Length;
            foreach (Match blast in blasts)
            {
                string mine = blast.ToString();
                int leftBlast = Math.Abs(mine[1] - mine[2]);
                int rightBlast = Math.Abs(mine[1] - mine[2]);
                string leftText = finalText[count];
                string rightText = finalText[count + 1];
                if (leftBlast > leftText.Length)
                {
                    leftBlast = leftText.Length;
                }
                if (rightBlast > rightText.Length)
                {
                    rightBlast = rightText.Length;
                }
                finalText[count] = leftText.Substring(0,leftText.Length-leftBlast) + new string('_', leftBlast);
                finalText[count + 1] = new string('_', rightBlast) + rightText.Substring(rightBlast);
                count++;
            }
            Console.WriteLine(string.Join("____", finalText));
        }
    }
}
