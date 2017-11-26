using Megaphone.Core;
using Nancy;

namespace Megaphone.Nancy
{
    public class StatusModule : NancyModule
    {
        public StatusModule()
        {
            Get["/status"] = _ =>
            {
                Logger.Information("OK");
                return "ok";
            };
        }        
    }
}
