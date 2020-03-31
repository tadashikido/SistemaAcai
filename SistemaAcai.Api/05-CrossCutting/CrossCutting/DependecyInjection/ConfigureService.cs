using Domain.Service;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;

namespace CrossCutting.DependecyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependeciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IOrderService, OrderService>();
            serviceCollection.AddTransient<IProductService, ProductService>();
        }
    }
}