using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
{
    public void Configure(EntityTypeBuilder<Marca> builder)
    {
        builder.ToTable("marca");

        builder.HasKey(e => e.IdMarca);
        builder.Property(e => e.IdMarca);

        builder.Property(e => e.DecripcionMarca)
        .HasMaxLength(50);
    }
}
