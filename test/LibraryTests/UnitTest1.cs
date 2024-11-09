using NUnit.Framework;
namespace LibraryTests;
using Library;

public class Tests
{


    [Test]
    public void Pokemon() //test para probar la clase Pokemon
    {
        Tipos tipoElectrico = new Tipos("Electrico"); //Creamos un tipo llamado Electrico
        Ataques ataqueRayo = new Ataques("Rayo", 50, tipoElectrico, false); //Creamos un ataque llamado Rayo
        List<IAtaque> ataques = new List<IAtaque> { ataqueRayo }; //A la lista de ataques agregamos Rayo
        Pokemon pokemon = new Pokemon("Pikachu", tipoElectrico, 100, ataques, new List<IAtaque>()); //creamos el pokemon Pikachu

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
    }

    [Test]
    public void Entrenador() //test para probar la clase Entrenador
    {
        Entrenador entrenador = new Entrenador("Guille"); //Creamos un entrenador 
        Tipos tipoHielo = new Tipos("Hielo"); //Creamos un tipo 
        Ataques ataqueCongelado = new Ataques("Congelado", 90, tipoHielo); //Creamos un ataque 
        Pokemon charmander = new Pokemon("Charmander", tipoHielo, 100, new List<IAtaque> { ataqueCongelado }, new List<IAtaque>()); //Crea el Pokémon 
        entrenador.SeleccionarPokemonAlEquipo(charmander); //Añadimos el pokemon en el equipo

        Assert.That(entrenador.Equipo.Count, Is.EqualTo(1));
        Assert.That(entrenador.Equipo[0].Nombre, Is.EqualTo("Charmander"));
    }

    [Test]
    public void Tipos() //test para probar la clase Tipos
    {
        Tipos tipoElectrico = new Tipos("Electrico"); //Creamos un tipo 
        Tipos tipoAgua = new Tipos("Agua"); //Creamos un tipo
        double efectividad = tipoElectrico.EfectividadDeDaño(tipoAgua); //Calcular la efectividad de daño entre los dos tipos

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

    public class AtaquesTests
    {
        [Test]
        public void Ataques()
        {
            var tipo_fuego = new Tipos("Fuego");
            var ataque = new Ataques("Lanzallamas", 90, tipo_fuego, true);
            
            Assert.That(ataque.Nombre, Is.EqualTo("Lanzallamas"));
            Assert.That(ataque.Daño, Is.EqualTo(90));
            Assert.That(ataque.Tipo, Is.EqualTo("Fuego"));
            Assert.That(ataque.EsEspecial, Is.True);
        }

    }

    public class BatallaTests
    {
        [Test]
        public void Batalla()
        {
            var entrenador1 = new Entrenador("Juan");
            var entrenador2 = new Entrenador("Mateo");
            var batalla = new Batalla(entrenador1, entrenador2);
            
            Assert.That(batalla.Entrenador1.Nombre, Is.EqualTo("Juan"));
            Assert.That(batalla.Entrenador2.Nombre, Is.EqualTo("Mateo"));
            
        }
        
        
        [Test]
        public void CambiarTurno()
        {
            var entrenador1 = new Entrenador("Juan");
            var entrenador2 = new Entrenador("Mateo");
            var batalla = new Batalla(entrenador1, entrenador1);

            var turno_inicial = batalla.MostrarTurnoActual();
            batalla.CambiarTurno();
            var turno_final = batalla.MostrarTurnoActual();
            
            Assert.That(turno_inicial, Is.Not.EqualTo(turno_final));
            
        }
    }

    public class EntrenadorTests
    {
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
        
    }

    public class PokemonTests
    {
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
        
        [Test]
        public void AgregarAtaques()
        {
            var tipo_fuego = new Timer("Fuego");
            var pokemon = new Pokemon("Charmander", tipo_fuego, 100);
            var ataque = new Ataques("Lanzallamas", 90, tipo_fuego, true);
            pokemon.AgregarAtaques(ataque);
            
            Assert.That(pokemon.Ataques.Count, Is.EqualTo(1));
            Assert.That(pokemon.Ataques[0].Nombre, Is.EqualTo("Lanzallamas"));
        }
        [Test]
        public void RecibirDaño()
        {
            var tipo_planta = new Tipos("Planta");
            var pokemon = new Pokemon("Bulbasaur", tipo_planta, 200);
            pokemon.recibirDaño(50);
            
            Assert.That(pokemon.Salud, Is.EqualTo(150));
        }
    }


    public class TiposTest
    {
        [Test]
        public void Tipos()
        { 
            var tipo_agua = new Tipos("Agua");
            
            Assert.That(tipo_agua.NombreTipo, Is.EqualTo("Agua"));
            
        }

        [Test]
        public void EfectividadDaño()
        {
            var tipo_agua = new Tipos("Agua");
            var tipo_fuego = new Tipos("Fuego");
            double efectividad = tipo_agua.efectividadDeDaño(tipo_fuego);
            
            Assert.That(efectividad, Is.EqualTo(2));
        }
        
    }
}
    