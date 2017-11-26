using System.Web.Http;
using Megaphone.Core;

namespace Megaphone.WebApi
{
    public class StatusController : ApiController
    {
        [Route("status")]
        public string GetStatus()
        {
            Logger.Information("OK");
            return "ok";
        }
    }
}