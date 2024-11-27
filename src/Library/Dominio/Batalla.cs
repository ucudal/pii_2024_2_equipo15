namespace program
{
    public class Batalla
    {
        private Entrenador entrenador1;
        private Entrenador entrenador2;
        private Entrenador entrenadorActual;
        private Entrenador entrenadorEnEspera;
        private Dictionary<string, int> turnosEspeciales; // Control de enfriamiento para ataques especiales

        public Batalla(Entrenador jugador1, Entrenador jugador2)
        {
            entrenador1 = jugador1;
            entrenador2 = jugador2;
            turnosEspeciales = new Dictionary<string, int>
            {
                { jugador1.Nombre, 0 },
                { jugador2.Nombre, 0 }
            };

            // Determinar quién inicia el turno basado en la velocidad del Pokémon activo
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

        public string IniciarBatalla()
        {
            return $"{entrenador1.Nombre} y {entrenador2.Nombre} están listos para la batalla. ¡{entrenadorActual.Nombre} comienza!";
        }

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

            // Calcular la efectividad basándose solo en el tipo principal
            double efectividad = 1.0; // Si habilidad.Tipo no está disponible, consideramos una efectividad neutral (1.0).

            // Cálculo de daño con crítico y variación aleatoria
            double critico = new Random().Next(0, 100) < 10 ? 1.5 : 1.0;
            double aleatorio = new Random().NextDouble() * (1.0 - 0.85) + 0.85;

            int daño = (int)((habilidad.Danio * (atacante.Velocidad / (double)defensor.Velocidad) + 2) * efectividad * critico * aleatorio);
            defensor.Vida -= daño;

            if (defensor.Vida <= 0)
            {
                defensor.Vida = 0;

                // Verificar si el equipo contrario tiene más Pokémon vivos
                if (!entrenadorEnEspera.TienePokemonesVivos())
                {
                    return $"{atacante.Nombre} usó {habilidad.Nombre} y derrotó a {defensor.Nombre}. ¡{entrenadorActual.Nombre} gana la batalla!";
                }

                CambiarTurno();
                return $"{atacante.Nombre} usó {habilidad.Nombre} y derrotó a {defensor.Nombre}!";
            }

            CambiarTurno();
            return $"{atacante.Nombre} usó {habilidad.Nombre} y causó {daño} puntos de daño a {defensor.Nombre}. Vida restante: {defensor.Vida}.";
        }
        public static List<string> PokemonesSeleccionados = new List<string>();


        public string CambiarPokemon(Pokemon nuevoPokemon)
        {
            if (nuevoPokemon.Vida <= 0)
            {
                return $"{nuevoPokemon.Nombre} está debilitado y no puede ser seleccionado.";
            }

            // Liberar el Pokémon activo actual
            if (entrenadorActual.PokemonActivo != null)
            {
                // Eliminar el nombre del Pokémon activo actual de la lista de seleccionados
                Batalla.PokemonesSeleccionados.Remove(entrenadorActual.PokemonActivo.Nombre);
            }

            // Asignar el nuevo Pokémon
            entrenadorActual.PokemonActivo = nuevoPokemon;
            Batalla.PokemonesSeleccionados.Add(nuevoPokemon.Nombre);

            return $"{entrenadorActual.Nombre} cambió a {nuevoPokemon.Nombre}.";
        }

        private void CambiarTurno()
        {
            var temp = entrenadorActual;
            entrenadorActual = entrenadorEnEspera;
            entrenadorEnEspera = temp;
        }

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

        public string DeterminarGanador()
        {
            if (!entrenador1.TienePokemonesVivos()) return $"{entrenador2.Nombre} gana la batalla!";
            if (!entrenador2.TienePokemonesVivos()) return $"{entrenador1.Nombre} gana la batalla!";
            return "La batalla continúa...";
        }

        public bool ContieneEntrenador(string nombreEntrenador)
        {
            return entrenador1.Nombre == nombreEntrenador || entrenador2.Nombre == nombreEntrenador;
        }

        public List<Entrenador> JugadoresDisponibles()
        {
            return new List<Entrenador> { entrenador1, entrenador2 };
        }

        public string MostrarTurnoActual()
        {
            return $"Es el turno de {entrenadorActual.Nombre} con {entrenadorActual.PokemonActivo.Nombre}.";
        }
    }
}
