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
            
            // why is automap needed here?
            // usually register class maps because there is something more complicated behind it
            // inherited classes, fields that behave in unexpected way, etc
            // more ex: this column is primary key, ignore this column, etc
            // should be able to map primary key to pokemonId

            //if (!BsonClassMap.IsClassMapRegistered(typeof(Pokemon)))
            //{
            //    BsonClassMap.RegisterClassMap<Pokemon>(cm =>
            //    {
            //        cm.AutoMap();
            //    });
            //}
            collection = new MongoClient(connectionString).GetDatabase(databaseName).GetCollection<Pokemon>(collectionName);
        }
        
        public IEnumerable<Pokemon> GetAllPokemon()
        {
            //TODO: should make this async later to free up resources if taking a while
            //TODO: set ToEnumerable() instead (doesn't guarantee that it's evaluated)? Queryable()? Understand tradeoffs
            return collection.Find(Builders<Pokemon>.Filter.Empty).ToList();
            //TODO: set in request header to set to JSON
        }

        public string GetPokemonById(int id)
        {
            var filter = Builders<Pokemon>.Filter.Where(x => x.PokemonId == id);
            // add into Find to only search Name column... able to remove ? this way
            // .Select option as well
            return collection.Find(filter).FirstOrDefault()?.Name;
        }
    }
}