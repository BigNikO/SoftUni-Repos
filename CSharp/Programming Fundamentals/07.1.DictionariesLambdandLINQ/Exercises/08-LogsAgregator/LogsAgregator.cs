using System;
using System.Collections.Generic;
using System.Linq;
namespace Ex8LogsAgregator
{
    class LogsAgregator
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> logsAgregator = new SortedDictionary<string, SortedDictionary<string, int>>();
            int numberOfOrders = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfOrders; i++)
            {
                List<string> inputLine = Console.ReadLine().Split(' ').ToList();
                string IP = inputLine[0];
                string name = inputLine[1];
                int logs = int.Parse(inputLine[2]);
                if (!logsAgregator.ContainsKey(name))
                {
                    logsAgregator.Add(name, new SortedDictionary<string, int>());
                }
                if (!logsAgregator[name].ContainsKey(IP))
                {
                    logsAgregator[name][IP] = logs;
                }
                else
                {
                    logsAgregator[name][IP] += logs;
                }                
            }
            foreach (var name in logsAgregator)
            {
                Console.WriteLine($"{name.Key}: {name.Value.Sum(x => x.Value)} [{string.Join(", ", name.Value.Keys)}]");
            }    
        }
    }
}
