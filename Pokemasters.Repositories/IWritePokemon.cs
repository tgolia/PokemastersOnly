using Pokemasters.Repositories.DBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokemasters.Repositories
{
    public interface IWritePokemon
    {
        Pokemon AddPokemon(Pokemon pokemon);
    }
}