using System;
using System.Collections.Generic;
using System.Linq;
namespace Exe11DragonArmy
{
    class DragonArmy
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, List<double>>> dragonDictionary =
                new Dictionary<string, SortedDictionary<string, List<double>>>();
            sbyte numberOfDragons = sbyte.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfDragons; i++)
            {
                List<string> newDragon = Console.ReadLine().Split().ToList();
                string type = newDragon[0];
                string name = newDragon[1];
                if (newDragon[2] == "null")
                {
                    newDragon[2] = "45";
                }
                if (newDragon[3] == "null")
                {
                    newDragon[3] = "250";
                }
                if (newDragon[4] == "null")
                {
                    newDragon[4] = "10";
                }
                double damage = double.Parse(newDragon[2]);
                double health = double.Parse(newDragon[3]);
                double armor = double.Parse(newDragon[4]);
                if (!dragonDictionary.ContainsKey(type))
                {
                    dragonDictionary[type] = new SortedDictionary<string, List<double>>();
                }
                if (!dragonDictionary[type].ContainsKey(name))
                {
                    dragonDictionary[type][name] = new List<double>();
                    dragonDictionary[type][name].Add(0);
                    dragonDictionary[type][name].Add(0);
                    dragonDictionary[type][name].Add(0);
                }
                dragonDictionary[type][name][0] = damage;
                dragonDictionary[type][name][1] = health;
                dragonDictionary[type][name][2] = armor;
            }
            foreach (var dragonStats in dragonDictionary)
            {
                double averageDamage = dragonStats.Value.Select(x => x.Value[0]).Average();
                double averageHealth = dragonStats.Value.Select(x => x.Value[1]).Average();
                double averageArmor = dragonStats.Value.Select(x => x.Value[2]).Average();
                Console.WriteLine($"{dragonStats.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");
                foreach (var dragon in dragonStats.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}
