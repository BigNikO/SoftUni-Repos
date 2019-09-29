using System;

namespace Exe17PrintpartASCII
{
    class PrintpartASCII
    {
        static void Main(string[] args)
        {
            byte startNumber = byte.Parse(Console.ReadLine());
            byte endNumber = byte.Parse(Console.ReadLine());
            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
