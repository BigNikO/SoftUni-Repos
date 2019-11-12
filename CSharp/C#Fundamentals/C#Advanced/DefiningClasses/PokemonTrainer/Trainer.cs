
namespace PokemonTrainer
{
    using System.Collections.Generic;
    using System.Linq;

    public class Trainer
    {

        public Trainer()
        {
            Badges = 0;
            pokemon = new List<Pokemon>();
        }
        public int Badges { get; set; }

        private List<Pokemon> pokemon;

        public int NumberOfPokemons => pokemon.Count;

        public void AddPokemon(Pokemon pokemon)
        {
            this.pokemon.Add(pokemon);
        }

        public void CurrentCommand(string element)
        {
            if (pokemon.Any(x => x.Element == element))
            {
                this.Badges++;
            }
            else
            {
                pokemon.RemoveAll(p => (p.Health -= 10) <= 0);
            }
        }
    }
}