namespace program
{
    /// <summary>
    /// Representa una batalla entre dos entrenadores Pokémon.
    /// </summary>
    public class Batalla
    {
        private Entrenador entrenador1;
        private Entrenador entrenador2;
        public Entrenador entrenadorActual;
        private Entrenador entrenadorEnEspera;
        private Dictionary<string, int> turnosEspeciales; // Control de enfriamiento para ataques especiales

        /// <summary>
        /// Lista estática que contiene los nombres de los Pokémon seleccionados en la batalla.
        /// </summary>
        public static List<string> PokemonesSeleccionados = new List<string>();

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Batalla"/>.
        /// </summary>
        /// <param name="jugador1">El primer entrenador participante.</param>
        /// <param name="jugador2">El segundo entrenador participante.</param>
        public Batalla(Entrenador jugador1, Entrenador jugador2)
        {
            entrenador1 = jugador1;
            entrenador2 = jugador2;
            turnosEspeciales = new Dictionary<string, int>
            {
                { jugador1.Nombre, 0 },
                { jugador2.Nombre, 0 }
            };

            // Determinar el entrenador que inicia el turno basado en la velocidad del Pokémon activo.
            if (jugador1.PokemonActivo.Velocidad >= jugador2.PokemonActivo.Velocidad)
            {
                entrenadorActual = jugador1;
                entrenadorEnEspera = jugador2;
            }
            else
            {
                entrenadorActual = jugador2;
                entrenadorEnEspera = jugador1;
            }
        }

        /// <summary>
        /// Inicia la batalla entre los entrenadores y determina quién comienza.
        /// </summary>
        /// <returns>Un mensaje indicando el inicio de la batalla y el entrenador que empieza.</returns>
        public string IniciarBatalla()
        {
            return $"{entrenador1.Nombre} y {entrenador2.Nombre} están listos para la batalla. ¡{entrenadorActual.Nombre} comienza!";
        }

        /// <summary>
        /// Realiza un turno de batalla, permitiendo atacar o cambiar de Pokémon.
        /// </summary>
        /// <param name="habilidad">La habilidad utilizada por el Pokémon (opcional).</param>
        /// <param name="cambio">El nuevo Pokémon al que se desea cambiar (opcional).</param>
        /// <returns>El resultado de la acción realizada en el turno.</returns>
        public string RealizarTurno(IHabilidad habilidad = null, Pokemon cambio = null)
        {
            if (cambio != null)
            {
                return CambiarPokemon(cambio);
            }

            if (habilidad != null)
            {
                if (habilidad.EsEspecial && turnosEspeciales[entrenadorActual.Nombre] > 0)
                {
                    return $"No puedes usar ataques especiales aún. Debes esperar {turnosEspeciales[entrenadorActual.Nombre]} turno(s).";
                }

                string resultado = Atacar(habilidad);

                if (habilidad.EsEspecial)
                {
                    turnosEspeciales[entrenadorActual.Nombre] = 2; // Configura el enfriamiento a 2 turnos
                }

                ReducirTurnosEspeciales();
                return resultado;
            }

            return "No se realizó ninguna acción.";
        }

        /// <summary>
        /// Realiza un ataque del Pokémon actual al Pokémon del oponente.
        /// </summary>
        /// <param name="habilidad">La habilidad que el Pokémon utiliza para atacar.</param>
        /// <returns>Un mensaje indicando el resultado del ataque.</returns>
        private string Atacar(IHabilidad habilidad)
        {
            Pokemon atacante = entrenadorActual.PokemonActivo;
            Pokemon defensor = entrenadorEnEspera.PokemonActivo;

            if (!string.IsNullOrEmpty(atacante.Estado) && atacante.Estado == "paralizado" && new Random().Next(0, 100) < 25)
            {
                CambiarTurno();
                return $"{atacante.Nombre} está paralizado y no puede moverse.";
            }

            if (new Random().Next(0, 100) > habilidad.Precision)
            {
                CambiarTurno();
                return $"{atacante.Nombre} intentó usar {habilidad.Nombre}, ¡pero falló!";
            }

            // Cálculo del daño, efectividad, y críticos
            double efectividad = 1.0; // Por defecto, se asume efectividad neutra
            double critico = new Random().Next(0, 100) < 10 ? 1.5 : 1.0;
            double aleatorio = new Random().NextDouble() * (1.0 - 0.85) + 0.85;

            int daño = (int)((habilidad.Danio * (atacante.Velocidad / (double)defensor.Velocidad) + 2) * efectividad * critico * aleatorio);
            defensor.Vida -= daño;

            if (defensor.Vida <= 0)
            {
                defensor.Vida = 0;

                if (!entrenadorEnEspera.TienePokemonesVivos())
                {
                    return $"{atacante.Nombre} usó {habilidad.Nombre} y derrotó a {defensor.Nombre}. ¡{entrenadorActual.Nombre} gana la batalla!";
                }

                CambiarTurno();
                return $"{atacante.Nombre} usó {habilidad.Nombre} y derrotó a {defensor.Nombre}.";
            }

            CambiarTurno();
            return $"{atacante.Nombre} usó {habilidad.Nombre} y causó {daño} puntos de daño a {defensor.Nombre}. Vida restante: {defensor.Vida}.";
        }

