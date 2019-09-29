using System;

namespace Lab6TriplesOfLatinLatters
{
    class TriplesOfLatinLatters
    {
        static void Main(string[] args)
        {
            char firstLetter = 'a';
            char lastLetter = 'a';
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                lastLetter++;
            }
            for (char i = firstLetter; i <= lastLetter; i++)
            {
                for (char j = firstLetter; j <= lastLetter; j++)
                {
                    for (char k = firstLetter; k <= lastLetter; k++)
                    {
                        Console.WriteLine($"{i}{j}{k} ");
                    }
                }
            }
        }
    }
}
