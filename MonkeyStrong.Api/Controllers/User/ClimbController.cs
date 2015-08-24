using System.Threading.Tasks;
using System.Web.Http;
using MonkeyStrong.Api.DataStore.Interfaces;
using MonkeyStrong.Api.DataStore.Repositories.Parameters;
using MonkeyStrong.Api.Extensions;

namespace MonkeyStrong.Api.Controllers.User
{
    public class ClimbController : ApiController
    {
        private readonly IClimbRepository _repository;

        public ClimbController(IClimbRepository repository)
        {
            _repository = repository;
        }

        public async Task<IHttpActionResult> Get(string name)
        {
            var result = await _repository.GetAsync(new GetClimbsParameters
            {
                Name = name
            });

            return Ok(result.ToResponse());
        }
    }
}