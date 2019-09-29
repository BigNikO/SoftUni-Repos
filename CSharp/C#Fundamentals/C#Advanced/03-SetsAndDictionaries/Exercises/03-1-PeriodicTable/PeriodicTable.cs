using System;
using System.Collections.Generic;

namespace Ex3PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            int elementsCount = int.Parse(Console.ReadLine());
            SortedSet<string> compounds = new SortedSet<string>();

            for (int i = 0; i < elementsCount; i++)
            {
                string[] currentCompounds = Console.ReadLine().Split(" ");
                foreach (string compound in currentCompounds)
                {
                    compounds.Add(compound);
                }
            }
            Console.WriteLine(String.Join(" ",compounds));   
        }
    }
}
