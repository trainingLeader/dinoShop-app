namespace Dominio;
public class Persona
{
    public int IdPersona { get; set; }
    public string NombrePersona { get; set; }
    public string ApellidoPersona { get; set; }
    public int EdadPersona { get; set; }
    public int ProvId { get; set; }
    public Provincia Provincia { get; set; }
    public int TipoPerId { get; set; }
    public TipoPersona TipoPersona { get; set; }
    public ICollection<PersonaProducto> PersonaProductos { get; set; }
        
}
