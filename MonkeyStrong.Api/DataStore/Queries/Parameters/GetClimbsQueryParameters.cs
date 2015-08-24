using System;
using System.Collections.Generic;

namespace MonkeyStrong.Api.DataStore.Queries.Parameters
{
    public class GetClimbsQueryParameters
    {
        public Guid Id { get; set; }
        public List<string> Styles { get; set; }
        public double RatingMin { get; set; }
        public double RatingMax { get; set; }
    }
}