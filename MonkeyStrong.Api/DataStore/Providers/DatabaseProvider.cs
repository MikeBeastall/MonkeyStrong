using MongoDB.Driver;
using MonkeyStrong.Api.Bootstrap;
using MonkeyStrong.Api.DataStore.Interfaces;
using MonkeyStrong.Api.DataStore.Mongo;

namespace MonkeyStrong.Api.DataStore.Providers
{
    public class DatabaseProvider
    {
        private readonly IMongoDatabase _database;

        public DatabaseProvider(IConfiguration configuration)
        {
            var client = new MongoClient(new MongoUrl(configuration.MongoDbUrl));
            _database = client.GetDatabase("monkeystrong");
        }

        public IDatabase GetDatabase()
        {
            return new MongoDatabase(_database);
        }
    }
}