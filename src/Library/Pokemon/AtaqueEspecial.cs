namespace program;

/// <summary>
/// Representa un ataque que un Pokémon puede usar durante la batalla.
/// </summary>
public class Ataque
{
    /// <summary>
    /// Obtiene el nombre del ataque.
    /// </summary>
    public string Nombre { get; }

    /// <summary>
    /// Obtiene la cantidad de daño base que causa el ataque.
    /// </summary>
    public int Danio { get; }

    /// <summary>
    /// Obtiene la precisión del ataque, representada como un porcentaje entre 0 y 100.
    /// </summary>
    public int Precision { get; }

    /// <summary>
    /// Indica si el ataque es especial.
    /// </summary>
    public bool EsEspecial { get; }

    /// <summary>
    /// Obtiene el efecto especial que el ataque puede aplicar (si corresponde).
    /// </summary>
    public EfectoEspeciales? Efecto { get; }

    /// <summary>
    /// Ejecuta el ataque, calculando si impacta, aplicando daño y efectos especiales según corresponda.
    /// </summary>
    /// <param name="atacante">El Pokémon que realiza el ataque.</param>
    /// <param name="defensor">El Pokémon que recibe el ataque.</param>
    /// <returns>Un mensaje que describe el resultado del ataque.</returns>
    public string Usar(Pokemon atacante, Pokemon defensor)
    {
        Random random = new Random();
        if (random.Next(0, 100) >= Precision)
        {
            return $"{atacante.Nombre} intento usar {Nombre}, pero fallo";
        }

        if (EsEspecial && Efecto != null && string.IsNullOrEmpty(defensor.Estado))
        {
            Efecto.AplicarEfecto(defensor);
            return $"{atacante.Nombre} uso {Nombre} y aplicó el efecto {Efecto.Nombre} en {defensor.Nombre}.";
        }

        // Daño con posibilidad de crítico
        double multiplicadorCritico = random.Next(0, 100) < 10 ? 1.2 : 1.0;
        int danioRealizado = (int)(Danio * multiplicadorCritico);
        defensor.Vida -= danioRealizado;
        defensor.Vida = Math.Max(defensor.Vida, 0);

        return $"{atacante.Nombre} usó {Nombre} causando {danioRealizado} puntos de daño. {defensor.Nombre} tiene {defensor.Vida}/{defensor.VidaBase} de vida restante.";
    }
}
