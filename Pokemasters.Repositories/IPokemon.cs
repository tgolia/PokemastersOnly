using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokemasters.Repositories
{
    public interface IPokemon
    {
        IEnumerable<string> GetAllPokemon();
        string GetPokemonById(int id);
    }
}