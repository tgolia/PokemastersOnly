using Pokemasters.Repositories;
using Pokemasters.Repositories.DBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Pokemasters.Controllers
{
    public class PokemonController : ApiController
    {
        // typical class has i) properties ii) constructor iii) methods

        // declaring the object as local variable
        private IReadPokemon _repo;

        // constructor to configure default shit for object
        public PokemonController(IReadPokemon repo)
        {
            // initialize the object
            _repo = repo;
        }
        public IEnumerable<Pokemon> GetPokemonList()
        {
            var PokemonList = _repo.GetAllPokemon();
            return PokemonList;

        }

        public string GetPokemonById(int id)
        {
            var Pokemon = _repo.GetPokemonById(id);
            return Pokemon;
        }

    }
}
