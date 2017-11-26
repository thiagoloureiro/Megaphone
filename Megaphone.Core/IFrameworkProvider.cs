using System;

namespace Megaphone.Core
{
    public interface IFrameworkProvider
    {
        Uri Start(string serviceName, string version);
    }
}