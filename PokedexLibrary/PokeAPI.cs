using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexLibrary
{
    public class PokeAPI
    {
        public List<Result> results { get; set; }

        public static async Task<PokemonMethod> LoadPokemon(string url)
        {
            PokemonMethod pokemonData = new PokemonMethod();
            pokemonData = await PokemonProcessor.LoadPokemon(url);

            return pokemonData;
        }

        public static async Task<PokeAPI> LoadAllPokemon(string url)
        {
            PokeAPI allData = new PokeAPI();
            allData = await PokemonProcessor.LoadAllPokemon(url);

            return allData;
        }

        public static string? GetSelectedPokemonData(string pokemon, PokeAPI allPokemon)
        {
            foreach (var item in allPokemon.results)
            { 
                if (item.name == pokemon.ToLower())
                {
                    Debug.WriteLine(item.url);
                    return item.url;
                }
            }
            return null;
        }
    }

    public class Result
    {
        public string name { get; set; }
        public string url { get; set; }
    }


}
