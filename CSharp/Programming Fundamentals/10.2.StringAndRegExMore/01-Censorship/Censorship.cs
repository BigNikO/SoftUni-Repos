using System;

namespace Ex1Censorship
{
    class Censorship
    {
        static void Main(string[] args)
        {
            string censoredWord = Console.ReadLine();
            string text = Console.ReadLine();
            string replacement = new string('*', censoredWord.Length);
            text = text.Replace(censoredWord, replacement);
            Console.WriteLine(text);
        }
    }
}