        /// <summary>
        /// Cambia el Pokémon activo por otro en el equipo.
        /// </summary>
        /// <param name="nuevoPokemon">El nuevo Pokémon a activar.</param>
        /// <returns>Un mensaje indicando el resultado del cambio.</returns>
        public string CambiarPokemon(Pokemon nuevoPokemon)
        {
            if (nuevoPokemon.Vida <= 0)
            {
                return $"{nuevoPokemon.Nombre} está debilitado y no puede ser seleccionado.";
            }

            if (entrenadorActual.PokemonActivo != null)
            {
                PokemonesSeleccionados.Remove(entrenadorActual.PokemonActivo.Nombre);
            }

            entrenadorActual.PokemonActivo = nuevoPokemon;
            PokemonesSeleccionados.Add(nuevoPokemon.Nombre);

            return $"{entrenadorActual.Nombre} cambió a {nuevoPokemon.Nombre}.";
        }

        /// <summary>
        /// Cambia el turno entre los entrenadores.
        /// </summary>
        private void CambiarTurno()
        {
            var temp = entrenadorActual;
            entrenadorActual = entrenadorEnEspera;
            entrenadorEnEspera = temp;
        }

        /// <summary>
        /// Reduce los turnos restantes de enfriamiento para los ataques especiales.
        /// </summary>
        private void ReducirTurnosEspeciales()
        {
            foreach (var entrenador in turnosEspeciales.Keys.ToList())
            {
                if (turnosEspeciales[entrenador] > 0)
                {
                    turnosEspeciales[entrenador]--;
                }
            }
        }

        /// <summary>
        /// Determina el ganador de la batalla.
        /// </summary>
        /// <returns>El nombre del ganador o un mensaje indicando que la batalla continúa.</returns>
        public string DeterminarGanador()
        {
            if (!entrenador1.TienePokemonesVivos()) return $"{entrenador2.Nombre} gana la batalla!";
            if (!entrenador2.TienePokemonesVivos()) return $"{entrenador1.Nombre} gana la batalla!";
            return "La batalla continúa...";
        }

        /// <summary>
        /// Verifica si un entrenador específico está en esta batalla.
        /// </summary>
        /// <param name="nombreEntrenador">El nombre del entrenador a verificar.</param>
        /// <returns>True si el entrenador está en la batalla, de lo contrario false.</returns>
        public bool ContieneEntrenador(string nombreEntrenador)
        {
            return entrenador1.Nombre == nombreEntrenador || entrenador2.Nombre == nombreEntrenador;
        }

        /// <summary>
        /// Devuelve una lista de los entrenadores participantes en la batalla.
        /// </summary>
        /// <returns>Una lista de entrenadores.</returns>
        public List<Entrenador> JugadoresDisponibles()
        {
            return new List<Entrenador> { entrenador1, entrenador2 };
        }

        /// <summary>
        /// Muestra el turno actual en la batalla.
        /// </summary>
        /// <returns>Un mensaje indicando de quién es el turno actual.</returns>
        public string MostrarTurnoActual()
        {
            return $"Es el turno de {entrenadorActual.Nombre} con {entrenadorActual.PokemonActivo.Nombre}.";
        }
    }
}
