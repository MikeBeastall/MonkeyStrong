using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MonkeyStrong.Api.DataStore.Interfaces;
using MonkeyStrong.Api.DataStore.Queries.Interfaces;
using MonkeyStrong.Api.DataStore.Queries.Parameters;
using MonkeyStrong.Api.Models;

namespace MonkeyStrong.Api.DataStore.Queries
{
    public class GetClimbsQuery : IGetClimbsQuery
    {
        public async Task<IEnumerable<Climb>> ExecuteAsync(GetClimbsQueryParameters parameters, IDataCollection<Climb> collection)
        {
            if (parameters.Id != Guid.Empty)
            {
                var filter = Builders<Climb>.Filter.Eq(c => c.Id == parameters.Id, true);
                var result = await collection.FindAsync(filter);
                return await result.ToListAsync();
            }

            if (parameters.Styles != null && parameters.Styles.Count > 0)
            {
                var filter = Builders<Climb>.Filter.AnyIn(c => c.Styles, parameters.Styles);
                var result = await collection.FindAsync(filter);
                return await result.ToListAsync();
            }

            var fullCollection = await collection.FindAsync(new BsonDocumentFilterDefinition<Climb>(new BsonDocument()));
            return await fullCollection.ToListAsync();
        }
    }
}