using NUnit.Framework;
using program;
using System.Collections.Generic;

namespace LibraryTests
{
    public class BatallaActualTest
    {
        private BatallaActual batallaActual;
        private Entrenador entrenador1;
        private Entrenador entrenador2;
        private Entrenador entrenador3;

        /// <summary>
        /// Configura el estado inicial para las pruebas.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            // Inicializar BatallaActual
            batallaActual = new BatallaActual();

            // Crear entrenadores
            entrenador1 = new Entrenador("Ichigo");
            entrenador2 = new Entrenador("Urahara");
            entrenador3 = new Entrenador("Yoruichi");

            // Asignar Pokémon a los entrenadores
            var pikachu = new Pokemon("Pikachu", 180, 150, 120, 150);
            var blastoise = new Pokemon("Blastoise", 268, 120, 80, 160);
            var charizard = new Pokemon("Charizard", 266, 100, 80, 200);

            pikachu.AprenderHabilidad(new Habilidades("Trueno", 110, false));
            blastoise.AprenderHabilidad(new Habilidades("Hidro Bomba", 110, false));
            charizard.AprenderHabilidad(new Habilidades("Lanzallamas", 90, false));

            entrenador1.AñadirPokemon(pikachu);
            entrenador1.FijarPokemonActual();

            entrenador2.AñadirPokemon(blastoise);
            entrenador2.FijarPokemonActual();

            entrenador3.AñadirPokemon(charizard);
            entrenador3.FijarPokemonActual();
        }

        /// <summary>
        /// Valida que se pueda crear una nueva batalla entre dos entrenadores.
        /// </summary>
        [Test]
        public void CrearPartida_CreaNuevaBatalla()
        {
            var batalla = batallaActual.CrearPartida(entrenador1, entrenador2);

            Assert.That(batalla, Is.Not.Null);
            Assert.That(batalla.ContieneEntrenador("Ichigo"), Is.True);
            Assert.That(batalla.ContieneEntrenador("Urahara"), Is.True);
        }

        /// <summary>
        /// Valida que se pueda obtener la batalla activa de un entrenador.
        /// </summary>
        [Test]
        public void BatallaPorEntrenador_RetornaBatallaCorrecta()
        {
            var batalla = batallaActual.CrearPartida(entrenador1, entrenador2);

            var batallaObtenida = batallaActual.BatallaPorEntrenador(entrenador1);

            Assert.That(batallaObtenida, Is.EqualTo(batalla));
        }

        /// <summary>
        /// Valida que si un entrenador no está en ninguna batalla activa, se devuelva null.
        /// </summary>
        [Test]
        public void BatallaPorEntrenador_SinBatallaActiva_RetornaNull()
        {
            var batallaObtenida = batallaActual.BatallaPorEntrenador(entrenador3);

            Assert.That(batallaObtenida, Is.Null);
        }

        /// <summary>
        /// Valida que se pueda terminar correctamente una batalla activa.
        /// </summary>
        [Test]
        public void TerminarPartida_FinalizaCorrectamente()
        {
            var batalla = batallaActual.CrearPartida(entrenador1, entrenador2);

            bool resultado = batallaActual.TerminarPartida(batalla);

            Assert.That(resultado, Is.True);
            Assert.That(batallaActual.BatallaPorEntrenador(entrenador1), Is.Null);
            Assert.That(batallaActual.BatallaPorEntrenador(entrenador2), Is.Null);
        }

        /// <summary>
        /// Valida que al determinar el ganador, se retorne correctamente el resultado.
        /// </summary>
        [Test]
        public void DeterminarGanador_Entrenador1Gana()
        {
            var batalla = batallaActual.CrearPartida(entrenador1, entrenador2);
            entrenador2.PokemonActivo.Vida = 0; // Debilitar el Pokémon activo de Urahara

            string ganador = batallaActual.DeterminarGanador(batalla);

            Assert.That(ganador, Is.EqualTo("Ichigo gana la batalla!"));
        }

        /// <summary>
        /// Valida que al determinar el ganador, se devuelva que la batalla continúa si ambos tienen Pokémon vivos.
        /// </summary>
        [Test]
        public void DeterminarGanador_LaBatallaContinua()
        {
            var batalla = batallaActual.CrearPartida(entrenador1, entrenador2);

            string ganador = batallaActual.DeterminarGanador(batalla);

            Assert.That(ganador, Is.EqualTo("La batalla continúa..."));
        }

        /// <summary>
        /// Valida que al determinar el ganador, se retorne correctamente si el entrenador 2 gana.
        /// </summary>
        [Test]
        public void DeterminarGanador_Entrenador2Gana()
        {
            var batalla = batallaActual.CrearPartida(entrenador1, entrenador2);
            entrenador1.PokemonActivo.Vida = 0; // Debilitar el Pokémon activo de Ichigo

            string ganador = batallaActual.DeterminarGanador(batalla);

            Assert.That(ganador, Is.EqualTo("Urahara gana la batalla!"));
        }
    }
}
