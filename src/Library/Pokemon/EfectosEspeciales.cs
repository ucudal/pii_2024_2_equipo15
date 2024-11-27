namespace program;

/// <summary>
/// Representa un efecto especial que puede ser aplicado a un Pokémon durante una batalla.
/// </summary>
public class EfectoEspeciales
{
    /// <summary>
    /// Obtiene el nombre del efecto especial.
    /// </summary>
    /// <example>Ejemplos de nombres incluyen "Quemar", "Paralizar", "Dormir".</example>
    public string Nombre { get; }

    /// <summary>
    /// Define la acción que se ejecutará al aplicar el efecto especial al Pokémon.
    /// </summary>
    /// <remarks>
    /// Esta acción puede ser cualquier lógica personalizada que afecte al Pokémon, 
    /// como reducir su salud o cambiar su estado.
    /// </remarks>
    public Action<Pokemon> AplicarEfecto { get; }

    /// <summary>
    /// Constructor de la clase EfectoEspeciales.
    /// </summary>
    /// <param name="nombre">El nombre del efecto especial.</param>
    /// <param name="aplicarEfecto">Una acción que define cómo se aplica el efecto especial a un Pokémon.</param>
    public EfectoEspeciales(string nombre, Action<Pokemon> aplicarEfecto)
    {
        Nombre = nombre;
        AplicarEfecto = aplicarEfecto;
    }
}