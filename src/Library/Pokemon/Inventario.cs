namespace program
{
    /// <summary>
    /// Representa un inventario que contiene objetos que pueden ser usados en una batalla.
    /// </summary>
    public class Inventario
    {
        /// <summary>
        /// Diccionario que almacena los objetos disponibles en el inventario junto con sus cantidades.
        /// </summary>
        private Dictionary<string, int> objetos;

        /// <summary>
        /// Constructor de la clase <see cref="Inventario"/>.
        /// Inicializa el inventario con objetos predeterminados.
        /// </summary>
        public Inventario()
        {
            objetos = new Dictionary<string, int>
            {
                { "Súper poción", 4 },
                { "Revivir", 1 },
                { "Cura total", 2 }
            };
        }

        /// <summary>
        /// Usa un objeto del inventario en un Pokémon objetivo.
        /// </summary>
        /// <param name="nombreObjeto">El nombre del objeto a usar.</param>
        /// <param name="objetivo">El Pokémon objetivo del objeto.</param>
        /// <returns>Un mensaje indicando el resultado del uso del objeto.</returns>
        /// <remarks>
        /// Los objetos disponibles son:
        /// - **Súper poción**: Recupera 70 puntos de vida.
        /// - **Revivir**: Revive a un Pokémon debilitado con el 50% de su HP máximo.
        /// - **Cura total**: Elimina cualquier estado especial del Pokémon.
        /// </remarks>
        public string UsarObjeto(string nombreObjeto, Pokemon objetivo)
        {
            if (!objetos.ContainsKey(nombreObjeto) || objetos[nombreObjeto] <= 0)
            {
                return $"No tienes {nombreObjeto} disponible.";
            }

            switch (nombreObjeto)
            {
                case "Súper poción":
                    objetivo.Vida += 70;
                    if (objetivo.Vida > objetivo.VidaBase) objetivo.Vida = objetivo.VidaBase;
                    break;

                case "Revivir":
                    if (objetivo.Vida > 0) return $"{objetivo.Nombre} no está debilitado.";
                    objetivo.Vida = objetivo.VidaBase / 2;
                    break;

                case "Cura total":
                    objetivo.Estado = null;
                    objetivo.DuracionEstado = 0; // Asegúrate de que esta propiedad exista
                    break;

                default:
                    return "Este objeto no puede ser usado.";
            }

            objetos[nombreObjeto]--;
            return $"{nombreObjeto} fue usado en {objetivo.Nombre}.";
        }

        /// <summary>
        /// Muestra el inventario actual con los objetos disponibles y sus cantidades.
        /// </summary>
        /// <returns>Una cadena con el listado de objetos y sus cantidades.</returns>
        public string MostrarInventario()
        {
            return string.Join("\n", objetos.Select(o => $"{o.Key}: {o.Value} unidades"));
        }
    }
}
