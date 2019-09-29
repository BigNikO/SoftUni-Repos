using System;
using System.Linq;

namespace Ex1HelloName
{
    class HelloName
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            string name = Console.ReadLine();
            NameMethod(name);
        }
        static void NameMethod(string name)
        {
            Console.WriteLine($"Hello, {name}!");          
        }
       
    }
}
