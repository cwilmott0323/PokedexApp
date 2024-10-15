using PokedexLibrary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace Pokedex
{
    public partial class Pokedex : Form
    {
        readonly BindingList<string> list = new BindingList<string>();
        List<string> pokemonNames = new List<string>();
        PokeAPI allPokemon = new PokeAPI();

        public Pokedex()
        {   
            ApiHelper.InitaliseClient();
            InitializeComponent();
        }

        private void WireUpList()
        {
            foreach (var item in FilterResults(SearchBox.Text))
            {
                list.Add(item);
            }
            ResultsWindow.DataSource = list;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text != string.Empty)
            {
                this.Size = new Size(1411, 715);
            }
            else
            {
                this.Size = new Size(731, 211);
            }
            WireUpList();
        }
        private List<string> GetPokemonNames(PokeAPI pokemonData)
        {
            List<string> pN = new List<string>();

            foreach (var item in pokemonData.results)
            {
                pN.Add(char.ToUpper(item.name[0]) + item.name.Substring(1));
            }
            return pN;
        }

        private List<string> FilterResults(string search)
        {
            List<string> match = new List<string>();
            list.Clear();
            if (SearchBox.Text.Length >= 1)
            {
                foreach (var item in pokemonNames)
                {
                    if (item.ToLower().Contains(search.ToLower()))
                    {
                        match.Add(item);
                    }
                }
                return match;
            }

            return match;

        }

        private void ResultsWindow_DoubleClick(object sender, EventArgs e)
        {
            var pokedexModel = new PokedexModel(ResultsWindow.SelectedItem.ToString(), allPokemon);
            pokedexModel.ShowDialog();
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
            SearchBox.Text = string.Empty;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            SearchBox.Text = string.Empty;
        }

        private async void Pokedex_Load(object sender, EventArgs e)
        {
            allPokemon = await PokeAPI.LoadAllPokemon("https://pokeapi.co/api/v2/pokemon/?limit=1302");
            pokemonNames = GetPokemonNames(allPokemon);
        }
    }
}
