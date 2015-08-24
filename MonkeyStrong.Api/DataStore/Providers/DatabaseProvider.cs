using MongoDB.Driver;
using MonkeyStrong.Api.Bootstrap.Interfaces;
using MonkeyStrong.Api.DataStore.Interfaces;
using MonkeyStrong.Api.DataStore.Mongo;
using MonkeyStrong.Api.DataStore.Providers.Interfaces;

namespace MonkeyStrong.Api.DataStore.Providers
{
    public class DatabaseProvider : IDatabaseProvider
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