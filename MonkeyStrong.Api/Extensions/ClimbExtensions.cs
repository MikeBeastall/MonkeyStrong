using MonkeyStrong.Api.Models;
using MonkeyStrong.Common.Responses;
using MonkeyStrong.Common.TransferObjects;

namespace MonkeyStrong.Api.Extensions
{
    public static class ClimbExtensions
    {
        public static ClimbResponse ToResponse(this Climb climb)
        {
            return new ClimbResponse
            {
                LatLong = new LatLongTransferObject
                {
                    Latitude = climb.LatLong.Latitude,
                    Longitude = climb.LatLong.Longitude
                },
                Rating = climb.Rating,
                Styles = climb.Styles,
                Name = climb.Name
            };
        }
    }
}