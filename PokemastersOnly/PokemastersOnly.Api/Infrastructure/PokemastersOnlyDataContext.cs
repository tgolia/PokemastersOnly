using PokemastersOnly.Api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PokemastersOnly.Api.Infrastructure
{
    public class PokemastersOnlyDataContext : DbContext
    {
        public PokemastersOnlyDataContext() : base("PokemastersOnly")
        {
        }

        public IDbSet<Pokemon> Pokemons { get; set; }
        public IDbSet<Trainer> Trainers { get; set; }
        public IDbSet<Trade> Trades { get; set; }

        // TODO: Add relationships using Entity Framework's fluid api
    }
}