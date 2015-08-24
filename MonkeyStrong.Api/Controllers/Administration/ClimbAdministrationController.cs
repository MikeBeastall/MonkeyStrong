﻿using System;
using System.Threading.Tasks;
using System.Web.Http;
using MonkeyStrong.Api.DataStore.Interfaces;
using MonkeyStrong.Api.Models;
using MonkeyStrong.Common.Requests;
using MonkeyStrong.Common.Responses;
using MonkeyStrong.Common.TransferObjects;

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

            return Ok(CreateResponse(result));
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

            return Ok(CreateResponse(result));
        }

        private async Task<Climb> Upsert(Climb climb)
        {
            return await _climbRepository.UpsertAsync(climb);
        }

        private ClimbResponse CreateResponse(Climb climb)
        {
            return new ClimbResponse
            {
                LatLong = new LatLongTransferObject
                {
                    Latitude = climb.LatLong.Latitude,
                    Longitude = climb.LatLong.Longitude
                },
                Rating = climb.Rating,
                Styles = climb.Styles
            };
        }
    }
}