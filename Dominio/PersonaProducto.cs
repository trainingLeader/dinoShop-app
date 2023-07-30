namespace Dominio;

public class PersonaProducto
{
    public int PersonaId { get; set; }
    public Persona Persona { get; set; }
    public int ProductoId { get; set; }
    public Producto Producto { get; set; }    
}
