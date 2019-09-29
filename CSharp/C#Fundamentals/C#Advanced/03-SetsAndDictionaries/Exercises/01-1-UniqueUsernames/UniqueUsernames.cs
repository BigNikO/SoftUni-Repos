using System;
using System.Collections.Generic;

namespace Ex1UniqueUsernames
{
    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            int usernamesCount = int.Parse(Console.ReadLine());
            HashSet<string> uniqueUsernames = new HashSet<string>();

            for (int userName = 0; userName < usernamesCount; userName++)
            {
                string currentUsername = Console.ReadLine();
                uniqueUsernames.Add(currentUsername);
            }
            Console.WriteLine(String.Join(Environment.NewLine, uniqueUsernames));
        }      
    }
}
