using System;

namespace Ex6StringAndObjects
{
    class StringAndObjects
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            Console.WriteLine(helloWorld);
        }
    }
}
