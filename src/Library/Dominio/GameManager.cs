using System.Collections.Generic;
using System.Linq;

namespace program
{
    public static class GameManager
    {
        private static List<Entrenador> entrenadores = new List<Entrenador>();

        public static string AgregarEntrenador(string nombre)
        {
            if (entrenadores.Any(e => e.Nombre == nombre))
            {
                return $"El entrenador {nombre} ya está registrado.";
            }

            Entrenador nuevoEntrenador = new Entrenador(nombre);
            entrenadores.Add(nuevoEntrenador);
            return $"El entrenador {nombre} se ha unido.";
        }

        public static Entrenador? ObtenerEntrenador(string nombre)
        {
            return entrenadores.FirstOrDefault(e => e.Nombre == nombre);
        }

        public static List<string> ObtenerNombresEntrenadores()
        {
            return entrenadores.Select(e => e.Nombre).ToList();
        }

        public static Entrenador? EmparejarAleatorio(string entrenadorExcluido)
        {
            return entrenadores
                .Where(e => e.Nombre != entrenadorExcluido && !e.EnBatalla)
                .OrderBy(e => Guid.NewGuid())
                .FirstOrDefault();
        }

        public static string EliminarEntrenador(string nombre)
        {
            Entrenador? entrenador = ObtenerEntrenador(nombre);
            if (entrenador == null)
            {
                return $"El entrenador {nombre} no existe.";
            }

            entrenadores.Remove(entrenador);
            return $"El entrenador {nombre} ha sido eliminado.";
        }
    }
}