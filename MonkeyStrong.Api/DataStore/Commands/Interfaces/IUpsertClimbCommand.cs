using MonkeyStrong.Api.DataStore.Commands.Parameters;
using MonkeyStrong.Api.Models;

namespace MonkeyStrong.Api.DataStore.Commands.Interfaces
{
    public interface IUpsertClimbCommand : ICommand<UpsertClimbCommandParameters, Climb>
    {
    }
}