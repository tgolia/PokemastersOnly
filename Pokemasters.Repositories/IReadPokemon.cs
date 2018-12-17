using Pokemasters.Repositories.DBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokemasters.Repositories
{
    public interface IReadPokemon
    {
        IEnumerable<Pokemon> GetAllPokemon();
        string GetPokemonById(int id);
    }
}