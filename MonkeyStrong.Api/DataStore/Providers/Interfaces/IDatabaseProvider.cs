using MonkeyStrong.Api.DataStore.Interfaces;

namespace MonkeyStrong.Api.DataStore.Providers.Interfaces
{
    public interface IDatabaseProvider
    {
        IDatabase GetDatabase();
    }
}
