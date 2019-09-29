using System;

namespace Ex2KnightsForHonoe
{
    class KnightsForHonor
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Action<string> appendAndPrintAction = append;
            foreach (var name in names)
            {
                appendAndPrintAction(name);
            }
        }
        static void append(string name)
        {
            name = "Sir " + name;
            Console.WriteLine(name);
        }
    }
}