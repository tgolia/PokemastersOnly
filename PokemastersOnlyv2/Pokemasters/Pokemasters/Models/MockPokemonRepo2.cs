using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokemasters.Models
{
    public class MockPokemonRepo2 : IPokemon
    {
        public IEnumerable<string> GetAllPokemon()
        {
            var gen2 = new List<string>
            {
                "chikorita",
                "cynadquil",
                "totodil"
            };

            return gen2;
        }

        public string GetPokemonById(int id)
        {
            return "chikorita";
        }
    }
}