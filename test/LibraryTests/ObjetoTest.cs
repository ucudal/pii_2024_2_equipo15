using NUnit.Framework;
using program;

namespace Tests
{
    /// <summary>
    /// Pruebas para la clase Objeto.
    /// </summary>
    [TestFixture]
    public class ObjetoTests
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
            var objeto = new Objeto("Súper poción", p => p.Vida += 50);

            Assert.That(objeto.Nombre, Is.EqualTo("Súper poción"));
            Assert.That(objeto.AplicarEfecto, Is.Not.Null);
        }

        /// <summary>
        /// Prueba que el efecto del objeto se aplique correctamente a un Pokémon.
        /// </summary>
        [Test]
        public void Usar_ObjetoCuraVida()
        {
            pikachu.Vida = 100;
            var superPocion = new Objeto("Súper poción", p =>
            {
                p.Vida += 50;
                if (p.Vida > p.VidaBase) p.Vida = p.VidaBase;
            });

            string resultado = superPocion.Usar(pikachu);

            Assert.That(resultado, Is.EqualTo("Súper poción fue usado en Pikachu."));
            Assert.That(pikachu.Vida, Is.EqualTo(150)); // 100 + 50 = 150
        }

        /// <summary>
        /// Prueba que el objeto no exceda la vida base del Pokémon.
        /// </summary>
        [Test]
        public void Usar_ObjetoNoExcedeVidaBase()
        {
            pikachu.Vida = 170;
            var superPocion = new Objeto("Súper poción", p =>
            {
                p.Vida += 50;
                if (p.Vida > p.VidaBase) p.Vida = p.VidaBase;
            });

            string resultado = superPocion.Usar(pikachu);

            Assert.That(resultado, Is.EqualTo("Súper poción fue usado en Pikachu."));
            Assert.That(pikachu.Vida, Is.EqualTo(180)); // Vida máxima
        }

        /// <summary>
        /// Prueba que un objeto elimine el estado de un Pokémon.
        /// </summary>
        [Test]
        public void Usar_ObjetoEliminaEstado()
        {
            pikachu.Estado = "paralizado";
            var curaTotal = new Objeto("Cura total", p =>
            {
                p.Estado = null;
            });

            string resultado = curaTotal.Usar(pikachu);

            Assert.That(resultado, Is.EqualTo("Cura total fue usado en Pikachu."));
            Assert.That(pikachu.Estado, Is.Null);
        }

        /// <summary>
        /// Prueba que un objeto personalizado pueda infligir daño a un Pokémon.
        /// </summary>
        [Test]
        public void Usar_ObjetoInfligeDaño()
        {
            var ataqueEspecial = new Objeto("Llamarada", p => p.Vida -= 50);

            string resultado = ataqueEspecial.Usar(pikachu);

            Assert.That(resultado, Is.EqualTo("Llamarada fue usado en Pikachu."));
            Assert.That(pikachu.Vida, Is.EqualTo(130)); // 180 - 50 = 130
        }

        /// <summary>
        /// Prueba que un objeto sin acción no modifique las propiedades del Pokémon.
        /// </summary>
        [Test]
        public void Usar_ObjetoSinEfecto_NoCambiaPokemon()
        {
            var objetoInutil = new Objeto("Objeto inútil", p => { });

            string resultado = objetoInutil.Usar(pikachu);

            Assert.That(resultado, Is.EqualTo("Objeto inútil fue usado en Pikachu."));
            Assert.That(pikachu.Vida, Is.EqualTo(180)); // Vida no cambia
            Assert.That(pikachu.Estado, Is.Null); // Estado no cambia
        }
    }
}