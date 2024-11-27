using NUnit.Framework;
namespace LibraryTests;
using program;


public class PokemonTest
{
    [Test]
    public void CrearPokemon()
    {
        Pokemon pikachu = new Pokemon("Pikachu", 180, 150, 120, 150);

        Assert.That(pikachu.Nombre, Is.EqualTo("Pikachu"));
        Assert.That(pikachu.Vida, Is.EqualTo(180));
        Assert.That(pikachu.Velocidad, Is.EqualTo(150));
        Assert.That(pikachu.Ataque, Is.EqualTo(120));
        Assert.That(pikachu.Defensa, Is.EqualTo(150));
    }

    [Test]
    public void AprenderHabilidad()
    {
        Pokemon pikachu = new Pokemon("Pikachu", 180, 150, 120, 150);
        Ataques Trueno = new Ataques("Trueno", 110,  false);

        pikachu.AprenderHabilidad(Trueno);

        Assert.That(pikachu.Habilidades, Has.Count.EqualTo(1));
        Assert.That(pikachu.Habilidades[0].Nombre, Is.EqualTo("Trueno"));
    }

    [Test]
    public void MostrarHabilidades()
    {
        Pokemon pikachu = new Pokemon("Pikachu", 180, 150, 120, 150);
        Ataques Trueno = new Ataques("Trueno", 110,  false);
        pikachu.AprenderHabilidad(Trueno);
        

        Assert.That(pikachu.MostrarHabilidades(), Contains.Substring("Trueno"));
    }
}
