using System;
using System.Text.RegularExpressions;

namespace Ex7HideOut
{
    class HideOut
    {
        static void Main(string[] args)
        {
            string map = Console.ReadLine();
            while (true)
            {
                string[] charCount = Console.ReadLine().Split();
                string hideout = Regex.Escape(charCount[0]);
                int count = int.Parse(charCount[1].ToString());
                string pattern = $@"[{hideout}]+";
                MatchCollection clues = Regex.Matches(map, pattern);
                foreach (Match clue in clues)
                {
                    if (clue.ToString().Length>=count)
                    {
                        Console.WriteLine($"Hideout found at index {clue.Index} and it is with size {clue.Length}!");
                        return;
                    }
                }
            }
        }
    }
}
