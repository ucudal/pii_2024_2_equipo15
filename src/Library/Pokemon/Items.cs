namespace program
{
    /// <summary>
    /// Representa un objeto que puede ser utilizado en un Pokémon
    /// para aplicar efectos específicos.
    /// </summary>
    public class Objeto
    {
        /// <summary>
        /// Obtiene el nombre del objeto.
        /// </summary>
        public string Nombre { get; }

        /// <summary>
        /// Obtiene la acción que define el efecto que el objeto aplica
        /// al Pokémon objetivo.
        /// </summary>
        public Action<Pokemon> AplicarEfecto { get; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Objeto"/>
        /// con un nombre y una acción que representa su efecto.
        /// </summary>
        /// <param name="nombre">El nombre del objeto.</param>
        /// <param name="aplicarEfecto">
        /// La acción que define el efecto del objeto al ser usado en un Pokémon.
        /// </param>
        public Objeto(string nombre, Action<Pokemon> aplicarEfecto)
        {
            Nombre = nombre;
            AplicarEfecto = aplicarEfecto;
        }

        /// <summary>
        /// Usa el objeto en un Pokémon objetivo y aplica su efecto.
        /// </summary>
        /// <param name="objetivo">El Pokémon sobre el cual se usará el objeto.</param>
        /// <returns>Un mensaje indicando que el objeto fue usado en el Pokémon.</returns>
        public string Usar(Pokemon objetivo)
        {
            AplicarEfecto(objetivo);
            return $"{Nombre} fue usado en {objetivo.Nombre}.";
        }
    }
}