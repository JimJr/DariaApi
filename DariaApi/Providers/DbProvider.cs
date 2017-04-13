namespace DariaApi.Providers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using MongoDB;
    using MongoDB.Driver;
    using System.Configuration;
    using DariaApi.Models;

    public class DbProvider : IDbProvider
    {
        private IMongoClient _dbClient;
        private IMongoDatabase _db;

        public DbProvider(string connectionString = null)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                connectionString = ConfigurationManager.ConnectionStrings["Mongo"].ConnectionString;
            }

            _dbClient = new MongoClient(connectionString);
            _db = _dbClient.GetDatabase("dariaDb");
        }

        public T SelectByIdOperation<T>(string selector) where T : class, IEntity
        {
            var collection = _db.GetCollection<T>(typeof(T).Name.ToLower() + "s");

            var filter = Builders<T>.Filter.Eq(e => e.EntityId, selector);
            var result = collection.Find(filter).ToList().FirstOrDefault();

            return result;
        }
    }
}