using NUnit.Framework;
namespace LibraryTests;
using Library;

public class EntrenadorTest
{
    /// <summary>
    /// Válida la correcta inicialización de un objeto <see cref="Entrenador"/>.
    /// Comprueba que los valores predeterminados de las propiedades del entrenador sean correctos:
    /// <list type="bullet">
    /// <item><description>Nombre del entrenador.</description></item>
    /// <item><description>Equipo inicial vacío.</description></item>
    /// <item><description>Cantidad de ítems iniciales.</description></item>
    /// </list>
    /// </summary>
    [Test]
    public void Entrenador()
    {
        var entrenador = new Entrenador("Montecristo");

        Assert.That(entrenador.Nombre, Is.EqualTo("Montecristo"));
        Assert.That(entrenador.Equipo.Count, Is.EqualTo(0));
        Assert.That(entrenador.SuperPociones, Is.EqualTo(4));
        Assert.That(entrenador.Revivir, Is.EqualTo(1));
        Assert.That(entrenador.CuraTotal, Is.EqualTo(2));
    }

    /// <summary>
    /// Válida que un Pokémon se pueda agregar al equipo del entrenador.
    /// Comprueba que el Pokémon aparece en la lista de equipo y que el mensaje de retorno es correcto.
    /// </summary>
    [Test]
    public void AgregarPokemon()
    {
        var entrenador = new Entrenador("Montecristo");
        var tipo_roca = new Tipos("Roca");
        var pokemon = new Pokemon("Onix", tipo_roca, 200);
        var resultado = entrenador.AgregarPokemonAlEquipo(pokemon);

        Assert.That(entrenador.Equipo.Count, Is.EqualTo(1));
        Assert.That(entrenador.Equipo[0].Nombre, Is.EqualTo("Onix"));
        Assert.That(resultado, Contains.Substring("Onix ahora forma parte del equipo"));
    }

    /// <summary>
    /// Válida que el método <see cref="Entrenador.Atacar"/> reduzca correctamente la salud
    /// del Pokémon objetivo en base al daño del ataque utilizado.
    /// </summary>
    [Test]
    public void Atacar()
    {
        var tipoFuego = new Tipos("Fuego");
        var tipoPlanta = new Tipos("Planta");
        var ataque = new Ataques("Lanzallamas", 90, tipoFuego, true);
        var pokemon1 = new Pokemon("Charmander", tipoFuego, 200);
        var pokemon2 = new Pokemon("Bulbasaur", tipoPlanta, 200);

        var entrenador = new Entrenador("Josue");
        var daño = entrenador.Atacar(pokemon2, ataque);

        Assert.That(pokemon2.Salud, Is.EqualTo(200 - daño));
    }

    /// <summary>
    /// Válida el uso de una Súper Poción para curar a un Pokémon.
    /// Comprueba que la salud del Pokémon aumenta y que el mensaje retornado es correcto.
    /// </summary>
    [Test]
    public void ItemSuperPocion()
    {
        var tipoFuego = new Tipos("Fuego");
        var pokemon = new Pokemon("Charmander", tipoFuego, 100);
        var entrenador = new Entrenador("Nicolas");

        pokemon.Salud = 50;
        var resultado = entrenador.ItemSuperPocion(pokemon);

        Assert.That(pokemon.Salud, Is.EqualTo(120));
        Assert.That(resultado, Contains.Substring("recupera 70 puntos de vida"));
    }

    /// <summary>
    /// Válida el uso del ítem Revivir para restaurar parcialmente la salud de un Pokémon debilitado.
    /// </summary>
    [Test]
    public void ItemRevivir()
    {
        var tipoAgua = new Tipos("Agua");
        var pokemon = new Pokemon("Samurott", tipoAgua, 300);
        var entrenador = new Entrenador("Madara");

        pokemon.Salud = 0;
        var resultado = entrenador.ItemRevivir(pokemon);

        Assert.That(pokemon.Salud, Is.GreaterThan(0));
        Assert.That(resultado, Contains.Substring("Uso el item revivir"));
    }

    /// <summary>
    /// Válida el uso del ítem Cura Total para eliminar efectos de estado (como quemaduras o envenenamientos) de un Pokémon.
    /// </summary>
    [Test]
    public void ItemCuraTotal()
    {
        var tipoDragon = new Tipos("Dragon");
        var pokemon = new Pokemon("Goodra", tipoDragon, 290);
        var entrenador = new Entrenador("Joaquin");

        pokemon.EstaQuemado = true;
        var resultado = entrenador.ItemCuraTotal(pokemon);

        Assert.That(pokemon.EstaQuemado, Is.False);
        Assert.That(resultado, Contains.Substring("usó una curacion total"));
    }

    /// <summary>
    /// Válida que el método <see cref="Entrenador.MostrarPokemon"/> devuelva correctamente
    /// los nombres de los Pokémon en el equipo del entrenador.
    /// </summary>
    [Test]
    public void MostrarPokemon()
    {
        var tipoFuego = new Tipos("Fuego");
        var pokemon = new Pokemon("Charmander", tipoFuego, 200);
        var entrenador = new Entrenador("Aizen");

        entrenador.AgregarPokemonAlEquipo(pokemon);
        var resultado = entrenador.MostrarPokemon();

        Assert.That(resultado, Contains.Substring("Charmander"));
    }
}
