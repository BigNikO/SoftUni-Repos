using System;
using System.Linq;

namespace Lab3TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            string[] forbiddenWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (var forbiddenWord in forbiddenWords)
            {
                string replacement = new string('*', forbiddenWord.Length);
                text = text.Replace(forbiddenWord, replacement);
            }
            Console.WriteLine(text);
        }
    }
}
