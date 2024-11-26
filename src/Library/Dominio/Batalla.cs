namespace program
{
    public class Batalla
    {
        private Entrenador entrenador1;
        private Entrenador entrenador2;
        private Entrenador entrenadorActual;
        private Entrenador entrenadorEnEspera;

        public Batalla(Entrenador jugador1, Entrenador jugador2)
        {
            entrenador1 = jugador1;
            entrenador2 = jugador2;

            // Determinar quién tiene el primer turno basado en la velocidad del Pokémon inicial
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
                return Atacar(habilidad);
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

            double efectividad = habilidad.Tipo.EsEfectivoOPocoEfectivo(defensor.TipoPrincipal);
            if (defensor.TipoSecundario != null)
            {
                efectividad *= habilidad.Tipo.EsEfectivoOPocoEfectivo(defensor.TipoSecundario);
            }

            double critico = new Random().Next(0, 100) < 10 ? 1.5 : 1.0;
            double aleatorio = new Random().NextDouble() * (1.0 - 0.85) + 0.85;

            int daño = (int)((habilidad.Poder * (atacante.Ataque / (double)defensor.Defensa) + 2) * efectividad * critico * aleatorio);
            defensor.Vida -= daño;

            if (defensor.Vida <= 0)
            {
                defensor.Vida = 0;
                CambiarTurno();
                return $"{atacante.Nombre} usó {habilidad.Nombre} y derrotó a {defensor.Nombre}!";
            }

            CambiarTurno();
            return $"{atacante.Nombre} usó {habilidad.Nombre} y causó {daño} puntos de daño a {defensor.Nombre}. Vida restante: {defensor.Vida}.";
        }

        private string CambiarPokemon(Pokemon nuevoPokemon)
        {
            if (nuevoPokemon == null || !entrenadorActual.Pokemones.Contains(nuevoPokemon))
            {
                return "Ese Pokémon no está en tu equipo.";
            }

            entrenadorActual.PokemonActivo = nuevoPokemon;
            CambiarTurno();
            return $"{entrenadorActual.Nombre} cambió a {nuevoPokemon.Nombre}!";
        }

        private void CambiarTurno()
        {
            var temp = entrenadorActual;
            entrenadorActual = entrenadorEnEspera;
            entrenadorEnEspera = temp;
        }

        public string DeterminarGanador()
        {
            if (!entrenador1.TienePokemonesVivos()) return $"{entrenador2.Nombre} gana la batalla!";
            if (!entrenador2.TienePokemonesVivos()) return $"{entrenador1.Nombre} gana la batalla!";
            return "La batalla continúa...";
        }

        // MÉTODO RESTAURADO: ContieneEntrenador
        public bool ContieneEntrenador(string nombreEntrenador)
        {
            return entrenador1.Nombre == nombreEntrenador || entrenador2.Nombre == nombreEntrenador;
        }

        // NUEVO MÉTODO: JugadoresDisponibles
        public List<Entrenador> JugadoresDisponibles()
        {
            return new List<Entrenador> { entrenador1, entrenador2 };
        }
    }
}
