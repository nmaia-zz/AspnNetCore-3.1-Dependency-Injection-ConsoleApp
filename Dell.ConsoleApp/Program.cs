using Dell.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Dell.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            SetupServices(out ServiceProvider serviceProvider);
            var provider = serviceProvider;

            var service = provider.GetService<IShippingCostsOrderService>();

            var order = new Order
            {
                ShoppingType = "SEDEX",
                Value = 23.0M
            };

            service.ShippingOrder(order);
        }

        private static void SetupServices(out ServiceProvider serviceProvider)
        {
            var serviceCollection = new ServiceCollection();
            AppServices.ConfigureServices(serviceCollection);
            serviceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
