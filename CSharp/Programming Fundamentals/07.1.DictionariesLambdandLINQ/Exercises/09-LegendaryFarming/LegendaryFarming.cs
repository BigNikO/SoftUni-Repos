using System;
using System.Collections.Generic;
using System.Linq;
namespace Ex9LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> items = new SortedDictionary<string, int>();
            SortedDictionary<string, int> junks = new SortedDictionary<string, int>();
            string material = "";
            items.Add("fragments", 0);
            items.Add("motes", 0);
            items.Add("shards", 0);
            bool check = true;
            while (check)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                string item = "";
                int quantity = 0;
                for (int i = 0; i < input.Count; i += 2)
                {
                    item = input[i + 1].ToLower();
                    quantity = int.Parse(input[i]);
                    if (item == "fragments" || item == "motes" || item == "shards")
                    {
                        items[item] += quantity;
                        if (items[item] >= 250)
                        {
                            items[item] -= 250;
                            material = item;
                            check = false;
                            break;
                        }
                    }
                    else if (junks.ContainsKey(item))
                    {
                        junks[item] += quantity;
                    }
                    else
                    {
                        junks[item] = quantity;
                    }
                }
            }
            if (material == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (material == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else if (material == "motes")
            {
                Console.WriteLine("Dragonwrath obtained!");
            }
            foreach (var item in items.OrderByDescending(x => x.Value))
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            foreach (var junk in junks)
            {
                Console.WriteLine(junk.Key + ": " + junk.Value);
            }
        }
    }
}
