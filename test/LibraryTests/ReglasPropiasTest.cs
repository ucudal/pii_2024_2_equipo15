using NUnit.Framework;
using program;

namespace LibraryTests
{
    [TestFixture]
    public class ReglasPropiasTests
    {
        private ReglasPropias reglas;

        [SetUp]
        public void Setup()
        {
            reglas = new ReglasPropias();
        }

        [Test]
        public void ProhibirTipo()
        {
            reglas.ProhibirTipo("Agua");

            Assert.That(reglas.TiposProhibir, Contains.Item("Agua"));
        }

        [Test]
        public void ProhibirPokemon()
        {
            reglas.ProhibirPokemon("Snorlax");

            Assert.That(reglas.PokemonesProhibir, Contains.Item("Snorlax"));
        }

        [Test]
        public void ProhibirItem()
        {
            reglas.ProhibirItem("Poción");

            Assert.That(reglas.ItemsProhibir, Contains.Item("Poción"));
        }

        [Test]
        public void MostrarReglas()
        {
            reglas.ProhibirTipo("Agua");
            reglas.ProhibirPokemon("Snorlax");
            reglas.ProhibirItem("Poción");

            string resultado = reglas.MostrarReglas();

            Assert.That(resultado, Contains.Substring("Agua"));
            Assert.That(resultado, Contains.Substring("Snorlax"));
            Assert.That(resultado, Contains.Substring("Poción"));
        }
    }

    
}



