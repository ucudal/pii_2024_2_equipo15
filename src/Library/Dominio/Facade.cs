using System;
using System.Collections.Generic;

namespace program
{
    public static class Facade
    {
        private static Dictionary<string, Batalla> batallasActivas = new Dictionary<string, Batalla>();

        public static string MostrarPokemones()
        {
            return Logica.Instance.MostrarPokemones();
        }
        public static string MostrarAtaquesDePokemones()
        {
            return Logica.Instance.MostrarAtaquesDePokemones();
        }
        // Gestión de Entrenadores
        public static string IngresarUsuarioAlCentro(string nombre)
        {
            return GameManager.AgregarEntrenador(nombre);
        }

        public static string SacarEntrenadores(string nombre)
        {
            return GameManager.EliminarEntrenador(nombre);
        }

        public static string SeleccionarEquipo(string entrenador, string pokemonNombre)
        {
            Entrenador? jugador = GameManager.ObtenerEntrenador(entrenador);
            if (jugador == null) return "No estás registrado como entrenador.";

            Pokemon? pokemon = Logica.Instance.ObtenerPokemon(pokemonNombre);
            if (pokemon == null) return $"El Pokémon {pokemonNombre} no existe.";

            bool añadido = jugador.AñadirPokemon(pokemon);
            if (!añadido) return "No puedes añadir más Pokémon o ya tienes este Pokémon.";

            return $"{pokemonNombre} fue añadido al equipo de {entrenador}.";
        }

        public static string VerPokemones(string entrenador, string? oponente = null)
        {
            Entrenador? jugador = GameManager.ObtenerEntrenador(entrenador);
            if (jugador == null) return "No estás registrado como entrenador.";

            string respuesta = $"Equipo de {entrenador}:\n";
            foreach (var pokemon in jugador.Pokemones)
            {
                respuesta += $"- {pokemon.Nombre} (HP: {pokemon.Vida})\n";
            }

            if (!string.IsNullOrEmpty(oponente))
            {
                Entrenador? rival = GameManager.ObtenerEntrenador(oponente);
                if (rival != null)
                {
                    respuesta += $"\nEquipo de {oponente}:\n";
                    foreach (var pokemon in rival.Pokemones)
                    {
                        respuesta += $"- {pokemon.Nombre} (HP: {pokemon.Vida})\n";
                    }
                }
            }

            return respuesta;
        }

        // Gestión de Batallas
        public static string IniciarBatalla(string entrenador1, string? entrenador2)
        {
            Entrenador jugador1 = GameManager.ObtenerEntrenador(entrenador1);
            Entrenador jugador2 = entrenador2 != null
                ? GameManager.ObtenerEntrenador(entrenador2)
                : GameManager.EmparejarAleatorio(entrenador1);

            if (jugador1 == null || jugador2 == null)
            {
                return "No se encontraron los jugadores para iniciar la batalla.";
            }

            Batalla batalla = new Batalla(jugador1, jugador2);
            string key = $"{jugador1.Nombre}-{jugador2.Nombre}";
            batallasActivas[key] = batalla;

            return batalla.IniciarBatalla();
        }

        public static string UsarHabilidad(string entrenador, string? habilidad)
        {
            Batalla batalla = ObtenerBatallaPorEntrenador(entrenador);
            if (batalla == null) return "No estás en una batalla activa.";

            Entrenador jugador = GameManager.ObtenerEntrenador(entrenador);
            IHabilidad habilidadUsar = jugador.PokemonActivo.ObtenerHabilidad(habilidad);

            return batalla.RealizarTurno(habilidadUsar);
        }

        public static string CambiarPokemones(string entrenador, string pokemon)
        {
            Batalla batalla = ObtenerBatallaPorEntrenador(entrenador);
            if (batalla == null) return "No estás en una batalla activa.";

            Entrenador jugador = GameManager.ObtenerEntrenador(entrenador);
            Pokemon cambio = jugador.ObtenerPokemonPorNombre(pokemon);

            return batalla.RealizarTurno(cambio: cambio);
        }

        private static Batalla ObtenerBatallaPorEntrenador(string entrenador)
        {
            foreach (var batalla in batallasActivas.Values)
            {
                if (batalla.ContieneEntrenador(entrenador))
                {
                    return batalla;
                }
            }
            return null;
        }

        // Mostrar Estado del Centro de Juego
        public static string VerCentroJuego()
        {
            List<string> nombres = GameManager.ObtenerNombresEntrenadores();
            if (nombres.Count == 0) return "No hay jugadores en el lobby.";

            string respuesta = "Jugadores en el lobby:\n";
            respuesta += string.Join("\n", nombres);
            return respuesta;
        }
    }
}
