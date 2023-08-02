using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class RegionConfiguration : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.ToTable("region");

            builder.HasKey(e => e.IdCod);
            builder.Property(e => e.IdCod);

            builder.Property(e => e.Descripcion)
            .HasMaxLength(50);

            builder.HasOne(p => p.Pais)
            .WithMany(p => p.Regiones)
            .HasForeignKey(p => p.PaisId);
            
        }
    }
}