using System;
using System.Collections.Generic;
using MonkeyStrong.Api.Models;

namespace MonkeyStrong.Api.DataStore.Commands.Parameters
{
    public class UpsertClimbCommandParameters
    {
        public Guid Id { get; set; }
        public LatLong LatLong { get; set; }
        public List<string> Styles { get; set; }
        public double Rating { get; set; }
    }
}