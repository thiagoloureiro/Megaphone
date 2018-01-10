using Megaphone.Core.ClusterProviders;
using System;
using System.Threading.Tasks;

namespace Megaphone.Core
{
    public static class Cluster
    {
        private static IClusterProvider _clusterProvider;
        private static IFrameworkProvider _frameworkProvider;

        public static Task<ServiceInformation[]> FindServiceInstancesAsync(string name)
        {
            return _clusterProvider.FindServiceInstancesAsync(name);
        }

        public static Task<ServiceInformation> FindServiceInstanceAsync(string name)
        {
            return _clusterProvider.FindServiceInstanceAsync(name);
        }

        public static void BootstrapClient(IClusterProvider clusterProvider)
        {
            _clusterProvider = clusterProvider;
            _clusterProvider.BootstrapClientAsync().Wait();
        }

        public static Task KvPutAsync(string key, object value)
        {
            return _clusterProvider.KvPutAsync(key, value);
        }

        public static Task<T> KvGetAsync<T>(string key)
        {
            return _clusterProvider.KvGetAsync<T>(key);
        }

        public static void Bootstrap(IFrameworkProvider frameworkProvider, IClusterProvider clusterProvider, string serviceName, string version)
        {
            try
            {
                _frameworkProvider = frameworkProvider;
                var uri = _frameworkProvider.Start(serviceName, version);
                var serviceId = serviceName + Guid.NewGuid();
                _clusterProvider = clusterProvider;
                _clusterProvider.RegisterServiceAsync(serviceName, serviceId, version, uri).Wait();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}