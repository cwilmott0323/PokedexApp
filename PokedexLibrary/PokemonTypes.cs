using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexLibrary
{
    public class PokemonTypes
    {
        enum Types
        {
            Normal,
            Fire,
            Water,
            Electric,
            Grass,
            Ice,
            Fighting,
            Poison,
            Ground,
            Flying,
            Psychic,
            Bug,
            Rock,
            Ghost,
            Dragon,
            Dark,
            Steel,
            Fairy
        }

        public enum Effectiveness
        {
            Weakness,
            Resistence,
            Immunity
        }

        public static List<string> GetWeaknesses(List<double> damage)
        {
            int count = 0; 
            List<string> weaknesses = new List<string>();
            foreach (var item in damage)
            {
                if (item == 2)
                {
                    Types typeName = (Types)count;
                    weaknesses.Add($"{typeName.ToString()} - x2");
                }
                else if (item == 4)
                {
                    Types typeName = (Types)count;
                    weaknesses.Add($"{typeName.ToString()} - x4");
                }
                count++;
            }
            return weaknesses;
        }

        public static List<string> GetImmunity(List<double> damage)
        {
            int count = 0;
            List<string> immunity = new List<string>();
            foreach (var item in damage)
            {
                if (item == 0)
                {
                    Types typeName = (Types)count;
                    immunity.Add(typeName.ToString());
                }
                count++;
            }
            return immunity;
        }

        public static List<string> GetResistance(List<double> damage)
        {
            int count = 0;
            List<string> resistance = new List<string>();
            foreach (var item in damage)
            {
                if (item == 0.5)
                {
                    Types typeName = (Types)count;
                    resistance.Add($"{typeName.ToString()} - x0.5");
                }
                else if (item == 0.25)
                {
                    Types typeName = (Types)count;
                    resistance.Add($"{typeName.ToString()} - x0.25");
                }
                count++;
            }
            return resistance;
        }
    }
}
