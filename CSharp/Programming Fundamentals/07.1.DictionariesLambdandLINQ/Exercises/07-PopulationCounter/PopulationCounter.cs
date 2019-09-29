using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex7PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> checkPopulation = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                List<string> inputLine = Console.ReadLine().Split('|').ToList();
                if (inputLine[0] == "report") break;
                string city = inputLine[0];
                string country = inputLine[1];
                long population = long.Parse(inputLine[2]);
                if (!checkPopulation.ContainsKey(country))
                {
                    checkPopulation.Add(country, new Dictionary<string, long>());
                }
                checkPopulation[country][city] = population;
            }
            foreach (var state in checkPopulation.OrderByDescending(x => x.Value.Sum(y => y.Value)))
                // Извиквам две функции. Втората функция е вложена в първата. Функцията за сумиране на населението на градовете за съответна държава.
                // След това функция за подреждане в обратен ред на сумираното население.
            {
                List<long> sumOfTowns = state.Value.Select(x => x.Value).ToList();

                Console.WriteLine("{0} (total population: {1})", state.Key, sumOfTowns.Sum());

                foreach (var town in state.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("=>{0}: {1}", town.Key, town.Value);
                }
            }
        }
    }
}
