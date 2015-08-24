using System;
using System.Collections.Generic;

namespace MonkeyStrong.Api.DataStore.Repositories.Parameters
{
    public class GetClimbsParameters
    {
        public Guid Id { get; set; }
        public IEnumerable<string> Styles { get; set; }
        public string Name { get; set; }
    }
}