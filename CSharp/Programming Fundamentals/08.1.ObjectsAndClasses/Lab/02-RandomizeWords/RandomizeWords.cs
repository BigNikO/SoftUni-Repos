using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            for (int i = 0; i < words.Count; i++)
            {
                Random random = new Random();
                int index = random.Next(0, words.Count);
                string word = words[i];
                words[i] = words[index];
                words[index] = word;
            }
            Console.WriteLine(string.Join(Environment.NewLine,words));
        }
    }
}
