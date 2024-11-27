namespace program;

/// <summary>
/// Representa un ataque que un Pokémon puede realizar, con propiedades para daño, precisión, y efectos especiales.
/// </summary>
public class Ataques : IHabilidad
{
    /// <summary>
    /// Obtiene o establece el nombre del ataque.
    /// </summary>
    public string Nombre { get; set; }

    /// <summary>
    /// Obtiene o establece la cantidad de daño que el ataque realiza.
    /// </summary>
    public int Danio { get; set; }

    /// <summary>
    /// Obtiene o establece el poder base del ataque, equivalente al daño.
    /// </summary>
    public int Poder { get; set; }

    /// <summary>
    /// Obtiene o establece la precisión del ataque, representada como un porcentaje entre 0 y 100.
    /// </summary>
    public int Precision { get; set; } = 100;

    /// <summary>
    /// Obtiene o establece los puntos de poder (PP) del ataque, que indican cuántas veces puede usarse.
    /// </summary>
    public int Puntos_de_Poder { get; set; } = 15;

    /// <summary>
    /// Indica si el ataque requiere un turno adicional para ser ejecutado completamente.
    /// </summary>
    public bool EsDobleTurno { get; set; } = false;

    /// <summary>
    /// Indica si el ataque es especial, es decir, si tiene un efecto adicional o propiedades especiales.
    /// </summary>
    public bool EsEspecial { get; set; } = false;

    /// <summary>
    /// Obtiene o establece los efectos adicionales que este ataque puede aplicar al objetivo.
    /// </summary>
    public IEfectos Efectos { get; set; }

    /// <summary>
    /// Constructor de la clase Ataques.
    /// </summary>
    /// <param name="nombre">El nombre del ataque.</param>
    /// <param name="danio">La cantidad de daño que el ataque realiza.</param>
    /// <param name="esEspecial">Indica si el ataque es especial (por defecto, es falso).</param>
    /// <param name="efectos">Los efectos adicionales que puede aplicar el ataque (por defecto, ninguno).</param>
    public Ataques(string nombre, int danio, bool esEspecial = false, IEfectos efectos = null)
    {
        Nombre = nombre;
        Danio = danio;
        Poder = danio;
        EsEspecial = esEspecial;
        Efectos = efectos;
    }
}
