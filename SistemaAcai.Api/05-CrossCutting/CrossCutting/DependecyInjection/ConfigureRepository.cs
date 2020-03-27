using Data.Context;
using Data.Repositories;
using Domain.Interfaces;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.DependecyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependeciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped(typeof(IOrderRepository), typeof(OrderRepository));

            serviceCollection.AddDbContext<SistemaAcaiContext>(
                options => options.UseMySql("Server=localhost;Database=SistemaAcai;Uid=root;Pwd=root;")
            );
        }
    }
}