using System.Web.Http;
using MonkeyStrong.Common.Requests;

namespace MonkeyStrong.Api.Controllers.Administration
{
    public class ClimbAdministrationController : ApiController
    {
        public IHttpActionResult Post(UpsertClimbRequest request)
        {
            return Ok();
        }

        public IHttpActionResult Put(UpsertClimbRequest request)
        {
            return Ok();
        }
    }
}