using Megaphone.Core;
using Megaphone.Core.ClusterProviders;
using Megaphone.Nancy;
using Nancy;
using System;
using System.Threading;

namespace NancyFxServiceExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Cluster.Bootstrap(new NancyProvider(), new ConsulProvider(useEbayFabio: false), "customers", "v1");
            Thread.Sleep(5000);
            DiscoverService();
            Console.ReadLine();
        }

        private static void DiscoverService()
        {
            var instance = Cluster.FindServiceInstanceAsync("customers").Result;
            Console.WriteLine($"{instance.Address} {instance.Port}");
            Console.ReadLine();
        }
    }

    public class CustomerService : NancyModule
    {
        public CustomerService() : base("/customers")
        {
            Get("/", args =>
            {
                var customer = new Customer
                {
                    CustomerId = 123,
                    CustomerName = "Acme Inc",
                };

                return Response.AsJson(customer);
            });
        }
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
    }
}