using Pokeapi.Controller;
using Pokeapi.Modelos;
using System;
using System.Windows.Forms;


namespace Pokeapi
{
    public partial class pokedex : Form
    {
        private PokemonController pController;
        private Pokemones pokemones;
        private PokeDescripcion pokedescripcion;
        private string pokename;
        
        public pokedex()
        {
            InitializeComponent();
            pController = new PokemonController();
            pokemones = new Pokemones();
            pokedescripcion = new PokeDescripcion();
        }

        public async void getPokeUrl(String pokename)
        {
            Boolean encontrado = false;
            pokemones = await pController.GetAllPokemones();
            string url = "";
            if (pokemones != null)
            {
                foreach (var pokemon in pokemones.results)
                {
                    if (pokemon.name == pokename)
                    {
                        url = pokemon.url;
                        getPokeDescription(url);
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    MessageBox.Show("no se encontro el pokemon solicitado");
                    this.Close();
                }
            }
        }

        private async void getPokeDescription(string url)
        {
            pokedescripcion = await pController.GetAllDescription(url);

            string[] image = {pokedescripcion.sprites.back_default.ToString(),
            pokedescripcion.sprites.back_shiny.ToString(),
            pokedescripcion.sprites.front_default.ToString(),
            pokedescripcion.sprites.front_shiny.ToString()};

            PbPokemon1.Load(image[0].ToString());
            PbPokemon2.Load(image[1].ToString());
            PbPokemon3.Load(image[2].ToString());
            PbPokemon4.Load(image[3].ToString());


            txtDescripcion.Text = "Name: " + pokedescripcion.name + "\r\n" + "Pokedex: " + pokedescripcion.id
                + "\r\n" + "Height: " + pokedescripcion.height + " " + "\r\n" + "Weight: " + pokedescripcion.weight + " "
                + "\r\n" + "EXP Base: " + pokedescripcion.base_experience + " " + "\r\n" + "Stats" + "\r\n" + "{";

                for (int i =0; i < pokedescripcion.stats.Count; i++)
            {
                txtDescripcion.Text += "\r\n" + "\t" + pokedescripcion.stats[i].stat.name + ": " + pokedescripcion.stats[i].base_stat + " ";
            }
            txtDescripcion.Text += "\r\n" + "}";
            txtDescripcion.Text += "\r\n" + "Type: " + pokedescripcion.types[0].type.name + " ";

                if (pokedescripcion.types.Count == 2)
                {
                    txtDescripcion.Text += pokedescripcion.types[1].type.name;
                }

            txtDescripcion.Text += "\r\n" + "Abilities: " + "\r\n" + "{";
            for (int i = 0; i < pokedescripcion.abilities.Count; i++)
            {
                txtDescripcion.Text += "\r\n" + "\t" + pokedescripcion.abilities[i].ability.name;
            }
            txtDescripcion.Text += "\r\n" +"}";
        }

        private void pokedex_Load(object sender, EventArgs e)
        {
            pokename = Form1.PokeName;
            getPokeUrl(pokename);
        }
    }
}
