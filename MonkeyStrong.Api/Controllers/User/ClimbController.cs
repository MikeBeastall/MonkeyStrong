using System.Web.Http;
using MonkeyStrong.Common.Responses;

namespace MonkeyStrong.Api.Controllers.User
{
    public class ClimbController : ApiController
    {
        public IHttpActionResult Get(string name)
        {
            return Ok(new ClimbResponse());
        }
    }
}