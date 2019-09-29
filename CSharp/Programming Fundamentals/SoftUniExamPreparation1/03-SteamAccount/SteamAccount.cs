using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex3SteamAccount
{
    class SteamAccount
    {
        static void Main(string[] args)
        {
            List<string> games = Console.ReadLine().Split().ToList();
            while (true)
            {
                string[] commandGame = Console.ReadLine().Split();
                if (commandGame[0] == "Play!")
                {
                    break;
                }
                else if (commandGame[0] == "Install")
                {
                    if (!games.Contains(commandGame[1]))
                    {
                        games.Add(commandGame[1]);
                    }
                }
                else if (commandGame[0] == "Uninstall")
                {
                    if (games.Contains(commandGame[1]))
                    {
                        games.Remove(commandGame[1]);
                    }
                }
                else if (commandGame[0] == "Update")
                {
                    if (games.Contains(commandGame[1]))
                    {
                        games.Remove(commandGame[1]);
                        games.Add(commandGame[1]);
                    }
                }
                else if(commandGame[0]=="Expansion")
                {
                    string[] expansionGame = commandGame[1].Split('-');
                    if (games.Contains(expansionGame[0])&&!(games.Contains(expansionGame[0] + ":" + expansionGame[1])))
                    {
                        expansionGame[1] = expansionGame[0] + ":" + expansionGame[1];
                        if (games.IndexOf(expansionGame[0])+1<games.Count)
                        {
                            games.Insert(games.IndexOf(expansionGame[0])+1, expansionGame[1]);
                        }
                        else
                        {
                            games.Add(expansionGame[1]);
                        }
                        
                    }
                }
            }
            Console.WriteLine(string.Join(" ", games));
        }
    }
}
