using System.Threading.Tasks;
using MongoDB.Driver;
using MonkeyStrong.Api.DataStore.Commands.Interfaces;
using MonkeyStrong.Api.DataStore.Commands.Parameters;
using MonkeyStrong.Api.DataStore.Interfaces;
using MonkeyStrong.Api.Models;

namespace MonkeyStrong.Api.DataStore.Commands
{
    public class DeleteClimbCommand : IDeleteClimbCommand
    {
        public async Task ExecuteAsync(DeleteClimbCommandParameters parameters, IDataCollection<Climb> collection)
        {
            var filter = Builders<Climb>.Filter.Eq(c => c.Id == parameters.Id, true);
            await collection.DeleteOneAsync(filter);
        }
    }
}