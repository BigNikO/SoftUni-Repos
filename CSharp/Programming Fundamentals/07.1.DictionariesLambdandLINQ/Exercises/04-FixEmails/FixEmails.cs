using System;
using System.Collections.Generic;

namespace Ex4FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictEmails = new Dictionary<string, string>();
            List<string> tasks = new List<string>();
            while (true)
            {
                string name = Console.ReadLine();
                string mail = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                else if (!mail.EndsWith(".uk") && !mail.EndsWith(".us"))
                {
                    dictEmails[name] = mail;
                }     
            }
            foreach (var item in dictEmails)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
