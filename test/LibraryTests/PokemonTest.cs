using NUnit.Framework;
namespace LibraryTests;
using Library;


public class PokemonTest
{
    /// <summary>
    /// Válida que un objeto <see cref="Pokemon"/> se inicialice correctamente.
    /// Comprueba las propiedades:
    /// <list type="bullet">
    /// <item><description>Nombre del Pokémon.</description></item>
    /// <item><description>Salud inicial y salud total.</description></item>
    /// <item><description>Tipo del Pokémon.</description></item>
    /// <item><description>Lista de ataques inicial (vacía).</description></item>
    /// </list>
    /// </summary>
    [Test]
    public void Pokemon()
    {
        var tipo_agua = new Tipos("Agua");
        var pokemon = new Pokemon("Squirtle", tipo_agua, 150);

        Assert.That(pokemon.Nombre, Is.EqualTo("Squirtle"));
        Assert.That(pokemon.Salud, Is.EqualTo(150));
        Assert.That(pokemon.SaludTotal, Is.EqualTo(150));
        Assert.That(pokemon.Tipo.NombreTipo, Is.EqualTo("Agua"));
        Assert.That(pokemon.Ataques.Count, Is.EqualTo(0));
    }

    /// <summary>
    /// Válida que un ataque se pueda agregar correctamente a la lista de ataques de un Pokémon.
    /// Comprueba que:
    /// <list type="bullet">
    /// <item><description>El ataque se añade a la lista de ataques.</description></item>
    /// <item><description>El nombre del ataque añadido es correcto.</description></item>
    /// </list>
    /// </summary>
    [Test]
    public void AgregarAtaques()
    {
        var tipo_fuego = new Tipos("Fuego");
        var pokemon = new Pokemon("Charmander", tipo_fuego, 100);
        var ataque = new Ataques("Lanzallamas", 90, tipo_fuego, true);
        pokemon.AgregarAtaques(ataque);

        Assert.That(pokemon.Ataques.Count, Is.EqualTo(1));
        Assert.That(pokemon.Ataques[0].Nombre, Is.EqualTo("Lanzallamas"));
    }

  
   
    /// <summary>
    /// Válida que el método <see cref="Pokemon.ConocerAtaques"/> devuelva correctamente
    /// los nombres de los ataques disponibles de un Pokémon.
    /// </summary>
    [Test]
    public void ConocerAtaques()
    {
        var tipoElectrico = new Tipos("Electrico");
        var pokemon = new Pokemon("Pikachu", tipoElectrico, 180);
        var ataque = new Ataques("Lanzallamas", 90, tipoElectrico, true);

        pokemon.AgregarAtaques(ataque);
        var resultado = pokemon.ConocerAtaques(pokemon);

        Assert.That(resultado, Contains.Substring("Lanzallamas"));
    }
}
