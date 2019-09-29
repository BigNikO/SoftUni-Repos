using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex3MinerTasks
{
    class MinerTasks
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictTasks = new Dictionary<string, int>();
            List<string> tasks = new List<string>();
            while (true)
            {
                string task = Console.ReadLine();

                if (task == "stop")
                {
                    break;
                }
                tasks.Add(task);
            }
            for (int i = 0; i < tasks.Count; i += 2)
            {
                if (dictTasks.ContainsKey(tasks[i]))
                {
                    dictTasks[(tasks[i])] += int.Parse(tasks[i + 1]);
                }
                else
                {
                    dictTasks[tasks[i]] = int.Parse(tasks[i + 1]);
                }
                
            }

            foreach (var item in dictTasks)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }

        }
    }
}

