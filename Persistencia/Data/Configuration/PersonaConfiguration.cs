using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("persona");

            builder.HasKey(e => e.IdPersona);
            builder.Property(e => e.IdPersona)
            .HasMaxLength(12);

            builder.Property(p => p.NombrePersona)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.ApellidoPersona)
            .IsRequired()
            .HasMaxLength(50);
            
            builder.Property(e => e.EdadPersona)
            .HasColumnType("int");

            builder.HasOne(p => p.Provincia)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.ProvId);

            builder.HasOne(p => p.TipoPersona)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.TipoPerId);
        }
    }
}
