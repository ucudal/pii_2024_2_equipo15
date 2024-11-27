using NUnit.Framework;
using program;

namespace LibraryTests
{
    [TestFixture]
    public class ProhibicionesTests
    {
        private Prohibiciones prohibiciones;

        [SetUp]
        public void SetUp()
        {
            prohibiciones = new Prohibiciones();
        }

        [Test]
        public void ProhibirPokemon_Exito()
        {

            string resultado = prohibiciones.ProhibirPokemon("Pikachu");
            
            Assert.That(resultado, Is.EqualTo("El Pokémon ha sido prohibido."));
            Assert.That(prohibiciones.PokemonesProhibidos, Contains.Item("Pikachu"));
        }

        [Test]
        public void ProhibirPokemon_YaProhibido()
        {

            prohibiciones.ProhibirPokemon("Pikachu");


            string resultado = prohibiciones.ProhibirPokemon("Pikachu");

            Assert.That(resultado, Is.EqualTo("El Pokémon ya estaba prohibido."));
        }
        
        [Test]
        public void ProhibirItem_Exito()
        {

            string resultado = prohibiciones.ProhibirItem("Poción");
            
            Assert.That(resultado, Is.EqualTo("El ítem ha sido prohibido."));
            Assert.That(prohibiciones.ItemsProhibidos, Contains.Item("Poción"));
        }

        [Test]
        public void ProhibirItem_YaProhibido()
        {
            prohibiciones.ProhibirItem("Revivir");

            string resultado = prohibiciones.ProhibirItem("Revivir");

            Assert.That(resultado, Is.EqualTo("El ítem ya estaba prohibido."));
        }
    }
}
