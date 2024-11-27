namespace program;

/// <summary>
/// Representa un efecto especial que puede ser aplicado a un Pokémon durante una batalla.
/// </summary>
public class Efectos : IEfectos
{
    /// <summary>
    /// Obtiene o establece el nombre del efecto especial.
    /// </summary>
    public string Nombre { get; set; }

    /// <summary>
    /// Constructor de la clase Efectos.
    /// </summary>
    /// <param name="nombre">El nombre del efecto especial, como "Quemar" o "Paralizar".</param>
    public Efectos(string nombre)
    {
        Nombre = nombre;
    }
}