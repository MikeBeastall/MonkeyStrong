using MonkeyStrong.Api.DataStore.Queries.Parameters;
using MonkeyStrong.Api.Models;

namespace MonkeyStrong.Api.DataStore.Queries.Interfaces
{
    public interface IGetClimbsQuery : IQuery<GetClimbsQueryParameters, Climb>
    {
    }
}