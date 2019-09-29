using System;
using System.Linq;

namespace Ex5MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            char[] wordOne = words[0].Distinct().ToArray();
            char[] wordTwo = words[1].Distinct().ToArray();
            if (wordOne.Length == wordTwo.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");

            }

        }
    }
}
