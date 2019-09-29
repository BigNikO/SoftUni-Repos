using System;

namespace HelloYou
{
    class HelloYou
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your name");
            var name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}

