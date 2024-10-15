using CommunityToolkit.HighPerformance;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokedexLibrary
{

    public class PokemonMethod
    {
        public Ability[]? abilities { get; set; }

        public int? id { get; set; }

        public string? name { get; set; }

        public int order { get; set; }

        public Sprites? sprites { get; set; }

        public Stat[]? stats { get; set; }

        public Type[]? types { get; set; }

        public List<string> TypeEffectiviness(PokemonTypes.Effectiveness effect)
        {
            SortedDictionary<string, int> typesMap =
            new SortedDictionary<string, int> {{"normal", 0}, {"fire", 1}, {"water", 2}, {"electric", 3}, {"grass", 4}, {"ice", 5},
        {"fighting", 6}, {"poison", 7}, {"ground", 8}, {"flying", 9}, {"psychic", 10}, {"bug", 11}, {"rock", 12}, {"ghost", 13},
        {"dragon", 14}, {"dark", 15}, {"steel", 16}, {"fairy", 17}};

            double[,] effectivesness = {
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0.5, 0, 1, 1, 0.5, 1},
        {1, 0.5, 0.5, 1, 2, 2, 1, 1, 1, 1, 1, 2, 0.5, 1, 0.5, 1, 2, 1},
        {1, 2, 0.5, 1, 0.5, 1, 1, 1, 2, 1, 1, 1, 2, 1, 0.5, 1, 1, 1},
        {1, 1, 2, 0.5, 0.5, 1, 1, 1, 0, 2, 1, 1, 1, 1, 0.5, 1, 1, 1},
        {1, 0.5, 2, 1, 0.5, 1, 1, 0.5, 2, 0.5, 1, 0.5, 2, 1, 0.5, 1, 0.5, 1},
        {1, 0.5, 0.5, 1, 2, 0.5, 1, 1, 2, 2, 1, 1, 1, 1, 2, 1, 0.5, 1},
        {2, 1, 1, 1, 1, 2, 1, 0.5, 1, 0.5, 0.5, 0.5, 2, 0, 1, 2, 2, 0.5},
        {1, 1, 1, 1, 2, 1, 1, 0.5, 0.5, 1, 1, 1, 0.5, 0.5, 1, 1, 0, 2},
        {1, 2, 1, 2, 0.5, 1, 1, 2, 1, 0, 1, 0.5, 2, 1, 1, 1, 2, 1},
        {1, 1, 1, 0.5, 2, 1, 2, 1, 1, 1, 1, 2, 0.5, 1, 1, 1, 0.5, 1},
        {1, 1, 1, 1, 1, 1, 2, 2, 1, 1, 0.5, 1, 1, 1, 1, 0, 0.5, 1},
        {1, 0.5, 1, 1, 2, 1, 0.5, 0.5, 1, 0.5, 2, 1, 1, 0.5, 1, 2, 0.5, 0.5},
        {1, 2, 1, 1, 1, 2, 0.5, 1, 0.5, 2, 1, 2, 1, 1, 1, 1, 0.5, 1},
        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 2, 1, 0.5, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 0.5, 0},
        {1, 1, 1, 1, 1, 1, 0.5, 1, 1, 1, 2, 1, 1, 2, 1, 0.5, 1, 0.5},
        {1, 0.5, 0.5, 0.5, 1, 2, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 0.5, 2},
        {1, 0.5, 1, 1, 1, 1, 2, 0.5, 1, 1, 1, 1, 1, 1, 2, 2, 0.5, 1}};

            int typeMapValue;
            List<double> type1 = new List<double>();
            List<double> type2 = new List<double>();
            List<double> result = new List<double>();
            List<string> finalEffective = new List<string>();
            int count = 0;


            Span2D<double> span2D = new Span2D<double>(effectivesness);

            if (types.Length == 2)
            {
                foreach (var item in types)
                {
                    typesMap.TryGetValue(item.type.name.ToLower(), out typeMapValue);
                    if (count == 0)
                    {
                        foreach (var value in span2D.GetColumn(typeMapValue))
                        {
                            type1.Add(value);
                        }
                    }
                    else
                    {
                        foreach (var value in span2D.GetColumn(typeMapValue))
                        {
                            type2.Add(value);
                        }

                    }
                    count++;
                }
                result = Toolbox.ListMultiplication(type1, type2);
            }
            else
            {
                typesMap.TryGetValue(types[0].type.name.ToLower(), out typeMapValue);
                foreach (var item in span2D.GetColumn(typeMapValue))
                {
                    result.Add((double)item);
                }
            }

            if (effect == PokemonTypes.Effectiveness.Weakness)
            {
                finalEffective = PokemonTypes.GetWeaknesses(result);
            }
            else if (effect == PokemonTypes.Effectiveness.Resistence)
            {
                finalEffective = PokemonTypes.GetResistance(result);
            } else if (effect == PokemonTypes.Effectiveness.Immunity)
            {
                finalEffective = PokemonTypes.GetImmunity(result);
            }

            return finalEffective;

        }
    }

    public class Sprites
    {
        public string? front_default { get; set; }
        public Other? other { get; set; }
    }

    public class Home
    {
        public string? front_default { get; set; }
    }

    public class Other
    {
        public Home? home { get; set; }

    }

    public class Ability
    {
        public Ability1? ability { get; set; }

        public bool? is_hidden { get; set; }

        public int? slot { get; set; }
    }

    public class Ability1
    {
        public string? name { get; set; }
        public string? url { get; set; }
    }

    public class Stat
    {
        public int base_stat { get; set; }
        public int? effort { get; set; }
        public Stat1 stat { get; set; }
    }

    public class Stat1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Type
    {
        public int slot { get; set; }
        public Type1 type { get; set; }
    }

    public class Type1
    {
        public string name { get; set; }
        public string? url { get; set; }
    }
}
