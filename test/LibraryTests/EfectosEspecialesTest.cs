using NUnit.Framework;
using program;

namespace Tests
{
    /// <summary>
    /// Pruebas para la clase EfectoEspeciales.
    /// </summary>
    [TestFixture]
    public class EfectoEspecialesTests
    {
        private Pokemon pikachu;

        /// <summary>
        /// Configuración inicial para las pruebas.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            pikachu = new Pokemon("Pikachu", 180, 150, 120, 150);
        }

        /// <summary>
        /// Prueba que el constructor asigne correctamente el nombre y el efecto.
        /// </summary>
        [Test]
        public void Constructor_AsignarNombreYEfecto()
        {
            var efecto = new EfectoEspeciales("Parálisis", p => p.Estado = "paralizado");

            Assert.That(efecto.Nombre, Is.EqualTo("Parálisis"));
            Assert.That(efecto.AplicarEfecto, Is.Not.Null);
        }

        /// <summary>
        /// Prueba que el efecto se aplique correctamente al Pokémon.
        /// </summary>
        [Test]
        public void AplicarEfecto_CambiaEstadoDelPokemon()
        {
            var efecto = new EfectoEspeciales("Parálisis", p => p.Estado = "paralizado");

            efecto.AplicarEfecto(pikachu);

            Assert.That(pikachu.Estado, Is.EqualTo("paralizado"));
        }

        /// <summary>
        /// Prueba que un efecto personalizado modifique la vida del Pokémon.
        /// </summary>
        [Test]
        public void AplicarEfecto_ReduceVidaDelPokemon()
        {
            var efecto = new EfectoEspeciales("Quemadura", p => p.Vida -= 20);

            efecto.AplicarEfecto(pikachu);

            Assert.That(pikachu.Vida, Is.EqualTo(160)); // 180 - 20
        }

        /// <summary>
        /// Prueba que el efecto no tenga impacto si no se realiza ninguna acción.
        /// </summary>
        [Test]
        public void AplicarEfecto_SinAccion_NoModificaPokemon()
        {
            var efecto = new EfectoEspeciales("Nada", p => { });

            efecto.AplicarEfecto(pikachu);

            Assert.That(pikachu.Vida, Is.EqualTo(180));
            Assert.That(pikachu.Estado, Is.Null);
        }
    }
}