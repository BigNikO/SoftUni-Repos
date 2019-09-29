using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ex3WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            var words = new Dictionary<string, int>();
            string inputPath = "../../../../InputFiles";
            string wordsPath = "../../../../InputFiles";
            string outputPath = "../../../../Outputfiles";
            string fileName = "text.txt";
            string wordsFile = "words.txt";
            string outputFile = "result.txt";
            inputPath = Path.Combine(inputPath, fileName);
            outputPath = Path.Combine(outputPath, outputFile);
            wordsPath = Path.Combine(wordsPath, wordsFile);

            using (var reader = new StreamReader(wordsPath))
            {
                string word;
                while ((word = reader.ReadLine()) != null)
                {
                    words[word] = 0;
                }
            }

            using (var reader = new StreamReader(inputPath))
            {
                string data = reader.ReadToEnd();

                foreach (Match match in Regex.Matches(data, @"\w+"))
                {
                    string word = match.Value.ToLower();
                    if (words.ContainsKey(word))
                    {
                        words[word]++;
                    }
                }
            }

            using (var writer = new StreamWriter(outputPath))
            {
                foreach (var word in words.OrderByDescending(word => word.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
