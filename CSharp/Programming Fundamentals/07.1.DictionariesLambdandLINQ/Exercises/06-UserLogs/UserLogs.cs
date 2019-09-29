using System;
using System.Collections.Generic;
using System.Linq;
namespace Ex6UserLogs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> userLogs = new SortedDictionary<string, Dictionary<string, int>>();
            while (true)
            {
                List<string> input = Console.ReadLine().Split(" ").ToList();
                if (input[0] == "end")
                {
                    break;
                }
                input.RemoveAt(1);
                List<string> IP = input[0].Split("IP=", StringSplitOptions.RemoveEmptyEntries).ToList();
                List<string> user = input[1].Split("user=", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (!userLogs.ContainsKey(user[0]))
                {
                    userLogs.Add(user[0], new Dictionary<string, int>());
                }
                if (!userLogs[user[0]].ContainsKey(IP[0]))
                {
                    userLogs[user[0]].Add(IP[0], 0);
                }
                userLogs[user[0]][IP[0]] += 1;
            }
            var orderedUsers = userLogs.OrderBy(x => x.Key).ToList();
            foreach (var item in orderedUsers)
            {
                Console.WriteLine(item.Key + ": ");
                int counter = 1;
                foreach (var IPCounts in item.Value)
                {                    
                    if (counter==item.Value.Count)
                    {
                        Console.WriteLine(IPCounts.Key + " => " + IPCounts.Value + ".");
                        break;
                    }
                    Console.Write(IPCounts.Key + " => " + IPCounts.Value + ", ");
                    counter++;
                }
            }           
        }
    }
}
