using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab7SoftUniParty
{
    class SoftUniParty
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();
            string input = "";

            while ((input = Console.ReadLine()) != "PARTY")
            {
                guests.Add(input);
            } while ((input = Console.ReadLine()) != "END")
            {
                guests.Remove(input);
            }
            Console.WriteLine(guests.Count);
            Console.WriteLine(String.Join(Environment.NewLine, guests.OrderByDescending(x => Char.IsDigit(x[0]))));
        }
    }
}
