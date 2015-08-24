using System.Collections.Generic;
using System.Threading.Tasks;
using MonkeyStrong.Api.DataStore.Repositories.Parameters;
using MonkeyStrong.Api.Models;

namespace MonkeyStrong.Api.DataStore.Interfaces
{
    public interface IClimbRepository
    {
        Task<Climb> GetAsync(GetClimbsParameters parameters);
        Task<IEnumerable<Climb>> GetManyAsync(GetClimbsParameters parameters);
        Task<Climb> UpsertAsync(Climb climb);
        Task DeleteAsync(Climb climb);
    }
}