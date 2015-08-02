using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonkeyStrong.Api.Models;
using MonkeyStrong.Api.Repositories.Interfaces;

namespace MonkeyStrong.Api.Repositories
{
    public class ClimbRepository : IClimbRepository
    {
        public Task<Climb> Get()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Climb>> GetMany()
        {
            throw new NotImplementedException();
        }

        public Task<Climb> Upsert(Climb climb)
        {
            throw new NotImplementedException();
        }

        public void Delete(Climb climb)
        {
            throw new NotImplementedException();
        }
    }
}