using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class PaisConfiguration : IEntityTypeConfiguration<Pais>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Pais> builder)
    {
        builder.ToTable("pais");

        builder.HasKey(e => e.IdCod);
        builder.Property(e => e.IdCod);

        builder.Property(e => e.NombrePais)
        .HasMaxLength(50);
    }

}
