using System.ComponentModel.DataAnnotations;

namespace Dominio;

public class Provincia : BaseEntity
{
        public string Descripcion { get; set; }
        public int RegId { get; set; }
        public Region Region { get; set; }
        public ICollection<Persona> Personas { get; set; }
}
