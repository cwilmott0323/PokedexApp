using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PokedexLibrary
{
    public static class PokemonProcessor
    {
        public static async Task<PokemonMethod> LoadPokemon(string pokemonLink)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(pokemonLink))
            {
                if (response.IsSuccessStatusCode)
                {
                    PokemonMethod root = await response.Content.ReadAsAsync<PokemonMethod>();
                    return root;
                } else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<PokeAPI> LoadAllPokemon(string pokemonLink)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(pokemonLink))
            {
                if (response.IsSuccessStatusCode)
                {
                    PokeAPI root = await response.Content.ReadAsAsync<PokeAPI>();
                    return root;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
