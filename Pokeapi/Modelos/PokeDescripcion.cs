using System.Collections.Generic;


namespace Pokeapi.Modelos
{
    public class Ability
    {
        public string name { get; set; }
        public string url { get; set; }

    }
    public class Abilities
    {
        public Ability ability { get; set; }
        public bool is_hidden { get; set; }
        public int slot { get; set; }

    }

    public class Sprites
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }

    }
    public class Stat
    {
        public string name { get; set; }
        public string url { get; set; }

    }
    public class Stats
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public Stat stat { get; set; }

    }
    public class Type
    {
        public string name { get; set; }
        public string url { get; set; }

    }
    public class Types
    {
        public int slot { get; set; }
        public Type type { get; set; }

    }
    public class PokeDescripcion
    {
        public IList<Abilities> abilities { get; set; }
        public int base_experience { get; set; }
        public int height { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public Sprites sprites { get; set; }
        public IList<Stats> stats { get; set; }
        public IList<Types> types { get; set; }
        public int weight { get; set; }
    }
}