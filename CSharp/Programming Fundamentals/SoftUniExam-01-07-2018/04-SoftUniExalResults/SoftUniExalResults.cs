using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex4SoftUniExalResults
{
    class SoftUniExalResults
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> usersAndPoints = new Dictionary<string, int>();
            Dictionary<string, int> languages = new Dictionary<string, int>();
            while (true)
            {
               string input =  Console.ReadLine();
                if (input== "exam finished")
                {
                    break;
                }
                string[] user = input.Split("-");
                if (input.Contains("-banned"))
                {
                    if (usersAndPoints.ContainsKey(user[0]))
                    {
                        usersAndPoints.Remove(user[0]);
                    }
                }
                else
                {
                    if (!usersAndPoints.ContainsKey(user[0]))
                    {
                        usersAndPoints[user[0]] = int.Parse(user[2]);
                        if (!languages.ContainsKey(user[1]))
                        {
                            languages[user[1]] = 1;
                        }
                        else
                        {
                            languages[user[1]] ++;
                        }
                    }
                    else
                    {
                        if (usersAndPoints[user[0]]<int.Parse(user[2]))
                        {
                            usersAndPoints[user[0]] = int.Parse(user[2]);                          
                        }
                        if (!languages.ContainsKey(user[1]))
                        {
                            languages[user[1]] = 1;
                        }
                        else
                        {
                            languages[user[1]]++;
                        }
                    }
                }
            }
            Console.WriteLine("Results:");
            foreach (var user in usersAndPoints.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine(user.Key + " | " + user.Value);
            }
            Console.WriteLine("Submissions:");
            foreach (var submition in languages.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine(submition.Key+" - "+submition.Value);
            }
        }
    }
}
