using MongoDB.Driver;

namespace MonkeyStrong.Api.DataStore.Interfaces
{
    // TODO -> Add layer of separation between collections
    public interface IDataCollection<T> : IMongoCollection<T>
    {
    }
}