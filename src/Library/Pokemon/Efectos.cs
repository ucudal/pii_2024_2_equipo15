namespace program;

public class Efectos : IEfectos
{
    public string Nombre { get; set; }
    public Efectos(string nombre)
    {
        Nombre = nombre;
    }
}