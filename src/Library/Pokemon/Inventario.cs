namespace program
{
    /// <summary>
    /// Representa el inventario de objetos que un entrenador puede utilizar.
    /// Permite gestionar el uso de objetos y su disponibilidad.
    /// </summary>
    public class Inventario
    {
        // Diccionario para almacenar los objetos disponibles y sus cantidades.
        private Dictionary<string, int> objetos;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Inventario"/>
        /// con un conjunto predeterminado de objetos y sus cantidades.
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
        /// Usa un objeto específico en un Pokémon objetivo.
        /// Reduce la cantidad disponible del objeto en el inventario
        /// y aplica sus efectos al Pokémon.
        /// </summary>
        /// <param name="nombreObjeto">El nombre del objeto a usar.</param>
        /// <param name="objetivo">El Pokémon sobre el cual se usará el objeto.</param>
        /// <returns>Un mensaje indicando el resultado de usar el objeto.</returns>
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
        /// Muestra el contenido del inventario, incluyendo los nombres de los objetos
        /// y las cantidades disponibles de cada uno.
        /// </summary>
        /// <returns>Una cadena con la lista de objetos y sus cantidades.</returns>
        public string MostrarInventario()
        {
            return string.Join("\n", objetos.Select(o => $"{o.Key}: {o.Value} unidades"));
        }
    }
}
