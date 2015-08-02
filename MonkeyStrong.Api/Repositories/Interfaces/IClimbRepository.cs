using System.Collections.Generic;
using System.Threading.Tasks;
using MonkeyStrong.Api.Models;

namespace MonkeyStrong.Api.Repositories.Interfaces
{
    internal interface IClimbRepository
    {
        Task<Climb> Get();
        Task<IEnumerable<Climb>> GetMany();
        Task<Climb> Upsert(Climb climb);
        void Delete(Climb climb);
    }
}