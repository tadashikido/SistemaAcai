using Domain.Entities;
using Domain.Entities.Order;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class OrderMap : IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.ToTable("PEDIDO");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                   .HasColumnName("ID");

            builder.Property(e => e.UpdateAt)
                   .HasColumnName("UPDATE_AT");

            builder.Property(e => e.CreateAt)
                    .HasColumnName("CREATE_AT");

            builder.HasOne(e => e.Flavor).WithOne(e => e.Order);
            builder.HasOne(e => e.AcaiSize).WithOne(e => e.Order);
            builder.HasMany(e => e.Additional).WithOne(e => e.Order);
        }
    }
}