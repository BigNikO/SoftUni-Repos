using System;
using System.Linq;

namespace Lab1ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(string.Join("",input.Reverse()));
        }
    }
}
