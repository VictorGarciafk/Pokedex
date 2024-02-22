using Newtonsoft.Json;
using Pokeapi.Modelos;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokeapi.Controller
{
    public class PokemonController
    {
        private HttpClient client;

        public PokemonController()
        {
            client = new HttpClient();
        }

        public async Task<Pokemones> GetAllPokemones()
        {
            try
            {
                Pokemones pokemones = new Pokemones();
                HttpResponseMessage response = await client.
                    GetAsync("https://pokeapi.co/api/v2/pokemon");
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                pokemones = JsonConvert.DeserializeObject<Pokemones>(responseJson); 

                return pokemones;

            }catch (Exception)
            {
                return null;
            }
        }

        public async Task<PokeDescripcion> GetAllDescription(String url)
        {
            try
            {
                PokeDescripcion pokeDescripcion = new PokeDescripcion();
                HttpResponseMessage response = await client.
                    GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                pokeDescripcion = JsonConvert.DeserializeObject<PokeDescripcion>(responseJson);

                return pokeDescripcion;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


    }
}
