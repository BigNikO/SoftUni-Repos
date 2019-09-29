using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ex4PunctuationFinder
{
    class PunctuationFinder
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("sample_text.txt");
            List<char> result = text.ToCharArray().Where(c => new char[] { '.', ',', '!', '?', ':' }.Contains(c)).ToList();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
