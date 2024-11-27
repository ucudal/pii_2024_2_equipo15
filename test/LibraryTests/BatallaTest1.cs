using NUnit.Framework;
using program;
using System.Collections.Generic;

namespace Tests
{
    /// <summary>
    /// Pruebas para la clase Batalla.
    /// </summary>
    [TestFixture]
    public class BatallaTests
    {
        private Entrenador jugador1;
        private Entrenador jugador2;
        private Batalla batalla;

        /// <summary>
        /// Configuración inicial para cada prueba.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            var pikachu = new Pokemon("Pikachu", 180, 150, 120, 150);
            var blastoise = new Pokemon("Blastoise", 268, 120, 80, 160);

            pikachu.AprenderHabilidad(new Habilidades("Trueno", 110, false));
            blastoise.AprenderHabilidad(new Habilidades("Hidro Bomba", 110, false));

            jugador1 = new Entrenador("Ichigo");
            jugador2 = new Entrenador("Urahara");

            jugador1.AñadirPokemon(pikachu);
            jugador1.FijarPokemonActual();

            jugador2.AñadirPokemon(blastoise);
            jugador2.FijarPokemonActual();

            batalla = new Batalla(jugador1, jugador2);
        }

        /// <summary>
        /// Prueba que el constructor asigna correctamente los entrenadores y el turno inicial.
        /// </summary>
        [Test]
        public void Constructor_AsignarEntrenadoresYTurnoInicial()
        {
            var jugadores = batalla.JugadoresDisponibles();
            Assert.That(jugadores[0], Is.EqualTo(jugador1));
            Assert.That(jugadores[1], Is.EqualTo(jugador2));
            Assert.That(batalla.MostrarTurnoActual(), Does.Contain("Ichigo"));
        }

        /// <summary>
        /// Prueba que IniciarBatalla devuelve el mensaje correcto.
        /// </summary>
        [Test]
        public void IniciarBatalla_RetornaMensajeCorrecto()
        {
            string resultado = batalla.IniciarBatalla();
            Assert.That(resultado, Is.EqualTo("Ichigo y Urahara están listos para la batalla. ¡Ichigo comienza!"));
        }

        /// <summary>
        /// Prueba que RealizarTurno reduce la vida del oponente al usar una habilidad con éxito.
        /// </summary>
        [Test]
        public void RealizarTurno_UsarHabilidadConExito()
        {
            var habilidad = jugador1.PokemonActivo.Habilidades[0];
            string resultado = batalla.RealizarTurno(habilidad);
            Assert.That(jugador2.PokemonActivo.Vida, Is.LessThan(268));
            Assert.That(resultado, Does.Contain("usó Trueno"));
        }

        /// <summary>
        /// Prueba que Atacar no reduce la vida del oponente si la precisión falla.
        /// </summary>
        [Test]
        public void Atacar_FallidoPorPrecision_NoReduceVida()
        {
            var habilidad = new Habilidades("Ataque Fallido", 50, false) { Precision = 0 };
            jugador1.PokemonActivo.AprenderHabilidad(habilidad);
            string resultado = batalla.RealizarTurno(habilidad);
            Assert.That(jugador2.PokemonActivo.Vida, Is.EqualTo(268));
            Assert.That(resultado, Does.Contain("¡pero falló!"));
        }

        /// <summary>
        /// Prueba que Atacar no se ejecuta si el atacante está paralizado.
        /// </summary>
        [Test]
        public void Atacar_Paralizado_NoSeMueve()
        {
            jugador1.PokemonActivo.Estado = "paralizado";
            var habilidad = jugador1.PokemonActivo.Habilidades[0];
            bool falloPorParalisis = false;

            for (int i = 0; i < 100; i++)
            {
                string resultado = batalla.RealizarTurno(habilidad);
                if (resultado.Contains("está paralizado y no puede moverse"))
                {
                    falloPorParalisis = true;
                    break;
                }
            }

            Assert.That(falloPorParalisis, Is.True);
        }

        /// <summary>
        /// Prueba que CambiarPokemon actualiza correctamente el Pokémon activo.
        /// </summary>
        [Test]
        public void CambiarPokemon_Exitoso()
        {
            var charizard = new Pokemon("Charizard", 266, 100, 80, 200);
            jugador1.AñadirPokemon(charizard);

            Assert.That(batalla.MostrarTurnoActual(), Does.Contain("Ichigo"));

            string resultado = batalla.RealizarTurno(cambio: charizard);

            Assert.That(jugador1.PokemonActivo, Is.EqualTo(charizard));

            Assert.That(resultado, Does.Contain("Urahara cambió a Charizard!"));
        }

