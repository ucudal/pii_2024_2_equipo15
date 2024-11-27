namespace program
{
    /// <summary>
    /// Representa un objeto que puede ser utilizado en un Pokémon durante una batalla.
    /// </summary>
    public class Objeto
    {
        /// <summary>
        /// Obtiene el nombre del objeto.
        /// </summary>
        public string Nombre { get; }

        /// <summary>
        /// Acción que define el efecto que este objeto aplica sobre un Pokémon.
        /// </summary>
        public Action<Pokemon> AplicarEfecto { get; }

        /// <summary>
        /// Constructor de la clase <see cref="Objeto"/>.
        /// </summary>
        /// <param name="nombre">El nombre del objeto.</param>
        /// <param name="aplicarEfecto">La acción que representa el efecto que el objeto aplica en un Pokémon.</param>
        public Objeto(string nombre, Action<Pokemon> aplicarEfecto)
        {
            Nombre = nombre;
            AplicarEfecto = aplicarEfecto;
        }

        /// <summary>
        /// Usa el objeto en el Pokémon objetivo, aplicando el efecto definido.
        /// </summary>
        /// <param name="objetivo">El Pokémon sobre el que se aplica el efecto del objeto.</param>
        /// <returns>Un mensaje indicando el resultado del uso del objeto.</returns>
        public string Usar(Pokemon objetivo)
        {
            AplicarEfecto(objetivo);
            return $"{Nombre} fue usado en {objetivo.Nombre}.";
        }
    }
}