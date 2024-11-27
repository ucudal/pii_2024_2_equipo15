namespace program
{
    /// <summary>
    /// Administra las batallas activas entre entrenadores.
    /// </summary>
    public class BatallaActual
    {
        /// <summary>
        /// Lista de todas las batallas activas.
        /// </summary>
        private List<Batalla> Partidas = new List<Batalla>();

        /// <summary>
        /// Crea una nueva batalla entre dos entrenadores.
        /// </summary>
        /// <param name="entrenador1">El primer entrenador participante.</param>
        /// <param name="entrenador2">El segundo entrenador participante.</param>
        /// <returns>La nueva instancia de la batalla creada.</returns>
        public Batalla CrearPartida(Entrenador entrenador1, Entrenador entrenador2)
        {
            Batalla partida = new Batalla(entrenador1, entrenador2);
            Partidas.Add(partida);
            return partida;
        }

        /// <summary>
        /// Busca una batalla en la que participe un entrenador específico.
        /// </summary>
        /// <param name="entrenador">El entrenador que se desea buscar en las batallas activas.</param>
        /// <returns>La batalla en la que participa el entrenador, o null si no está en ninguna batalla.</returns>
        public Batalla? BatallaPorEntrenador(Entrenador entrenador)
        {
            foreach (Batalla batalla in Partidas)
            {
                if (batalla.JugadoresDisponibles().Contains(entrenador))
                {
                    return batalla;
                }
            }
            return null;
        }

        /// <summary>
        /// Termina una batalla activa y elimina a los entrenadores de la batalla.
        /// </summary>
        /// <param name="partida">La batalla que se desea finalizar.</param>
        /// <returns>True si la batalla fue eliminada correctamente; de lo contrario, false.</returns>
        public bool TerminarPartida(Batalla partida)
        {
            foreach (Entrenador entrenador in partida.JugadoresDisponibles())
            {
                entrenador.EnBatalla = false;
            }
            return Partidas.Remove(partida);
        }

        /// <summary>
        /// Determina el ganador de una batalla específica.
        /// </summary>
        /// <param name="partida">La batalla para la cual se desea determinar el ganador.</param>
        /// <returns>El nombre del ganador o un mensaje indicando el estado de la batalla.</returns>
        public string DeterminarGanador(Batalla partida)
        {
            return partida.DeterminarGanador();
        }
    }
}
