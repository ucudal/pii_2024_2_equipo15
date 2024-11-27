namespace LibraryTests;
using NUnit.Framework;
using program;

public class BatallaConReglasTest
{
    [TestFixture]
    public class BatallaConReglasTests
    {
        private Entrenador entrenador1;
        private Entrenador entrenador2;
        private ReglasPropias reglas;
        private BatallaConReglas batalla;

        [SetUp]
        public void SetUp()
        {
            entrenador1 = new Entrenador("Juan");
            entrenador2 = new Entrenador("Martin");

            Pokemon pikachu = new Pokemon("Pikachu", 180, 150, 120, 100, "normal")
            {
                TipoPrincipal = new Tipos("Electrico", new Dictionary<string, double>())
            };

            Pokemon charizard = new Pokemon("Charizard", 200, 150, 130, 110, "normal")
            {
                TipoPrincipal = new Tipos("Fuego", new Dictionary<string, double>())
            };

            entrenador1.AñadirPokemon(pikachu);
            entrenador2.AñadirPokemon(charizard);

            reglas = new ReglasPropias();
            reglas.ProhibirTipo("Fuego");
            reglas.ProhibirPokemon("Pikachu");

            batalla = new BatallaConReglas(entrenador1, entrenador2, reglas);
        }

        [Test]
        public void ValidarReglas_CumpleReglas_ReturnsTrue()
        {
            reglas.TiposProhibir.Clear();
            reglas.PokemonesProhibir.Clear();

            Assert.That(batalla.ValidarReglas(), Is.True, "Las reglas deberían ser válidas si no hay restricciones.");
        }

        [Test]
        public void ValidarReglas_ContienePokemonProhibido_ReturnsFalse()
        {
            Assert.That(batalla.ValidarReglas(), Is.False,
                "Las reglas no deberían ser válidas si Pikachu está prohibido.");
        }

        [Test]
        public void ValidarReglas_ContieneTipoProhibido_ReturnsFalse()
        {
            reglas.PokemonesProhibir.Clear();

            Assert.That(batalla.ValidarReglas(), Is.False,
                "Las reglas no deberían ser válidas si el tipo Fuego está prohibido.");
        }

        [Test]
        public void AceptarReglas_OponenteAcepta_ReturnsTrue()
        {
            // Simular aceptación de las reglas
            var input = new StringReader("si");
            Console.SetIn(input);

            bool resultado = batalla.AceptarReglas(entrenador2);

            Assert.That(resultado, Is.True, "El rival debería aceptar las reglas si responde 'si'.");
        }
    }
}