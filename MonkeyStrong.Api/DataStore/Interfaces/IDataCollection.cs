using MongoDB.Driver;

namespace MonkeyStrong.Api.DataStore.Interfaces
{
    public interface IDataCollection<T> : IMongoCollection<T>
    {
    }
}