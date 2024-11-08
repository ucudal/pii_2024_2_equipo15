using NUnit.Framework;

namespace LibraryTests;
using Library;

public class Tests
{


    [Test]
    public void Pokemon() //test para probar la clase Pokemon
    {
        Tipos tipoElectrico = new Tipos("Electrico"); //Creamos un tipo llamado Electrico
        Ataques ataqueRayo = new Ataques("Rayo", 50, tipoElectrico); //Creamos un ataque llamado Rayo
        List<IAtaque> ataques = new List<IAtaque> { ataqueRayo }; //A la lista de ataques agregamos Rayo
        Pokemon pokemon = new Pokemon("Pikachu", tipoElectrico, 100); //creamos el pokemon Pikachu

        Assert.That(pokemon.Nombre, Is.EqualTo("Pikachu"));
        Assert.That(pokemon.Salud, Is.EqualTo(100));
        Assert.That(pokemon.Tipo.NombreTipo, Is.EqualTo("Electrico"));
        Assert.That(pokemon.Ataques.Count, Is.EqualTo(1));
    }


    [Test]
    public void Ataques() //test para probar la clase Ataques
    {
        Tipos tipoPlanta = new Tipos("planta"); //Creamos un tipo 
        Ataques ataque = new Ataques("Rayo solar", 90, tipoPlanta); //Creamos un ataque de tipo 

        Assert.That(ataque.Nombre, Is.EqualTo("Rayo solar"));
        Assert.That(ataque.Daño, Is.EqualTo(90));
        Assert.That(ataque.Tipo.NombreTipo, Is.EqualTo("planta"));
    }

    [Test]
    public void Entrenador() //test para probar la clase Entrenador
    {
        Entrenador entrenador = new Entrenador("Guille"); //Creamos un entrenador 
        Tipos tipoHielo = new Tipos("Hielo"); //Creamos un tipo 
        Ataques ataqueCongelado = new Ataques("Congelado", 90, tipoHielo); //Creamos un ataque 
        Pokemon charmander = new Pokemon("Charmander", tipoHielo, 100); //Crea el Pokémon 
        entrenador.AgregarPokemonAlEquipo(charmander); //Añadimos el pokemon en el equipo

        Assert.That(entrenador.Equipo.Count, Is.EqualTo(1));
        Assert.That(entrenador.Equipo[0].Nombre, Is.EqualTo("Charmander"));
    }

    [Test]
    public void Tipos() //test para probar la clase Tipos
    {
        Tipos tipoElectrico = new Tipos("Electrico"); //Creamos un tipo 
        Tipos tipoAgua = new Tipos("Agua"); //Creamos un tipo
        double efectividad = tipoElectrico.efectividadDeDaño(tipoAgua); //Calcular la efectividad de daño entre los dos tipos

        Assert.That(efectividad, Is.EqualTo(0));
    }
    [Test]
    public void Batalla() //test para probar la clase Batalla
    {
        Entrenador entrenador1 = new Entrenador("Bielsa"); //Creamos un entrenador
        Entrenador entrenador2 = new Entrenador("Tabarez"); //Creamos un entrenador 
        Batalla batalla = new Batalla(entrenador1, entrenador2); //batalla entre los entrenadores
        
        Assert.That(batalla.Entrenador1.Nombre, Is.EqualTo("Bielsa"));
        Assert.That(batalla.Entrenador2.Nombre, Is.EqualTo("Tabarez"));
        
    } 
public class AtaquesTest
{
    [Test]
    public void Constructor()
    {
        string nombre = "Impactrueno";
        int daño = 40;
        ITipo tipo = new Tipos("Electrico");

        var ataque = new Ataques(nombre, daño, tipo);

        Assert.AreEqual(nombre, ataque.Nombre);
        Assert.AreEqual(daño, ataque.Daño);
        Assert.AreEqual(tipo, ataque.Tipo);
            


    }
        
}

public class Batalla
{
    [Test]
    public void CambiarTurno()
    {
        var entrenador1 = new Entrenador("Juan");
        var entrenador2 = new Entrenador("Ash");
        var batlla = new Batalla(entrenador1, entrenador2);
        bool turno_inicial =    batalla.MostrarTurnoActual().Contains(entrenador1.Nombre);
        batalla.CambiarTurno();
        bool turno_final = batalla.MostrarTurnoActual().Contains(entrenador1.Nombre);

        Assert.AreNotEqual(turno_inicial, turno_final);


    }

