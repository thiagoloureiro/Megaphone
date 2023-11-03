using Megaphone.Core;
using Nancy;

namespace Megaphone.Nancy
{
    public class StatusModule : NancyModule
    {
        public StatusModule()
        {
            Get("/status", args =>
            {
                Logger.Information("OK");
                return "ok";
            });
        }        
    }
}
