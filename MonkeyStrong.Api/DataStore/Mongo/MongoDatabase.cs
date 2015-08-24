using MongoDB.Driver;
using MonkeyStrong.Api.DataStore.Interfaces;

namespace MonkeyStrong.Api.DataStore.Mongo
{
    public class MongoDatabase : IDatabase
    {
        private readonly IMongoDatabase _database;

        public MongoDatabase(IMongoDatabase database)
        {
            _database = database;
        }

        public IDataCollection<T> GetCollection<T>(string name)
        {
            return (IDataCollection<T>) _database.GetCollection<T>(name);
        }
    }
}