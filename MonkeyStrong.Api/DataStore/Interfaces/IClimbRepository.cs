using System.Collections.Generic;
using System.Threading.Tasks;
using MonkeyStrong.Api.DataStore.Repositories.Parameters;
using MonkeyStrong.Api.Models;

namespace MonkeyStrong.Api.DataStore.Interfaces
{
    internal interface IClimbRepository
    {
        Task<Climb> Get(GetClimbsParameters parameters);
        Task<IEnumerable<Climb>> GetMany(GetClimbsParameters parameters);
        Task<Climb> Upsert(Climb climb);
        Task Delete(Climb climb);
    }
}