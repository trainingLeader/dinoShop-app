namespace Dominio;
public class Producto
{
     public int IdProducto { get; set; }
     public string RefProducto { get; set; }
     public string DescripcionProducto { get; set; }
     public double PrecioProducto { get; set; }
     public double DctoProducto { get; set; }
     public int MarcaId { get; set; }
     public Marca Marca { get; set; }
     public ICollection<PersonaProducto> PersonaProductos { get; set; }
}
