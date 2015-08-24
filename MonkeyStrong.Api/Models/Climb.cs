using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MonkeyStrong.Api.Models
{
    public class Climb
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; }

        public LatLong LatLong { get; set; }
        public List<string> Styles { get; set; }
        public double Rating { get; set; }
        public string Name { get; set; }
    }
}