namespace LibraryTests;
using NUnit.Framework;
using program;


public class LogicaTest
{
    
    [Test]
    public void ObtenerPokemon()
    {
        var logica = Logica.Instance;
        var pokemon = logica.ObtenerPokemon("Pikachu");

        Assert.That(pokemon, Is.Not.Null);
        Assert.That(pokemon.Nombre, Is.EqualTo("Pikachu"));
    }

    [Test]
    public void MostrarPokemones()
    {
        var logica = Logica.Instance;
        var resultado = logica.MostrarPokemones();

        Assert.That(resultado, Contains.Substring("Pikachu"));
        Assert.That(resultado, Contains.Substring("Charizard"));
    }
    
    [Test]
    public void ObtenerTodos()
    {
        var logica = Logica.Instance;
        var pokemones = logica.ObtenerTodos();

        Assert.That(pokemones, Is.Not.Empty);
        Assert.That(pokemones.Count, Is.GreaterThan(0));
        Assert.That(pokemones[0], Is.InstanceOf<Pokemon>());
    }

    [Test]
    public void MostrarAtaquesDePokemones()
    {
        var logica = Logica.Instance;
        var pokemon = logica.ObtenerPokemon("Pikachu");
        var resultado = pokemon.MostrarHabilidades();

        Assert.That(resultado, Contains.Substring("Placaje"));
    }
}
