using System;

namespace Ex9ReverseChars
{
    class ReverseChars
    {
        static void Main(string[] args)
        {
            char letterOne = char.Parse(Console.ReadLine());
            char letterTwo = char.Parse(Console.ReadLine());
            char letterThree = char.Parse(Console.ReadLine());
            Console.WriteLine($"{letterThree}{letterTwo}{letterOne}");
        }
    }
}
