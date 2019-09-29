using System;

namespace Ex3UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            foreach (var digit in input)
            {
                Console.Write($"\\u{((int)digit).ToString("x4")}");
            }
        }
    }
}
