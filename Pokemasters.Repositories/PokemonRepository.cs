using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Pokemasters.Repositories.DBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokemasters.Repositories
{
    public class PokemonRepository : IReadPokemon
    {
        //static string connectionString = "mongodb://mongo01.jitterbug.test/?replicaSet=rs0";
        static string connectionString = "mongodb://localhost:27017";
        static string databaseName = "PokemastersOnly";
        static string collectionName = "Pokemon";
        static IMongoCollection<Pokemon> collection;
        public PokemonRepository()
        {
            if (!BsonClassMap.IsClassMapRegistered(typeof(Pokemon)))
            {
                BsonClassMap.RegisterClassMap<Pokemon>(cm =>
                {
                    cm.AutoMap();
                });
            }
            collection = new MongoClient(connectionString).GetDatabase(databaseName).GetCollection<Pokemon>(collectionName);
        }
        
        public IEnumerable<Pokemon> GetAllPokemon()
        {
            //TODO: should make this async later to free up resources if taking a while
            return collection.Find(Builders<Pokemon>.Filter.Empty).ToList();
        }

        public string GetPokemonById(int id)
        {
            var filter = Builders<Pokemon>.Filter.Where(x => x.PokemonId == id);
            return collection.Find(filter).FirstOrDefault()?.Name;
        }
    }
}