
namespace PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static List<Trainer> trainers = new List<Trainer>();
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input!="Tournament")
            {
                var tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);


                AddTrainersPokemon(tokens);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input!="End")
            {
                CheckElement(input);

                input = Console.ReadLine();
            }

            Print();
        }

        private static void Print()
        {
            foreach (var item in trainers.OrderByDescending(x=>x.NumberOfBadges))
            {
                Console.WriteLine($"{item.Name} {item.NumberOfBadges} {item.Pokemons.Count}");
            }
        }

        private static void CheckElement(string element)
        {
            foreach (var item in trainers)
            {
                if (item.Pokemons.Any(x => x.Element == element))
                {
                    item.NumberOfBadges++;
                }
                else
                {
                    foreach (var pokemon in item.Pokemons)
                    {
                        pokemon.Health -= 10;
                    }
                }
            }
            foreach (var item in trainers)
            {
                item.Pokemons.RemoveAll(x => x.Health <= 0);
            }
        }

        private static void AddTrainersPokemon(string[] tokens)
        {
            var trainerName = tokens[0];
            var pokemonName = tokens[1];
            var pokemonElement = tokens[2];
            var pokemonHealth = int.Parse(tokens[3]);

            var trainer = trainers.FirstOrDefault(x => x.Name == trainerName);

            if (trainer == null)
            {
                trainer = new Trainer(trainerName);
                trainers.Add(trainer);
            }
            
            var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

            trainer.Pokemons.Add(pokemon);

        }
    }
}
