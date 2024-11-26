using NUnit.Framework;
namespace LibraryTests;
using program;

[TestFixture]
public class PokemonTest
{
    [Test]
    public void CrearPokemon()
    {
        var tipoElectrico = new Tipos("Electrico", new Dictionary<string, double>());
        var pokemon = new Pokemon("Pikachu", 100, tipoElectrico, velocidad: 120, ataque: 50, defensa: 40);

        Assert.That(pokemon.Nombre, Is.EqualTo("Pikachu"));
        Assert.That(pokemon.Vida, Is.EqualTo(100));
        Assert.That(pokemon.Velocidad, Is.EqualTo(120));
        Assert.That(pokemon.Ataque, Is.EqualTo(50));
        Assert.That(pokemon.Defensa, Is.EqualTo(40));
    }

    [Test]
    public void AprenderHabilidad()
    {
        var tipoElectrico = new Tipos("Electrico", new Dictionary<string, double>());
        var habilidad = new Habilidades("Impactrueno", tipoElectrico, 40, 90, 15, false);
        var pokemon = new Pokemon("Pikachu", 100, tipoElectrico);

        pokemon.AprenderHabilidad(habilidad);

        Assert.That(pokemon.Habilidades.Count, Is.EqualTo(1));
        Assert.That(pokemon.Habilidades[0].Nombre, Is.EqualTo("Impactrueno"));
    }

    [Test]
    public void MostrarHabilidades()
    {
        var tipoElectrico = new Tipos("Electrico", new Dictionary<string, double>());
        var habilidad = new Habilidades("Impactrueno", tipoElectrico, 40, 90, 15, false);
        var pokemon = new Pokemon("Pikachu", 100, tipoElectrico);

        pokemon.AprenderHabilidad(habilidad);
        var resultado = pokemon.MostrarHabilidades();

        Assert.That(resultado, Contains.Substring("Impactrueno"));
    }
}
