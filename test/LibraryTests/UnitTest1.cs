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
        Assert.That(batalla.Entrenador2.Nombre, Is.EqualTo("Tabarez"));    }
}