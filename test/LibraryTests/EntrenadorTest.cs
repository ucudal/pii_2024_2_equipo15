/*using NUnit.Framework;
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
        Assert.That(resultado, Contains.Substring("¡Se ha agragado a Onix al equipo!"));
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
    
    [Test]
    public void Atacar_EfectosSecundarios()
    {
        var tipoFuego = new Tipos("Fuego");
        var tipoPlanta = new Tipos("Planta");
        var ataque = new Ataques("Lanzallamas", 90, tipoFuego, true);
        var pokemon1 = new Pokemon("Charmander", tipoFuego, 200);
        var pokemon2 = new Pokemon("Bulbasaur", tipoPlanta, 200);

        var entrenador = new Entrenador("Josue");
        entrenador.Atacar(pokemon2, ataque);

        Assert.That(pokemon2.EstaQuemado, Is.True); // Verificar que se aplicó el efecto de quemadura.
    }
    
    [Test]
    public void Atacar_Paralisis()
    {
        var tipoElectrico = new Tipos("Electrico");
        var tipoPlanta = new Tipos("Planta");
        var ataque = new Ataques("Impactrueno", 40, tipoElectrico, true);
        var pokemon1 = new Pokemon("Pikachu", tipoElectrico, 180);
        var pokemon2 = new Pokemon("Bulbasaur", tipoPlanta, 200);

        var entrenador = new Entrenador("Ash");
        entrenador.Atacar(pokemon2, ataque);

        Assert.That(pokemon2.EstaParalizado, Is.True);
    }
    
    [Test]
    public void Atacar_Envenenamiento()
    {
        var tipoVeneno = new Tipos("Veneno");
        var tipoPlanta = new Tipos("Planta");
        var ataque = new Ataques("LanzaMugre", 65, tipoVeneno, true);
        var pokemon1 = new Pokemon("Muk", tipoVeneno, 220);
        var pokemon2 = new Pokemon("Bulbasaur", tipoPlanta, 200);

        var entrenador = new Entrenador("Giovanni");
        entrenador.Atacar(pokemon2, ataque);

        Assert.That(pokemon2.EstaEnvenenado, Is.True);
    }
    
    [Test]
    public void Atacar_Sueño()
    {
        var tipoPlanta = new Tipos("Planta");
        var tipoNormal = new Tipos("Normal");
        var ataque = new Ataques("DanzaPetalo", 120, tipoPlanta, true);
        var pokemon1 = new Pokemon("Vileplume", tipoPlanta, 220);
        var pokemon2 = new Pokemon("Snorlax", tipoNormal, 300);

        var entrenador = new Entrenador("Rosa");
        entrenador.Atacar(pokemon2, ataque);

        Assert.That(pokemon2.EstaDormido, Is.True);
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

        Assert.That(pokemon.Salud, Is.EqualTo(100));
        Assert.That(resultado, Contains.Substring("Nicolas usó una Súper poción, Charmander recupera 70 puntos de HP.\nQuedan 3 Súper pociones para utilizar."));
    }
    
    [Test]
    public void ItemSuperPocion_NoDisponible()
    {
        var tipoFuego = new Tipos("Fuego");
        var pokemon = new Pokemon("Charmander", tipoFuego, 100);
        var entrenador = new Entrenador("Nicolas");

        entrenador.SuperPociones = 0; // No hay superpociones disponibles
        var resultado = entrenador.ItemSuperPocion(pokemon);

        Assert.That(resultado, Is.EqualTo("No quedan Súper pociones para utilizar"));
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
        Assert.That(resultado, Contains.Substring("Madara usó el item Revivir en Samurott.\nNo quedan más items de Revivir para utilizar."));
    }
    
    [Test]
    public void ItemRevivir_NoDisponible()
    {
        var tipoAgua = new Tipos("Agua");
        var pokemon = new Pokemon("Samurott", tipoAgua, 300);
        var entrenador = new Entrenador("Madara");

        // Pokémon no debilitado
        pokemon.Salud = 200;
        var resultado = entrenador.ItemRevivir(pokemon);

        Assert.That(resultado, Is.EqualTo("No poseé más items para Revivir o el Pokémon aún no está debilitado."));
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
        Assert.That(resultado, Contains.Substring("Joaquin usó una Cura Total en Goodra.\nQueda 1 item disponible de Cura total para utilizar."));
    }
    
    [Test]
    public void ItemCuraTotal_NoDisponible()
    {
        var tipoDragon = new Tipos("Dragon");
        var pokemon = new Pokemon("Goodra", tipoDragon, 290);
        var entrenador = new Entrenador("Joaquin");

        pokemon.EstaQuemado = false; // Sin efectos de estado
        var resultado = entrenador.ItemCuraTotal(pokemon);

        Assert.That(resultado, Is.EqualTo("No quedan Curas Totales para utilizar o el Pokémon no tiene un efecto."));
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
    
    [Test]
    public void CambiarPokemonDeEquipo()
    {
        var tipoPsiquico = new Tipos("Psiquico");
        var tipoVolador = new Tipos("Volador");
        var pokemon1 = new Pokemon("Mewtwo", tipoPsiquico, 305);
        var pokemon2 = new Pokemon("Pidgeotto", tipoVolador, 236);
    
        var entrenador = new Entrenador("Juan");
        entrenador.AgregarPokemonAlEquipo(pokemon1);
        
        var resultado = entrenador.CambiarPokemonDeEquipo(pokemon1, pokemon2);

        Assert.That(resultado, Is.EqualTo($"Se ha cambiado a {pokemon1.Nombre} por {pokemon2.Nombre}"));
        Assert.That(entrenador.Equipo[0].Nombre, Is.EqualTo("Pidgeotto"));
    }

    [Test]
    public void CambiarPokemonDeEquipo_NoEncontrado()
    {
        var tipoPsiquico = new Tipos("Psiquico");
        var tipoBicho = new Tipos("Bicho");
        var tipoHielo = new Tipos("Hielo");
        var pokemon1 = new Pokemon("Hypno", tipoPsiquico, 220);
        var pokemon2 = new Pokemon("Pinsir", tipoBicho, 240);
        var pokemon3 = new Pokemon("Beartic", tipoHielo, 300);
    
        var entrenador = new Entrenador("Juan");
        entrenador.AgregarPokemonAlEquipo(pokemon1);
        
        var resultado = entrenador.CambiarPokemonDeEquipo(pokemon3, pokemon2);

        Assert.That(resultado, Is.EqualTo($"{pokemon3.Nombre} no está en el equipo"));
    }

    [Test]
    public void UnirseAListaDeEspera()
    {
        var entrenador1 = new Entrenador("Ichigo");
        var entrenador2 = new Entrenador("Kenshi");
        var listaEspera = new List<Entrenador>();
        
        var resultado1 = entrenador1.UnirseAListaDeEspera(listaEspera);
        Assert.That(resultado1, Is.EqualTo("Ichigo se ha unido a la lista de espera para una batalla."));
        Assert.That(listaEspera.Count, Is.EqualTo(1)); 
        
        var resultado2 = entrenador2.UnirseAListaDeEspera(listaEspera);
        Assert.That(resultado2, Is.EqualTo("Kenshi se ha unido a la lista de espera para una batalla."));
        Assert.That(listaEspera.Count, Is.EqualTo(2)); 
    }
}
*/