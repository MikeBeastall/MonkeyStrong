using System.Threading.Tasks;
using MongoDB.Driver;

namespace MonkeyStrong.Api.DataStore.Commands.Interfaces
{
    public interface ICommand<in TParameters, TCollection>
    {
        Task ExecuteAsync(TParameters parameters, IMongoCollection<TCollection> collection);
    }
}