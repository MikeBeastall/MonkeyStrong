using System.Collections.Generic;
using System.Threading.Tasks;
using MonkeyStrong.Api.DataStore.Interfaces;

namespace MonkeyStrong.Api.DataStore.Queries.Interfaces
{
    public interface IQuery<in TParameters, TResult>
    {
        Task<IEnumerable<TResult>> ExecuteAsync(TParameters parameters, IDataCollection<TResult> collection);
    }
}