using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonkeyStrong.Api.DataStore.Interfaces;
using MonkeyStrong.Api.DataStore.Providers.Interfaces;
using MonkeyStrong.Api.DataStore.Queries.Interfaces;
using MonkeyStrong.Api.DataStore.Queries.Parameters;
using MonkeyStrong.Api.DataStore.Repositories.Parameters;
using MonkeyStrong.Api.Models;

namespace MonkeyStrong.Api.DataStore.Repositories
{
    public class ClimbRepository : IClimbRepository
    {
        private readonly IDatabase _database;
        private readonly IGetClimbsQuery _getClimbsQuery;

        public ClimbRepository(IDatabaseProvider databaseProvider, IGetClimbsQuery getClimbsQuery)
        {
            _getClimbsQuery = getClimbsQuery;
            _database = databaseProvider.CreateDatabase();
        }

        public Task<Climb> Upsert(Climb climb)
        {
            throw new NotImplementedException();
        }

        public void Delete(Climb climb)
        {
            throw new NotImplementedException();
        }

        public async Task<Climb> Get(GetClimbsParameters parameters)
        {
            var result = await GetMany(parameters);
            return result.FirstOrDefault();
        }

        public async Task<IEnumerable<Climb>> GetMany(GetClimbsParameters parameters)
        {
            var collection = _database.GetCollection<Climb>("climbs");

            return await _getClimbsQuery.ExecuteAsync(new GetClimbsQueryParameters
            {
                Id = parameters.Id,
                Styles = parameters.Styles.ToList()
            }, collection);
        }
    }
}