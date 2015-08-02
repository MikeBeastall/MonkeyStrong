using System.Collections.Generic;

namespace MonkeyStrong.Api.Models
{
    public class Climb
    {
        public LatLong LatLong { get; set; }
        public List<string> Styles { get; set; }
        public double Rating { get; set; }
    }
}