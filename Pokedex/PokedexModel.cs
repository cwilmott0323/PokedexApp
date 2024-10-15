using PokedexLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pokedex
{
    public partial class PokedexModel : Form
    {
        private string pokemonName = string.Empty;
        private PokeAPI pl = new PokeAPI();

        int AvgHP = 69;
        int AvgAttack = 77;
        int AvgDefense = 72;
        int AvgSPAttack = 70;
        int AvgSPDefense = 70;
        int AvgSpeed = 71;

        public PokemonMethod pokemonData = new PokemonMethod();

        public PokedexModel(string pokemon, PokeAPI p)
        {
            pokemonName = pokemon;
            pl = p;
            InitializeComponent();
        }

        private async void PokedexModel_Load(object sender, System.EventArgs e)
        {
            Debug.WriteLine(pokemonName);
            string result = PokeAPI.GetSelectedPokemonData(pokemonName, pl);
            pokemonData = await PokeAPI.LoadPokemon(result);

            List<string> types = new List<string>();
            List<string> weakness = new List<string>();
            List<string> stats = new List<string>();

            WeaknessLabel.Visible = true;
            Resistances.Visible = true;
            Immunities.Visible = true;
            PokemonName.Visible = true;
            Sprite.Visible = true;
            PokemonName.Text = pokemonName;

            HP.Invalidate();
            Attack.Invalidate();
            Defense.Invalidate();
            SPAttack.Invalidate();
            SPDefense.Invalidate();
            Speed.Invalidate();

            Sprite.Load(pokemonData.sprites.other.home.front_default);
            this.Text = FirstUpper(pokemonData.name);

            foreach (var item in pokemonData.types)
            {
                types.Add(FirstUpper(item.type.name));
            }
            Type.Text = String.Join(" / ", types);


            Weakness.Text = String.Join(Environment.NewLine, pokemonData.TypeEffectiviness(PokemonTypes.Effectiveness.Weakness));
            Resistance.Text = String.Join(Environment.NewLine, pokemonData.TypeEffectiviness(PokemonTypes.Effectiveness.Resistence));
            Immunity.Text = String.Join(Environment.NewLine, pokemonData.TypeEffectiviness(PokemonTypes.Effectiveness.Immunity));

            foreach (var item in pokemonData.stats)
            {
                stats.Add($" {FirstUpper(item.stat.name)}: {item.base_stat.ToString()}");
            }

            HPText.Text = pokemonData.stats[0].base_stat.ToString();
            AttackText.Text = pokemonData.stats[1].base_stat.ToString();
            DefenseText.Text = pokemonData.stats[2].base_stat.ToString();
            SPAttackText.Text = pokemonData.stats[3].base_stat.ToString();
            SPDefenseText.Text = pokemonData.stats[4].base_stat.ToString();
            SpeedText.Text = pokemonData.stats[5].base_stat.ToString();
        }

        public Color GetColorForStat(int statValue, int Avg)
        {
            if (statValue < Avg - (Avg / 6))
            {
                return Color.FromArgb(255, 255, 0, 0);  // Red for less than 100
            }
            else if (statValue > Avg + (Avg / 6))
            {
                return Color.FromArgb(255, 0, 255, 0);  // Green for 100 or more
            }
            else
            {
                return Color.FromArgb(255, 255, 221, 0);  // Orange for 100 or more
            }

        }


        private void HP_Paint(object sender, PaintEventArgs e)
        {
            if (pokemonData.stats != null) // Ensure r.stats is not null
            {
                SolidBrush solidBrush = new SolidBrush(GetColorForStat(pokemonData.stats[0].base_stat, AvgHP));
                e.Graphics.FillEllipse(solidBrush, 0, 0, 30, 30);
            }

        }

        private void Attack_Paint(object sender, PaintEventArgs e)
        {
            if (pokemonData.stats != null) // Ensure r is not null
            {
                SolidBrush solidBrush = new SolidBrush(GetColorForStat(pokemonData.stats[1].base_stat, AvgAttack));
                e.Graphics.FillEllipse(solidBrush, 0, 0, 30, 30);
            }
        }

        private void Defense_Paint(object sender, PaintEventArgs e)
        {
            if (pokemonData.stats != null) // Ensure r is not null
            {
                SolidBrush solidBrush = new SolidBrush(GetColorForStat(pokemonData.stats[2].base_stat, AvgDefense));
                e.Graphics.FillEllipse(solidBrush, 0, 0, 30, 30);
            }
        }

        private void SPAttack_Paint(object sender, PaintEventArgs e)
        {
            if (pokemonData.stats != null) // Ensure r is not null
            {
                SolidBrush solidBrush = new SolidBrush(GetColorForStat(pokemonData.stats[3].base_stat, AvgSPAttack));
                e.Graphics.FillEllipse(solidBrush, 0, 0, 30, 30);
            }
        }

        private void SPDefense_Paint(object sender, PaintEventArgs e)
        {
            if (pokemonData.stats != null) // Ensure r is not null
            {
                SolidBrush solidBrush = new SolidBrush(GetColorForStat(pokemonData.stats[4].base_stat, AvgSPDefense));
                e.Graphics.FillEllipse(solidBrush, 0, 0, 30, 30);
            }
        }

        private void Speed_Paint(object sender, PaintEventArgs e)
        {
            if (pokemonData.stats != null) // Ensure r is not null
            {
                SolidBrush solidBrush = new SolidBrush(GetColorForStat(pokemonData.stats[5].base_stat, AvgSpeed));
                e.Graphics.FillEllipse(solidBrush, 0, 0, 30, 30);
            }
        }

        private string FirstUpper(string ToConvert)
        {
            return char.ToUpper(ToConvert[0]) + ToConvert.Substring(1);
        }
    }
} 
