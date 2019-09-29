using System;
using System.Linq;

namespace Ex4FindEvensOrOdds
{
    class FindEvensOrOdds
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = number => number % 2 == 0;
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var command = Console.ReadLine();
            for (int i = input[0]; i <= input[1]; i++)
            {
                if (command == "even" && isEven(i))
                {
                    Console.Write(i + " ");
                }
                else if(command == "odd" && !isEven(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}