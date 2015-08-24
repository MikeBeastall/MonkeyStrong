using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonkeyStrong.Api.DataStore.Commands.Interfaces;
using MonkeyStrong.Api.DataStore.Commands.Parameters;
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
        private readonly IDeleteClimbCommand _deleteClimbCommand;
        private readonly IGetClimbsQuery _getClimbsQuery;
        private readonly IUpsertClimbCommand _upsertClimbCommand;

        public ClimbRepository(IDatabaseProvider databaseProvider, IGetClimbsQuery getClimbsQuery,
            IDeleteClimbCommand deleteClimbCommand, IUpsertClimbCommand upsertClimbCommand)
        {
            _getClimbsQuery = getClimbsQuery;
            _deleteClimbCommand = deleteClimbCommand;
            _upsertClimbCommand = upsertClimbCommand;
            _database = databaseProvider.CreateDatabase();
        }

        public async Task<Climb> Upsert(Climb climb)
        {
            await _upsertClimbCommand.ExecuteAsync(new UpsertClimbCommandParameters
            {
                Id = climb.Id,
                LatLong = climb.LatLong,
                Styles = climb.Styles,
                Rating = climb.Rating
            }, _database.GetCollection<Climb>("climbs"));

            return climb;
        }

        public async Task Delete(Climb climb)
        {
            await _deleteClimbCommand.ExecuteAsync(new DeleteClimbCommandParameters
            {
                Id = climb.Id
            }, _database.GetCollection<Climb>("climbs"));

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