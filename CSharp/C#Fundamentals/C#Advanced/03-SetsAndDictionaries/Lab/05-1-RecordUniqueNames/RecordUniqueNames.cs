using System;
using System.Collections.Generic;

namespace _05_1_RecordUniqueNames
{
    class RecordUniqueNames
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            int numberOfNames = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfNames; i++)
            {
                names.Add(Console.ReadLine());
            }

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
