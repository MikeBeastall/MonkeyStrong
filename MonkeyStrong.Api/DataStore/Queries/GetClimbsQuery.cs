using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using MonkeyStrong.Api.DataStore.Interfaces;
using MonkeyStrong.Api.DataStore.Queries.Interfaces;
using MonkeyStrong.Api.DataStore.Queries.Parameters;
using MonkeyStrong.Api.Models;

namespace MonkeyStrong.Api.DataStore.Queries
{
    public class GetClimbsQuery : IGetClimbsQuery
    {
        public async Task<IEnumerable<Climb>> ExecuteAsync(GetClimbsQueryParameters parameters,
            IDataCollection<Climb> collection)
        {
            var filters = new List<FilterDefinition<Climb>>();

            if (parameters.Id != Guid.Empty)
            {
                var filter = Builders<Climb>.Filter.Eq(c => c.Id == parameters.Id, true);

                filters.Add(filter);
            }

            if (parameters.Styles != null && parameters.Styles.Count > 0)
            {
                var filter = Builders<Climb>.Filter.AnyIn(c => c.Styles, parameters.Styles);
                filters.Add(filter);
            }

            if (!string.IsNullOrEmpty(parameters.Name))
            {
                var filter = Builders<Climb>.Filter.Eq(c => c.Name == parameters.Name, true);
                filters.Add(filter);
            }

            var complexFilter = Builders<Climb>.Filter.And(filters);

            var fullCollection = await collection.FindAsync(complexFilter);
            return await fullCollection.ToListAsync();
        }
    }
}