using MongoDB.Driver;

namespace MonkeyStrong.Api.DataStore.Interfaces
{
    public interface IDatabase
    {
        IMongoCollection<T> GetCollection<T>(string name);
    }
}