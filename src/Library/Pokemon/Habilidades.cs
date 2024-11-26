namespace program;

public class Habilidades : IHabilidad
{
    public string Nombre { get; set; }
    public ITipo Tipo { get; set; }
    public int Danio { get; set; }
    public int Precision { get; set; }
    public int Puntos_de_Poder { get; set; }
    public bool EsDobleTurno { get; set; }
    public int Poder { get; set; } // Implementación de la propiedad Poder
    public IEfectos Efectos { get; set; }

    public Habilidades(string nombre, ITipo tipo, int danio, int precision, int puntosDePoder, bool esDobleTurno, IEfectos efectos = null, int poder = 100)
    {
        Nombre = nombre;
        Tipo = tipo;
        Danio = danio;
        Precision = precision;
        Puntos_de_Poder = puntosDePoder;
        EsDobleTurno = esDobleTurno;
        Poder = poder; // Inicializamos la propiedad Poder
        Efectos = efectos;
    }
}