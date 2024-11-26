namespace program
{
    public class BatallaActual
    {
        private List<Batalla> Partidas = new List<Batalla>();

        public Batalla CrearPartida(Entrenador entrenador1, Entrenador entrenador2)
        {
            Batalla partida = new Batalla(entrenador1, entrenador2);
            Partidas.Add(partida);
            return partida;
        }

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

        public bool TerminarPartida(Batalla partida)
        {
            foreach (Entrenador entrenador in partida.JugadoresDisponibles())
            {
                entrenador.EnBatalla = false;
            }
            return Partidas.Remove(partida);
        }

        public string DeterminarGanador(Batalla partida)
        {
            return partida.DeterminarGanador();
        }
    }
}