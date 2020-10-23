using Dell.Business;
using Dell.Contracts;
using Dell.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Dell.ConsoleApp
{
    public static class AppServices
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IShippingCostsOrder, ShippingOrderCost>();
            services.AddScoped<IShippingCostsOrderService, ShippingCostsOrderService>();
        }
    }
}
