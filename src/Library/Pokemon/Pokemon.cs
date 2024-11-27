namespace program
{
    /// <summary>
    /// Representa un Pokémon con estadísticas, habilidades y estados especiales.
    /// </summary>
    public class Pokemon : IPokemon
    {
        /// <summary>
        /// Nombre del Pokémon.
        /// </summary>
        public string Nombre { get; }

        /// <summary>
        /// Puntos de vida actuales del Pokémon.
        /// </summary>
        public int Vida { get; set; }

        /// <summary>
        /// Puntos de vida base del Pokémon.
        /// </summary>
        public int VidaBase { get; set; }

        /// <summary>
        /// Velocidad del Pokémon, utilizada para determinar el orden de turno.
        /// </summary>
        public int Velocidad { get; set; }

        /// <summary>
        /// Estadística de ataque del Pokémon.
        /// </summary>
        public int Ataque { get; set; }

        /// <summary>
        /// Estadística de defensa del Pokémon.
        /// </summary>
        public int Defensa { get; set; }

        /// <summary>
        /// Lista de habilidades que el Pokémon puede usar en batalla.
        /// </summary>
        public List<IHabilidad> Habilidades { get; }

        /// <summary>
        /// Tipo principal del Pokémon, utilizado para calcular efectividad en batalla.
        /// </summary>
        public ITipo TipoPrincipal { get; }

        /// <summary>
        /// Habilidad que el Pokémon está cargando, si aplica.
        /// </summary>
        public IHabilidad HabilidadCargando { get; set; }

        /// <summary>
        /// Estado especial actual del Pokémon (por ejemplo: paralizado, dormido, etc.).
        /// </summary>
        public string Estado { get; set; }

        /// <summary>
        /// Duración restante del estado especial aplicado al Pokémon.
        /// </summary>
        public int DuracionEstado { get; set; }

        /// <summary>
        /// Constructor que inicializa un Pokémon con sus estadísticas y estado inicial.
        /// </summary>
        /// <param name="nombre">Nombre del Pokémon.</param>
        /// <param name="vida">Puntos de vida iniciales.</param>
        /// <param name="velocidad">Velocidad del Pokémon.</param>
        /// <param name="ataque">Estadística de ataque.</param>
        /// <param name="defensa">Estadística de defensa.</param>
        /// <param name="estado">Estado inicial del Pokémon (opcional).</param>
        public Pokemon(string nombre, int vida, int velocidad, int ataque, int defensa, string estado = null)
        {
            Nombre = nombre;
            Vida = vida;
            VidaBase = vida;
            Velocidad = velocidad;
            Ataque = ataque;
            Defensa = defensa;
            Habilidades = new List<IHabilidad>();
            HabilidadCargando = null;
            Estado = estado;
            DuracionEstado = 0; // Por defecto, sin estado especial
        }

        /// <summary>
        /// Permite al Pokémon aprender una nueva habilidad.
        /// </summary>
        /// <param name="habilidad">La habilidad que el Pokémon aprenderá.</param>
        public void AprenderHabilidad(IHabilidad habilidad)
        {
            Habilidades.Add(habilidad);
        }

        /// <summary>
        /// Muestra todas las habilidades que el Pokémon conoce, con sus detalles.
        /// </summary>
        /// <returns>Una cadena que describe las habilidades del Pokémon.</returns>
        public string MostrarHabilidades()
        {
            string resultado = "";

            for (int i = 0; i < Habilidades.Count; i++)
            {
                var habilidad = Habilidades[i];
                resultado += $"**{i + 1}. {habilidad.Nombre}** | Daño: {habilidad.Danio} | Precisión: {habilidad.Precision} | PP: {habilidad.Puntos_de_Poder} | Ataque Cargado: *{habilidad.EsDobleTurno}*\n";
            }

            return resultado;
        }

        /// <summary>
        /// Obtiene una habilidad por su nombre.
        /// </summary>
        /// <param name="nombreHabilidad">El nombre de la habilidad que se desea buscar.</param>
        /// <returns>La habilidad si existe, o <c>null</c> si no se encuentra.</returns>
        public IHabilidad? ObtenerHabilidad(string nombreHabilidad)
        {
            return Habilidades.FirstOrDefault(habilidad => habilidad.Nombre.Equals(nombreHabilidad, StringComparison.OrdinalIgnoreCase));
        }
    }
}
