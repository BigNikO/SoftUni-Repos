using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4CitiesByContinentAndCountry
{
    class CitiesByContinentAndCountry
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());

            var continents = new Dictionary<string, Dictionary<string, List<String>>>();

            for (int i = 0; i < inputLines; i++)
            {
                string[] currentLine = Console.ReadLine().Split();
                string continent = currentLine[0];
                string country = currentLine[1];
                string city = currentLine[2];
                if (!continents.ContainsKey(currentLine[0]))
                {
                    var countryAndCity = new Dictionary<string, List<string>>();
                    countryAndCity.Add(country, new List<string> { city });
                    continents[continent] = countryAndCity;
                }
                else
                {
                    if (!continents[continent].ContainsKey(country))
                    {
                        continents[continent][country] = new List<string> { city };
                    }
                    else
                    {
                        continents[continent][country].Add(city);

                    }
                }
            }

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {String.Join(", ", country.Value)}");
                }
            }
        }
    }
}
