using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ProvinciaConfiguration : IEntityTypeConfiguration<Provincia>
    {
        public void Configure(EntityTypeBuilder<Provincia> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("provincia");

            builder.HasKey(e => e.IdCod);
            builder.Property(e => e.IdCod);

            builder.Property(p => p.Descripcion)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(p => p.Region)
            .WithMany(p => p.Provincias)
            .HasForeignKey(p => p.RegId);
        }
    }
}