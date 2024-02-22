
using Pokeapi.Controller;
using Pokeapi.Modelos;
using System;
using System.Windows.Forms;

namespace Pokeapi
{
    public partial class Form1 : Form
    {
        private PokemonController pController;
        private Pokemones pokemones;
        private pokedex poke;
        public static string PokeName;

        public Form1()
        {
            InitializeComponent();
            pController = new PokemonController();
            pokemones = new Pokemones();
            poke = new pokedex();
        }

        private async void getPokemones()
        {
            pokemones = await pController.GetAllPokemones();
            if (pokemones != null)
            {
                foreach (var pokemon in pokemones.results)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvPokemones);
                    row.Cells[0].Value = pokemon.name;
                    dgvPokemones.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("no se pudo mostrar los pokemones");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getPokemones();
        }

        private void dgvPokemones_Click(object sender, EventArgs e)
        {

        }

        private void btnPokedex_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPokemones.SelectedRows)
            {
                PokeName = row.Cells[0].Value.ToString();
            }

            pokedex pd = new pokedex();
            pd.Text = PokeName;
            pd.StartPosition = FormStartPosition.CenterScreen;
            pd.Show();
            poke.getPokeUrl(PokeName); 
        }

        private void BtnBuscarPokemon_Click(object sender, EventArgs e)
        {
            PokeName = TxtBuscarPokemon.Text;
            pokedex pd = new pokedex();
            pd.Text = PokeName;
            pd.StartPosition = FormStartPosition.CenterScreen;
            pd.Show();
            poke.getPokeUrl(PokeName);
        }
    }
}

