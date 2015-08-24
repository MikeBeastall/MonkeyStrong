using System.Collections.Generic;
using MonkeyStrong.Common.TransferObjects;

namespace MonkeyStrong.Common.Responses
{
    public class ClimbResponse
    {
        public LatLongTransferObject LatLong { get; set; }
        // TODO -> grade?
        public List<string> Styles { get; set; }
        public double Rating { get; set; }
        public string Name { get; set; }
    }
}