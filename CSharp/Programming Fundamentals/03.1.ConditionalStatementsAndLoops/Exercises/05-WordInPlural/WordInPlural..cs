namespace Ex5WordInPlural
{
    using System;
    class WordInPlural
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            bool checkES = word.EndsWith("ch") || word.EndsWith("o") || word.EndsWith("s")
            || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z");
            bool checkY = word.EndsWith("y");
            if (checkES)
            {
                Console.WriteLine($"{word}es");
            }
            else if (checkY)
            {
                Console.WriteLine($"{word.Remove(word.Length-1)}ies");
            }
            else
            {
                Console.WriteLine($"{word}s");
            }
        }
    }
}
