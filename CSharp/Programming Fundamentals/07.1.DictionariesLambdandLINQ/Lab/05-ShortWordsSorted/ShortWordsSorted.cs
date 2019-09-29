using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .ToLower()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Console.WriteLine(string.Join(", ", words
                .Where(w => w.Length<5)
                .OrderBy(w => w)
                .Distinct()));
        }
    }
}
