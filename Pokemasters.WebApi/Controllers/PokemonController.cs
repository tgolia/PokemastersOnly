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
        private IWritePokemon _repo2;

        // constructor to configure default shit for object
        public PokemonController(IReadPokemon repo, IWritePokemon repo2)
        {
            // initialize the object
            _repo = repo;
            _repo2 = repo2;
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

        public HttpResponseMessage AddPokemon(Pokemon pokemon)
        {
          _repo2.AddPokemon(pokemon);
          Console.Write(pokemon);
          return new HttpResponseMessage(HttpStatusCode.OK);
        }

}
}
