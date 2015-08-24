using System;
using System.Threading.Tasks;
using MongoDB.Driver;
using MonkeyStrong.Api.DataStore.Commands.Interfaces;
using MonkeyStrong.Api.DataStore.Commands.Parameters;
using MonkeyStrong.Api.DataStore.Interfaces;
using MonkeyStrong.Api.Models;

namespace MonkeyStrong.Api.DataStore.Commands
{
    public class UpsertClimbCommand : IUpsertClimbCommand
    {
        public async Task ExecuteAsync(UpsertClimbCommandParameters parameters, IDataCollection<Climb> collection)
        {
            var climb = new Climb
            {
                Id = parameters.Id,
                LatLong = parameters.LatLong,
                Rating = parameters.Rating,
                Styles = parameters.Styles
            };

            if (parameters.Id == Guid.Empty)
            {
                await collection.InsertOneAsync(climb);
            }
            else
            {
                var filter = Builders<Climb>.Filter.Eq(c => c.Id == climb.Id, true);
                await collection.UpdateOneAsync(filter, new ObjectUpdateDefinition<Climb>(climb));
            }
        }
    }
}