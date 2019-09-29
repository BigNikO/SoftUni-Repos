using System;
using System.Collections.Generic;

namespace Ex6Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int numberOfColours = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfColours; i++)
            {
                string[] colorClothes = Console.ReadLine().Split(" -> ");
                string color = colorClothes[0];
                string[] clothes = colorClothes[1].Split(',');
                Dictionary<string, int> clothesCounts = new Dictionary<string, int>();

                if (!wardrobe.ContainsKey(color))
                {
                    foreach (var item in clothes)
                    {
                        if (!clothesCounts.ContainsKey(item))
                        {
                            clothesCounts[item] = 1;
                        }
                        else
                        {
                            clothesCounts[item]++;
                        }
                    }
                    wardrobe.Add(color, clothesCounts);
                }
                else
                {
                    foreach (var item in clothes)
                    {
                        if (!wardrobe[color].ContainsKey(item))
                        {
                            wardrobe[color][item] = 1;
                        }
                        else
                        {
                            wardrobe[color][item]++;
                        }
                    }
                }
            }
            string[] neededColorItem = Console.ReadLine().Split(' ');
            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var item in color.Value)
                {
                    if (neededColorItem[0] == color.Key && neededColorItem[1] == item.Key)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
