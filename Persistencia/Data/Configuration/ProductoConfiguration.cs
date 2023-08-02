using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("producto");

            builder.HasKey(e => e.IdCod);
            builder.Property(e => e.IdCod );

            builder.Property(p => p.DescripcionProducto)
            .IsRequired()
            .HasMaxLength(60);

            builder.Property(e => e.DctoProducto)
            .HasColumnType("double");

            builder.Property(e => e.PrecioProducto)
            .HasColumnType("double");

            builder.Property(p => p.RefProducto)
            .IsRequired()
            .HasMaxLength(30);

            builder.HasOne(p => p.Marca)
            .WithMany(p => p.Productos)
            .HasForeignKey(p => p.MarcaId);

        }
    }
}