using Megaphone.Core;
using Megaphone.Core.ClusterProviders;
using System;

namespace StandaloneClient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Cluster.BootstrapClient(new ConsulProvider(useEbayFabio: false));

            while (true)
            {
                Console.ReadLine();
                var res = Cluster.FindServiceInstanceAsync("orders").Result;
                Console.WriteLine($"Found Address:{res.Address} Port:{res.Port}");
            }
        }
    }
}