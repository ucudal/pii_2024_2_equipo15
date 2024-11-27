namespace program
{
    /// <summary>
    /// Representa una habilidad que un Pokémon puede usar durante una batalla.
    /// </summary>
    public class Habilidades : IHabilidad
    {
        /// <summary>
        /// Obtiene o establece el nombre de la habilidad.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Obtiene o establece la cantidad de daño que causa la habilidad.
        /// </summary>
        public int Danio { get; set; }

        /// <summary>
        /// Obtiene o establece la precisión de la habilidad en porcentaje.
        /// </summary>
        /// <remarks>
        /// Una precisión de 100 significa que el ataque nunca fallará, salvo condiciones especiales.
        /// </remarks>
        public int Precision { get; set; }

        /// <summary>
        /// Obtiene o establece la cantidad de puntos de poder (PP) disponibles para la habilidad.
        /// </summary>
        /// <remarks>
        /// Representa el número de veces que la habilidad puede ser usada.
        /// </remarks>
        public int Puntos_de_Poder { get; set; }

        /// <summary>
        /// Indica si la habilidad requiere dos turnos para ejecutarse.
        /// </summary>
        public bool EsDobleTurno { get; set; }

        /// <summary>
        /// Obtiene o establece el poder base de la habilidad.
        /// </summary>
        /// <remarks>
        /// El poder determina la efectividad del daño en combinación con otros factores como la defensa del objetivo.
        /// </remarks>
        public int Poder { get; set; }

        /// <summary>
        /// Obtiene o establece el efecto especial asociado a la habilidad, si lo tiene.
        /// </summary>
        public IEfectos Efectos { get; set; }

        /// <summary>
        /// Indica si la habilidad es especial o no.
        /// </summary>
        /// <remarks>
        /// Una habilidad especial puede aplicar efectos adicionales como quemar, paralizar, etc.
        /// </remarks>
        public bool EsEspecial { get; set; }

        /// <summary>
        /// Constructor de la clase <see cref="Habilidades"/>.
        /// </summary>
        /// <param name="nombre">El nombre de la habilidad.</param>
        /// <param name="danio">El daño base de la habilidad.</param>
        /// <param name="esDobleTurno">Indica si la habilidad requiere dos turnos para ejecutarse.</param>
        /// <param name="esEspecial">Indica si la habilidad es especial (por defecto, <c>false</c>).</param>
        /// <remarks>
        /// La precisión y los puntos de poder tienen valores predeterminados: precisión de 100 y 15 puntos de poder.
        /// </remarks>
        public Habilidades(string nombre, int danio, bool esDobleTurno, bool esEspecial = false)
        {
            Nombre = nombre;
            Danio = danio;
            EsDobleTurno = esDobleTurno;
            EsEspecial = esEspecial;
            Precision = 100;
            Puntos_de_Poder = 15;
        }
    }
}