    [Test]
    public void CambiarPokemon()
    {
        var entrenador = new Entrenador("Juan");
        var pokemon_actual = new Pokemon("Charizard", new Tipos("Fuego"), 110);
        var nuevo_pokemon = new Pokemon("Pikachu", new Tipos("Electrico"), 130);
        entrenador.AgregarPokemon(pokemon_actual);
        entrenador.AgregarPokemon(nuevo_pokemon);

        var batalla = new Batalla(entrenador, new Entrenador("Ash"));
        var resultado = batalla.CambiarPokemon(entrenador, nuevo_pokemon);
        Assert.AreEqual("El entrenador que tenia el turno cambio de pokemon y pierde su turno", resultado);
    }
}

public class Entrenador
{
    [Test]
    public void AgregarPokemon()
    {
        var entrenador = new Entrenador("Juan");
        var pokemon = new Pokemon("Gengar", new Tipos("Fantasma"), 100);
        var resultado = entrenador.AgregarPokemon(pokemon);

        Assert.AreEqual("Se agrego a Gengar al equipo");
    }
    public void CambiarPokemon()
    {
        var entrenador = new Entrenador("Juan");
        var pokemon_actual = new Pokemon("Bulbasur", new Tipos("Planta"), 90);
        var nuevo_pokemon = new Pokemon("Squirtle", new Tipos("Agua"), 80);
        entrenador.AgregarPokemon(pokemon_actual);
        var resultado = entrenador.CambiarPokemon(pokemon_actual, nuevo_pokemon);

        Assert.AreEqual("Se cambio a Bulbasur por Squirtle", resultado);
        Assert.Contains(nuevo_pokemon, entrenador.Equipo);
    
    }
}    
public class Entrenador
{
    [Test]
    public void AgregarPokemon()
    {
        var entrenador = new Entrenador("Juan");
        var pokemon = new Pokemon("Gengar", new Tipos("Fantasma"), 100);
        var resultado = entrenador.AgregarPokemon(pokemon);

        Assert.AreEqual("Se agrego a Gengar al equipo");
    }
    public void CambiarPokemon()
    {
        var entrenador = new Entrenador("Juan");
        var pokemon_actual = new Pokemon("Bulbasur", new Tipos("Planta"), 90);
        var nuevo_pokemon = new Pokemon("Squirtle", new Tipos("Agua"), 80);
        entrenador.AgregarPokemon(pokemon_actual);
        var resultado = entrenador.CambiarPokemon(pokemon_actual, nuevo_pokemon);

        Assert.AreEqual("Se cambio a Bulbasur por Squirtle", resultado);
        Assert.Contains(nuevo_pokemon, entrenador.Equipo);
    
    }
}    

public class Pokemon
{
    [Test]
    public void RecibirDaño()
    {
        var pokemon = new Pokemon("Charizard", new Tipos("Fuego"), 100);
        pokemon.RecibirDaño(40);

        Assert.AreEqual(60, pokemon.Salud);
    }
    public void MostrarSalud()
    {
        var pokemon = new Pokemon("Hypno", new Tipos("Psiquico"), 130);
        pokemon.RecibirDaño(20);
        var resultado = pokemon.MostrarSalud(pokemon);

        Assert.AreEqual("130/150", resultado);
        
    
    }
}    
public class Tipos
{
    [Test]
    public void AltaEfectividad()
    {
        var tipo_ataque = new Tipos("Agua");
        var tipo_objetivo = new Tipos("Fuego");

        int efectividad = tipo_ataque.AltaEfectividad(tipo_objetivo);

        Assert.AreEqual(4, efectividad);
    }    
    public void MediaEfectividad()
    {
        var tipo_ataque = new Tipos("Agua");
        var tipo_objetivo = new Tipos("Agua");

        int efectividad = tipo_ataque.MediaEfectividad(tipo_objetivo);

        Assert.AreEqual(3, efectividad);
    
    } 
    public void BajaEfectividad()
    {
        var tipo_ataque = new Tipos("Electrico");
        var tipo_objetivo = new Tipos("Tierra");

        int efectividad = tipo_ataque.BajaEfectividad(tipo_objetivo);

        Assert.AreEqual(2, efectividad);
    
    } 
    
}    

}

