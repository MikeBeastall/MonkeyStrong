using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace MonkeyStrong.Api.DataStore.Queries.Interfaces
{
    public interface IQuery<in TParameters, TResult>
    {
        Task<IEnumerable<TResult>> ExecuteAsync(TParameters parameters, IMongoCollection<TResult> collection);
    }
}