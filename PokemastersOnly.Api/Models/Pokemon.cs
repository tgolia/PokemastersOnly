using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemastersOnly.Api.Models
{
    public class Pokemon
    {
        public int PokemonId { get; set; }
        public string Name { get; set; }
        public string PrimaryType { get; set; }
        public string SecondaryType { get; set; }
        public string PokedexEntry { get; set; }
        public bool IsLegendary { get; set; }
        public bool HasShiny { get; set; }

        // Relations
    }
}