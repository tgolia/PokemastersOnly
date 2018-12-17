using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokemasters.Repositories
{
    public class MockPokemonRepository //: IReadPokemon
    {
        public IEnumerable<string> GetAllPokemon()
        {
            return new string[] { "Charmander", "Squirtle", "Bulbasaur" };
        }

        public string GetPokemonById(int id)
        {
            if (id == 1)
            {
                return "Bulbasaur";
            }
            else if (id == 4)
            {
                return "Charmander";
            }
            else if (id == 7)
            {
                return "Squirtle";
            }
            else
            {
                return "No Pokemans with that id bro";
            }
        }
    }
}