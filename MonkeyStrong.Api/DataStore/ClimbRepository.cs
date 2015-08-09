using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonkeyStrong.Api.DataStore.Interfaces;
using MonkeyStrong.Api.DataStore.Providers.Interfaces;
using MonkeyStrong.Api.Models;

namespace MonkeyStrong.Api.DataStore
{
    public class ClimbRepository : IClimbRepository
    {
        public ClimbRepository(IDatabaseProvider databaseProvider)
        {
            
        }

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