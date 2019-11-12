
namespace PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            string inputLines;

            while ((inputLines = Console.ReadLine()) != "Tournament")
            {
                string trainerName = inputLines.Split()[0];
                string pokemonName = inputLines.Split()[1];
                string pokemonElement = inputLines.Split()[2];
                int pokemonHealth = int.Parse(inputLines.Split()[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName] = new Trainer();
                }

                trainers[trainerName].AddPokemon(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
            }

            while ((inputLines = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers.Values)
                {
                    trainer.CurrentCommand(inputLines);
                }
            }
            foreach (var trainer in trainers.OrderByDescending(t => t.Value.Badges))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.Badges} {trainer.Value.NumberOfPokemons}");
            }
        }
    }
}
