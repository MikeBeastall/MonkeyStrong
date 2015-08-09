namespace MonkeyStrong.Api.DataStore.Interfaces
{
    public interface IDatabase
    {
        IDataCollection<T> GetCollection<T>(string name);
    }
}