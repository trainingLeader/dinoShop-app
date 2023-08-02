namespace Dominio;
    public class Region : BaseEntity
    {
        public string Descripcion { get; set; }
        public int PaisId { get; set; }
        public Pais Pais { get; set; }
        public ICollection<Provincia> Provincias { get; set; }
    }
