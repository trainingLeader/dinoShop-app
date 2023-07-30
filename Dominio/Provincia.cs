namespace Dominio;
public class Provincia
{
        public int IdRegion { get; set; }
        public string Descripcion { get; set; }
        public int RegId { get; set; }
        public Region Region { get; set; }
        public ICollection<Persona> Personas { get; set; }
}
