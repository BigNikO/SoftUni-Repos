using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex2PhonebookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            while (true)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                if (command[0] == "END")
                {
                    break;
                }
                else if (command[0] == "A")
                {
                    phonebook[command[1]] = command[2];
                }
                else if (command[0] == "S")
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        Console.WriteLine(command[1] + " -> " + phonebook[command[1]]);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {command[1]} does not exist.");
                    }
                }
                else if (command[0] == "ListAll")
                {
                    foreach (var name in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", name.Key, name.Value);
                    }
                }

            }
        }
    }
}
