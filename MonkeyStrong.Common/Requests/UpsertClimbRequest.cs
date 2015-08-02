using System.Collections.Generic;
using MonkeyStrong.Common.TransferObjects;

namespace MonkeyStrong.Common.Requests
{
    public class UpsertClimbRequest
    {
        public LatLongTransferObject LatLong { get; set; }
        public GradeTransferObject Grade { get; set; }
        public List<string> Styles { get; set; }
    }
}