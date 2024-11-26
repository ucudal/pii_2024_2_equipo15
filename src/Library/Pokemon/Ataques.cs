namespace program;

public class Ataques : IHabilidad
{
    public string Nombre { get; set; }
    public int Danio { get; set; }
    public int Poder { get; set; }
    public int Precision { get; set; } = 100; // Precisión por defecto
    public int Puntos_de_Poder { get; set; } = 15; // PP por defecto
    public bool EsDobleTurno { get; set; } = false;
    public bool EsEspecial { get; set; } = false; // Por defecto, no es un ataque especial
    public IEfectos Efectos { get; set; }

    public Ataques(string nombre, int danio, bool esEspecial = false, IEfectos efectos = null)
    {
        Nombre = nombre;
        Danio = danio;
        Poder = danio;
        EsEspecial = esEspecial;
        Efectos = efectos;
    }
}