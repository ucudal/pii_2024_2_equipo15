using NUnit.Framework;
using program;
using System.Collections.Generic;

namespace Tests
{
    // Clases de prueba anteriores (FacadeTests, FacadeAtaquesTests, FacadeUsuarioTests, etc.)
    // OMITIDAS AQUÍ PARA ENFOCARNOS EN LA NUEVA CLASE

    /// <summary>
    /// Pruebas para el método Facade.IniciarBatalla.
    /// </summary>
    [TestFixture]
    public class FacadeIniciarBatallaTests
    {
        /// <summary>
        /// Configuración inicial para las pruebas.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            // Restablecer el estado de GameManager
            var fieldGameManager = typeof(GameManager).GetField("entrenadores", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            if (fieldGameManager != null)
            {
                fieldGameManager.SetValue(null, new List<Entrenador>()); // Reinicia la lista de entrenadores
            }

            // Restablecer el estado de batallasActivas
            var fieldBatallasActivas = typeof(Facade).GetField("batallasActivas", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            if (fieldBatallasActivas != null)
            {
                fieldBatallasActivas.SetValue(null, new Dictionary<string, Batalla>()); // Reinicia las batallas activas
            }

            // Restablecer el estado de Logica
            var fieldLogica = typeof(Logica).GetField("_instance", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            if (fieldLogica != null)
            {
                fieldLogica.SetValue(null, null); // Reinicia el singleton Logica
            }

            // Inicializar Logica para asegurar que los Pokémon están disponibles
            Logica.Instance.MostrarPokemones();
        }

        /// <summary>
        /// Prueba que se inicie correctamente una batalla entre dos entrenadores registrados.
        /// </summary>
        
        /// <summary>
        /// Prueba que no se inicie la batalla si uno de los entrenadores no está registrado.
        /// </summary>
        [Test]
        public void IniciarBatalla_EntrenadorNoRegistrado_NoInicia()
        {
            // Registrar solo un entrenador
            Facade.IngresarUsuarioAlCentro("Ichigo");

            // Intentar iniciar batalla con un entrenador no registrado
            string resultado = Facade.IniciarBatalla("Ichigo", "Urahara");

            // Verificar el mensaje de error
            Assert.That(resultado, Is.EqualTo("No se encontraron los jugadores para iniciar la batalla."));
        }

        /// <summary>
        /// Prueba que se empareje correctamente un oponente aleatorio si no se especifica un segundo entrenador.
        /// </summary>
        

        /// <summary>
        /// Prueba que no se inicie la batalla si no hay oponentes disponibles para emparejar aleatoriamente.
        /// </summary>
        [Test]
        public void IniciarBatalla_SinOponenteDisponible_NoInicia()
        {
            // Registrar solo un entrenador
            Facade.IngresarUsuarioAlCentro("Ichigo");

            // Intentar iniciar batalla sin oponente disponible
            string resultado = Facade.IniciarBatalla("Ichigo", null);

            // Verificar el mensaje de error
            Assert.That(resultado, Is.EqualTo("No se encontraron los jugadores para iniciar la batalla."));
        }
        [Test]
        public void IniciarBatalla_EntrenadoresRegistrados_IniciaCorrectamente()
        {
            // Registrar entrenadores
            Facade.IngresarUsuarioAlCentro("Ichigo");
            Facade.IngresarUsuarioAlCentro("Urahara");

            // Configurar Pokémon activos
            Entrenador jugador1 = GameManager.ObtenerEntrenador("Ichigo");
            Entrenador jugador2 = GameManager.ObtenerEntrenador("Urahara");

            var pikachu = new Pokemon("Pikachu", 180, 150, 120, 150);
            var blastoise = new Pokemon("Blastoise", 268, 120, 80, 160);

            jugador1.AñadirPokemon(pikachu);
            jugador1.FijarPokemonActual();

            jugador2.AñadirPokemon(blastoise);
            jugador2.FijarPokemonActual();

            // Iniciar batalla
            string resultado = Facade.IniciarBatalla("Ichigo", "Urahara");

            // Verificar que el mensaje indique que la batalla comenzó
            Assert.That(resultado, Is.EqualTo("Ichigo y Urahara están listos para la batalla. ¡Ichigo comienza!"));

            // Verificar que la batalla está registrada en batallasActivas
            var fieldBatallasActivas = typeof(Facade).GetField("batallasActivas", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            var batallasActivas = (Dictionary<string, Batalla>)fieldBatallasActivas.GetValue(null);
            Assert.That(batallasActivas, Contains.Key("Ichigo-Urahara"));
        }
        
        [Test]
        public void IniciarBatalla_ConEmparejamientoAleatorio_IniciaCorrectamente()
        {
            // Registrar entrenadores
            Facade.IngresarUsuarioAlCentro("Ichigo");
            Facade.IngresarUsuarioAlCentro("Urahara");

            // Configurar Pokémon activos
            Entrenador jugador1 = GameManager.ObtenerEntrenador("Ichigo");
            Entrenador jugador2 = GameManager.ObtenerEntrenador("Urahara");

            var pikachu = new Pokemon("Pikachu", 180, 150, 120, 150);
            var blastoise = new Pokemon("Blastoise", 268, 120, 80, 160);

            jugador1.AñadirPokemon(pikachu);
            jugador1.FijarPokemonActual();

            jugador2.AñadirPokemon(blastoise);
            jugador2.FijarPokemonActual();

            // Iniciar batalla sin especificar al segundo entrenador
            string resultado = Facade.IniciarBatalla("Ichigo", null);

            // Verificar que la batalla se inició correctamente
            Assert.That(resultado, Does.Contain("Ichigo y Urahara están listos para la batalla."));
        }


        
        
    }
}