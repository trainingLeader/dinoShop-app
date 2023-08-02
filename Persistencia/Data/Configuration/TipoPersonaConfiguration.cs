using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>
    {
        public void Configure(EntityTypeBuilder<TipoPersona> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("tipopersona");

            builder.HasKey(e => e.IdCod);
            builder.Property(e => e.IdCod);

            builder.Property(p => p.Descripcion)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}