using System;
using System.Collections.Generic;
using System.Linq;
namespace Exe10SerbianUnleashed
{
    class SerbianUnleashed
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> entertainment = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                List<string> input = Console.ReadLine().Split(" @").ToList();              
                if (input[0] == "End") break;
                try
                {
                    List<string> placeAndPrice = input[1].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                    long price = long.Parse(placeAndPrice[placeAndPrice.Count - 1]) * long.Parse(placeAndPrice[placeAndPrice.Count - 2]);
                    string place = null;
                    string singer = input[0].Trim();
                    for (int i = 0; i < placeAndPrice.Count - 2; i++)
                    {
                        place += placeAndPrice[i] + " ";
                    }
                    place.TrimEnd();
                    if (!entertainment.ContainsKey(place))
                    {
                        entertainment.Add(place, new Dictionary<string, long>());
                    }
                    if (!entertainment[place].ContainsKey(singer))
                    {
                        entertainment[place][singer] = price;
                    }
                    else entertainment[place][singer] += price;
                }
                catch { }
            }
            foreach (var places in entertainment)
            {
                Console.WriteLine(places.Key);
                foreach (var concert in places.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {concert.Key} -> {concert.Value}");
                }
            }
        }
    }
}



