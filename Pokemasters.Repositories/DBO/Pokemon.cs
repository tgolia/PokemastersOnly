using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokemasters.Repositories.DBO
{
    public class Pokemon
    {
        public ObjectId Id { get; set; }
        public int PokemonId { get; set; }
        public string Name { get; set; }
        // refactor Types to string array
        public string PrimaryType { get; set; }
        public string SecondaryType { get; set; }
    }
}