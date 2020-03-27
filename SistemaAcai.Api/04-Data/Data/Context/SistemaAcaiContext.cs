using Data.Mapping;
using Domain.Entities;
using Domain.Entities.AcaiSize;
using Domain.Entities.Additional;
using Domain.Entities.Flavor;
using Domain.Entities.Order;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class SistemaAcaiContext : DbContext
    {
        public SistemaAcaiContext(DbContextOptions<SistemaAcaiContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OrderEntity>(new OrderMap().Configure);
            modelBuilder.Entity<FlavorEntity>(new FlavorMap().Configure);
            modelBuilder.Entity<AcaiSizeEntity>(new AcaiSizeMap().Configure);
            modelBuilder.Entity<AdditionalEntity>(new AdditionalMap().Configure);
        }
    }
}