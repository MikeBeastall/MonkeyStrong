using System;
using System.Threading.Tasks;
using System.Web.Http;
using MonkeyStrong.Api.DataStore.Interfaces;
using MonkeyStrong.Api.Extensions;
using MonkeyStrong.Api.Models;
using MonkeyStrong.Common.Requests;

namespace MonkeyStrong.Api.Controllers.Administration
{
    public class ClimbAdministrationController : ApiController
    {
        private readonly IClimbRepository _climbRepository;

        public ClimbAdministrationController(IClimbRepository climbRepository)
        {
            _climbRepository = climbRepository;
        }

        public async Task<IHttpActionResult> Post(UpsertClimbRequest request)
        {
            var climb = new Climb
            {
                LatLong = new LatLong
                {
                    Latitude = request.LatLong.Latitude,
                    Longitude = request.LatLong.Longitude
                },
                Styles = request.Styles
            };

            var result = await Upsert(climb);

            return Ok(result.ToResponse());
        }

        public async Task<IHttpActionResult> Put(string id, UpsertClimbRequest request)
        {
            var climb = new Climb
            {
                Id = new Guid(id),
                LatLong = new LatLong
                {
                    Latitude = request.LatLong.Latitude,
                    Longitude = request.LatLong.Longitude
                },
                Styles = request.Styles
            };

            var result = await Upsert(climb);

            return Ok(result.ToResponse());
        }

        private async Task<Climb> Upsert(Climb climb)
        {
            return await _climbRepository.UpsertAsync(climb);
        }
    }
}