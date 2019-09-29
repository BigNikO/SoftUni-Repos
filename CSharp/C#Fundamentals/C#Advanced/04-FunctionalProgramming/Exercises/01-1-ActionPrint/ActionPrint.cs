using System;
using System.Linq;

namespace Ex1ActionPrint
{
    class ActionPrint
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(' ');
            Action<string> printAction = print;
            foreach (var name in names)
            {
                printAction(name);
            }
        }
        static void print(string name)
        {
            Console.WriteLine(name);
        }
    }
}