using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex3SearchForANumber
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] theArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int removal = 0;
            while (theArray[1] > 0)
            {
                numbers.RemoveAt(removal);
                theArray[1]--;
                theArray[0]--;
            }
            for (int i = 0; i < theArray[0]; i++)
            {
                if (theArray[2]==numbers[i])
                {
                    Console.WriteLine("YES!");
                    return;
                }
            }
            Console.WriteLine("NO!");
        }
    }
}
