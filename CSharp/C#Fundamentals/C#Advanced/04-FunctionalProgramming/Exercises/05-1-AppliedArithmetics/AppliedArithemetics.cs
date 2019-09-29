using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex5AppliedArithmetics
{
    class AppliedArithemetics
    {
        static void Main(string[] args)
        {
            Func<List<int>, List<int>> add = numbers => numbers = numbers.Select(number => number = ++number).ToList();
            Func<List<int>, List<int>> multiply = numbers => numbers = numbers.Select(number => number = number * 2).ToList();
            Func<List<int>, List<int>> subtract = numbers => numbers = numbers.Select(number => number = --number).ToList();
            Action<List<int>> print = numbers => Console.WriteLine(String.Join(" ", numbers));

            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "add")
                { 
                    input = add(input);
                }
                else if (command == "multiply")
                {
                    input = multiply(input);
                }
                else if(command=="subtract")
                {
                    input = subtract(input);
                }
                else
                {
                    print(input);

                }
                command = Console.ReadLine();
            }
        }
    }
}