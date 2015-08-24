using System.Threading.Tasks;
using MonkeyStrong.Api.DataStore.Interfaces;

namespace MonkeyStrong.Api.DataStore.Commands.Interfaces
{
    public interface ICommand<in TParameters, TCollection>
    {
        Task ExecuteAsync(TParameters parameters, IDataCollection<TCollection> collection);
    }
}