namespace Dominio;

public class Marca
{
    public int IdMarca { get; set; }
    public string DecripcionMarca { get; set; }
    public ICollection<Producto> Productos { get; set; }
}
