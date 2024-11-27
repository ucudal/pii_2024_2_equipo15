using System;
using System.Collections.Generic;

namespace program
{
    public static class Facade
    {
        private static Dictionary<string, Batalla> batallasActivas = new Dictionary<string, Batalla>(); // Diccionario para rastrear las batallas activas usando como clave una combinación de nombres de entrenadores.

        private static Dictionary<string, Inventario> inventarios = new Dictionary<string, Inventario>(); // Diccionario que almacena los inventarios de cada entrenador por nombre.

        /// <summary>
        /// Devuelve la lista de Pokémon disponibles en el sistema.
        /// </summary>
        /// <returns>Cadena con los nombres de los Pokémon disponibles.</returns>
        public static string MostrarPokemones()
        {
            return Logica.Instance.MostrarPokemones();
        }

        public static string MostrarAtaquesDePokemones()
        {
            return Logica.Instance.MostrarAtaquesDePokemones();
        }

        // Gestión de Entrenadores
        /// <summary>
        /// Añade un entrenador al centro de juego.
        /// </summary>
        /// <param name="nombre">Nombre del entrenador a registrar.</param>
        /// <returns>Mensaje indicando el resultado de la operación.</returns>
        public static string IngresarUsuarioAlCentro(string nombre)
        {
            return GameManager.AgregarEntrenador(nombre);
        }

        public static string SacarEntrenadores(string nombre)
        {
            return GameManager.EliminarEntrenador(nombre);
        }

        public static string SeleccionarEquipo(string entrenador, string pokemonName)
        {
            Entrenador? jugador = GameManager.ObtenerEntrenador(entrenador); // Verifica si el entrenador existe.
            if (jugador == null) return "No estás registrado como entrenador.";

            Pokemon? pokemon = Logica.Instance.ObtenerPokemon(pokemonName); // Comprueba si el Pokémon está registrado.
            if (pokemon == null) return $"El Pokémon {pokemonName} no existe.";
            
            if (Batalla.PokemonesSeleccionados.Contains(pokemonName)) // Verifica si el Pokémon ya fue seleccionado por otro entrenador
            {
                return $"El Pokémon {pokemonName} ya ha sido seleccionado por otro entrenador.";
            }

            bool añadido = jugador.AñadirPokemon(pokemon);
            if (!añadido) return "No puedes añadir más Pokémon o ya tienes este Pokémon.";

            // Agrega el nombre del Pokémon a la lista de seleccionados
            Batalla.PokemonesSeleccionados.Add(pokemonName);
            return $"{pokemonName} fue añadido al equipo de {entrenador}.";
        }

        public static string VerPokemones(string entrenador, string? oponente = null)
        {
            Entrenador? jugador = GameManager.ObtenerEntrenador(entrenador); // Busca el entrenador en el sistema.
            if (jugador == null) return "No estás registrado como entrenador.";

            string respuesta = $"Equipo de {entrenador}:\n"; // Construye la respuesta con el equipo del entrenador.
            foreach (var pokemon in jugador.Pokemones)
            {
                respuesta += $"- {pokemon.Nombre} (HP: {pokemon.Vida})\n";
            }

            if (!string.IsNullOrEmpty(oponente))  // Si se proporciona un oponente, incluye su equipo en la respuesta.
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

            return respuesta; // Devuelve la lista de equipos.
        }

        // Gestión de Batallas
  
        public static string IniciarBatalla(string entrenador1, string? entrenador2)
        {
            Entrenador jugador1 = GameManager.ObtenerEntrenador(entrenador1); // Obtiene los entrenadores involucrados en la batalla.
            Entrenador jugador2 = entrenador2 != null // Obtiene los entrenadores involucrados en la batalla.
                ? GameManager.ObtenerEntrenador(entrenador2)
                : GameManager.EmparejarAleatorio(entrenador1); // Empareja con un oponente aleatorio si no se proporciona.

            if (jugador1 == null || jugador2 == null)
            {
                return "No se encontraron los jugadores para iniciar la batalla.";
            }

            Batalla batalla = new Batalla(jugador1, jugador2);   // Crea una nueva instancia de batalla y la almacena.
            string key = $"{jugador1.Nombre}-{jugador2.Nombre}";
            batallasActivas[key] = batalla;

            return batalla.IniciarBatalla(); // Comienza la batalla y devuelve el estado inicial.
        }

        public static string UsarHabilidad(string entrenador, string? habilidad)
        {
            Batalla batalla = ObtenerBatallaPorEntrenador(entrenador);
            if (batalla == null) return "No estás en una batalla activa.";

            Entrenador jugador = GameManager.ObtenerEntrenador(entrenador);
            IHabilidad habilidadUsar = jugador.PokemonActivo.ObtenerHabilidad(habilidad);

            string resultado = batalla.RealizarTurno(habilidadUsar);
            return resultado;
        }

        public static string CambiarPokemones(string entrenador, string pokemon)
        {
            Batalla batalla = ObtenerBatallaPorEntrenador(entrenador);
            if (batalla == null) return "No estás en una batalla activa.";

            Entrenador jugador = GameManager.ObtenerEntrenador(entrenador);
            Pokemon cambio = jugador.ObtenerPokemonPorNombre(pokemon);

            return batalla.RealizarTurno(cambio: cambio);
        }

        public static string UsarObjeto(string entrenador, string nombreObjeto, string nombrePokemon)
        {
            if (!inventarios.ContainsKey(entrenador))
            {
                inventarios[entrenador] = new Inventario();
            }

            Pokemon? pokemon = Logica.Instance.ObtenerPokemon(nombrePokemon);
            if (pokemon == null)
            {
                return "El Pokémon no existe o no está en el equipo.";
            }

            return inventarios[entrenador].UsarObjeto(nombreObjeto, pokemon);
        }

        public static string MostrarInventario(string entrenador)
        {
            if (!inventarios.ContainsKey(entrenador))
            {
                inventarios[entrenador] = new Inventario();
            }

            return inventarios[entrenador].MostrarInventario();
        }

        /// <summary>
        /// Busca una batalla activa en la que participe el entrenador dado.
        /// </summary>
        /// <param name="entrenador">Nombre del entrenador a buscar.</param>
        /// <returns>Objeto Batalla si se encuentra, de lo contrario null.</returns>
        private static Batalla ObtenerBatallaPorEntrenador(string entrenador)
        {
            foreach (var batalla in batallasActivas.Values)
            {
                if (batalla.ContieneEntrenador(entrenador))
                {
                    return batalla; // Retorna la batalla si el entrenador participa en ella.
                }
            }
            return null; // Si no se encuentra una batalla activa para el entrenador.
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
