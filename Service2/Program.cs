using Megaphone.Core;
using Megaphone.Core.ClusterProviders;
using Megaphone.WebApi;
using System;
using System.Web.Http;

namespace WebApiServiceExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Cluster.Bootstrap(new WebApiProvider(), new ConsulProvider(useEbayFabio: false), "orders", "v1");
            Console.ReadLine();
        }
    }

    public class OrdersController : ApiController
    {
        public Order Get()
        {
            return new Order
            {
                CustomerId = 123,
                OrderDate = DateTime.Now,
            };
        }
    }

    public class Order
    {
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
    }
}