        /// <summary>
        /// Prueba que CambiarPokemon falla si el Pokémon no pertenece al equipo.
        /// </summary>
        [Test]
        public void CambiarPokemon_NoEstaEnEquipo()
        {
            var snorlax = new Pokemon("Snorlax", 450, 50, 110, 200);
            string resultado = batalla.RealizarTurno(cambio: snorlax);
            Assert.That(resultado, Is.EqualTo("Ese Pokémon no está en tu equipo."));
        }

        /// <summary>
        /// Prueba que CambiarPokemon falla si el Pokémon está debilitado.
        /// </summary>
        [Test]
        public void CambiarPokemon_PokemonDebilitado()
        {
            var charizard = new Pokemon("Charizard", 266, 100, 80, 200) { Vida = 0 };
            jugador1.AñadirPokemon(charizard);
            string resultado = batalla.RealizarTurno(cambio: charizard);
            Assert.That(resultado, Is.EqualTo("Charizard está debilitado y no puede ser enviado a la batalla."));
        }

        /// <summary>
        /// Prueba que ReducirTurnosEspeciales decrementa correctamente los turnos.
        /// </summary>
        [Test]
        public void ReducirTurnosEspeciales_DecrementaCorrectamente()
        {
            var habilidadEspecial = new Habilidades("Explosión", 250, false) { EsEspecial = true };
            jugador1.PokemonActivo.AprenderHabilidad(habilidadEspecial);
            batalla.RealizarTurno(habilidadEspecial);
            string resultado = batalla.RealizarTurno(habilidadEspecial);
            Assert.That(resultado, Does.Contain("No puedes usar ataques especiales aún"));
        }

        /// <summary>
        /// Prueba que DeterminarGanador devuelve el mensaje correcto cuando gana el entrenador1.
        /// </summary>
        [Test]
        public void DeterminarGanador_Entrenador1Gana()
        {
            jugador2.PokemonActivo.Vida = 0;
            string resultado = batalla.DeterminarGanador();
            Assert.That(resultado, Is.EqualTo("Ichigo gana la batalla!"));
        }

        /// <summary>
        /// Prueba que DeterminarGanador devuelve el mensaje correcto cuando la batalla continúa.
        /// </summary>
        [Test]
        public void DeterminarGanador_LaBatallaContinua()
        {
            jugador1.PokemonActivo.Vida = 50;
            jugador2.PokemonActivo.Vida = 60;
            string resultado = batalla.DeterminarGanador();
            Assert.That(resultado, Is.EqualTo("La batalla continúa..."));
        }

        /// <summary>
        /// Prueba que ContieneEntrenador devuelve true si el entrenador está presente en la batalla.
        /// </summary>
        [Test]
        public void ContieneEntrenador_EntrenadorPresente()
        {
            Assert.That(batalla.ContieneEntrenador("Ichigo"), Is.True);
            Assert.That(batalla.ContieneEntrenador("Urahara"), Is.True);
        }

        /// <summary>
        /// Prueba que ContieneEntrenador devuelve false si el entrenador no está en la batalla.
        /// </summary>
        [Test]
        public void ContieneEntrenador_EntrenadorNoPresente()
        {
            Assert.That(batalla.ContieneEntrenador("Yoruichi"), Is.False);
        }

        /// <summary>
        /// Prueba que JugadoresDisponibles retorna ambos entrenadores.
        /// </summary>
        [Test]
        public void JugadoresDisponibles_RetornaAmbosEntrenadores()
        {
            var jugadores = batalla.JugadoresDisponibles();
            Assert.That(jugadores.Count, Is.EqualTo(2));
            Assert.That(jugadores, Contains.Item(jugador1));
            Assert.That(jugadores, Contains.Item(jugador2));
        }

        /// <summary>
        /// Prueba que MostrarTurnoActual devuelve el mensaje correcto para el turno del jugador1.
        /// </summary>
        [Test]
        public void MostrarTurnoActual_TurnoDeJugador1()
        {
            string resultado = batalla.MostrarTurnoActual();
            Assert.That(resultado, Is.EqualTo("Es el turno de Ichigo con Pikachu."));
        }

        /// <summary>
        /// Prueba que MostrarTurnoActual devuelve el mensaje correcto para el turno del jugador2.
        /// </summary>
        [Test]
        public void MostrarTurnoActual_TurnoDeJugador2()
        {
            var habilidad = jugador1.PokemonActivo.Habilidades[0]; 
            batalla.RealizarTurno(habilidad); 

            string resultado = batalla.MostrarTurnoActual();

            Assert.That(resultado, Is.EqualTo("Es el turno de Urahara con Blastoise."));
        }
    }
}
