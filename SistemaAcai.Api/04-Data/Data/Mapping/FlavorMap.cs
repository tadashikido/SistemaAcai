using Domain.Entities.Flavor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class FlavorMap : IEntityTypeConfiguration<FlavorEntity>
    {
        public void Configure(EntityTypeBuilder<FlavorEntity> builder)
        {
            builder.ToTable("PEDIDO_SABOR");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                   .HasColumnName("ID");

            builder.Property(e => e.UpdateAt)
                   .HasColumnName("UPDATE_AT");

            builder.Property(e => e.CreateAt)
                    .HasColumnName("CREATE_AT");

            builder.Property(e => e.OrderId)
                   .HasColumnName("ID_PEDIDO");

            builder.Property(e => e.Name)
                   .IsRequired()
                   .HasMaxLength(50)
                   .HasColumnName("NOME");

            builder.Property(e => e.Price)
                   .HasColumnName("PRECO");

            builder.Property(e => e.PrepTime)
                   .HasColumnName("TEMPO_PREPARO");
        }
    }
}