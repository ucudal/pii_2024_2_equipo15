using System.Collections.Generic;
using System.Linq;

namespace program
{
    public static class GameManager
    {
        // Lista que almacena todos los entrenadores registrados en el sistema.
        private static List<Entrenador> entrenadores = new List<Entrenador>();

        /// <summary>
        /// Agrega un nuevo entrenador al sistema si no está registrado previamente.
        /// </summary>
        /// <param name="nombre">Nombre del entrenador a registrar.</param>
        /// <returns>Mensaje indicando si el registro fue exitoso o si el entrenador ya existe.</returns>
        public static string AgregarEntrenador(string nombre)
        {
            // Verifica si ya existe un entrenador con el mismo nombre.
            if (entrenadores.Any(e => e.Nombre == nombre))
            {
                return $"El entrenador {nombre} ya está registrado.";
            }

            // Crea un nuevo entrenador y lo añade a la lista.
            Entrenador nuevoEntrenador = new Entrenador(nombre);
            entrenadores.Add(nuevoEntrenador);
            return $"El entrenador {nombre} se ha unido.";
        }
        
        /// <summary>
        /// Busca y obtiene un entrenador por su nombre.
        /// </summary>
        /// <param name="nombre">Nombre del entrenador a buscar.</param>
        /// <returns>Objeto Entrenador si existe, de lo contrario null.</returns>
        public static Entrenador? ObtenerEntrenador(string nombre)
        {
            // Busca en la lista de entrenadores uno que coincida con el nombre proporcionado.
            return entrenadores.FirstOrDefault(e => e.Nombre == nombre);
        }

        /// <summary>
        /// Obtiene los nombres de todos los entrenadores registrados en el sistema.
        /// </summary>
        /// <returns>Lista de cadenas con los nombres de los entrenadores.</returns>
        public static List<string> ObtenerNombresEntrenadores()
        {
            // Selecciona y retorna los nombres de todos los entrenadores.
            return entrenadores.Select(e => e.Nombre).ToList();
        }

        /// <summary>
        /// Empareja un entrenador aleatorio que no esté actualmente en batalla.
        /// </summary>
        /// <param name="entrenadorExcluido">Nombre del entrenador a excluir del emparejamiento.</param>
        /// <returns>Objeto Entrenador si se encuentra un oponente válido, de lo contrario null.</returns>
        public static Entrenador? EmparejarAleatorio(string entrenadorExcluido)
        {
            // Filtra entrenadores que no están en batalla y no coinciden con el excluido.
            return entrenadores
                .Where(e => e.Nombre != entrenadorExcluido && !e.EnBatalla)
                .OrderBy(e => Guid.NewGuid())
                .FirstOrDefault();
        }

        /// <summary>
        /// Elimina un entrenador del sistema.
        /// </summary>
        /// <param name="nombre">Nombre del entrenador a eliminar.</param>
        /// <returns>Mensaje indicando si la operación fue exitosa o si el entrenador no existe.</returns>
        public static string EliminarEntrenador(string nombre)
        {
            // Busca el entrenador por su nombre.
            Entrenador? entrenador = ObtenerEntrenador(nombre);
            if (entrenador == null)
            {
                return $"El entrenador {nombre} no existe.";
            }

            // Remueve al entrenador de la lista.
            entrenadores.Remove(entrenador);
            return $"El entrenador {nombre} ha sido eliminado.";
        }
    }
}