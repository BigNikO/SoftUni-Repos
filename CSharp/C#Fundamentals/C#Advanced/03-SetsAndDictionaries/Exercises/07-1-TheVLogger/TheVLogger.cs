using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex7TheVLogger
{
    class VLoggerStats
    {
        public SortedSet<string> followers = new SortedSet<string>();
        public HashSet<string> following = new HashSet<string>();

    }
    class TheVLogger
    {
        static void Main(string[] args)
        {
            var vLoggers = new Dictionary<string, VLoggerStats>();
            string input;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string command = input.Split(" ")[1];
                string vLogger = input.Split(" ")[0];
                if (command == "joined")
                {
                    var vLoggerStats = new VLoggerStats();
                    if (!vLoggers.ContainsKey(vLogger))
                    {
                        vLoggers[vLogger] = vLoggerStats;
                    }
                }
                else if (vLoggers.ContainsKey(input.Split(' ')[2]) 
                    && (input.Split(' ')[2]!=input.Split(' ')[0])
                    && vLoggers.ContainsKey(vLogger))
                {
                    var follower = input.Split(' ')[2];                  
                    vLoggers[follower].followers.Add(vLogger);
                    vLoggers[vLogger].following.Add(follower);
                }
            }
            int counter = 1;
            Console.WriteLine($"The V-Logger has a total of {vLoggers.Count} vloggers in its logs.");
            foreach (var vLogger in vLoggers.OrderByDescending(x => x.Value.followers.Count).ThenBy(x=>x.Value.following.Count))
            {
                Console.WriteLine($"{counter}. {vLogger.Key} : {vLogger.Value.followers.Count} followers, {vLogger.Value.following.Count} following");  
                if (counter==1 && vLogger.Value.followers.Count>0)
                {
                    Console.Write("*  ");
                    Console.WriteLine(String.Join(Environment.NewLine + "*  " ,vLogger.Value.followers));
                   
                }
                ++counter;
            }
        }
    }
}
