namespace LibraryTests;
using NUnit.Framework;
using program;

public class EntrenadorTest
{
    [Test]
    public void CrearEntrenador()
    {
        var entrenador = new Entrenador("Ash");
        Assert.That(entrenador.Nombre, Is.EqualTo("Ash"));
    }

    [Test]
    public void AñadirPokemon()
    {
        var entrenador = new Entrenador("Ash");
        Pokemon pikachu = new Pokemon("Pikachu", 180, 150, 120, 150);

        var resultado = entrenador.AñadirPokemon(pikachu);

        Assert.That(resultado, Is.True);
        Assert.That(entrenador.Pokemones.Count, Is.EqualTo(1));
        Assert.That(entrenador.Pokemones[0].Nombre, Is.EqualTo("Pikachu"));
    }

    [Test]
    public void AñadirPokemonExistente()
    {
        var entrenador = new Entrenador("Ash");
        Pokemon pikachu = new Pokemon("Pikachu", 180, 150, 120, 150);

        entrenador.AñadirPokemon(pikachu);
        var resultado = entrenador.AñadirPokemon(pikachu);

        Assert.That(resultado, Is.False); 
        Assert.That(entrenador.Pokemones.Count, Is.EqualTo(1)); 
    }

    [Test]
    public void AñadirPokemonEquipoLleno()
    {
        var entrenador = new Entrenador("Ash");
        Pokemon pikachu = new Pokemon("Pikachu", 180, 150, 120, 150);
        Pokemon charizard = new Pokemon("Charizard", 266, 100, 80, 200);
        Pokemon blastoise = new Pokemon("Blastoise", 268, 120, 80, 160);
        Pokemon gengar = new Pokemon("Gengar", 261, 120, 95, 140);
        Pokemon dragonite = new Pokemon("Dragonite", 300, 200, 100, 110);
        Pokemon machamp = new Pokemon("Machamp", 290, 200, 100, 120);

        entrenador.AñadirPokemon(pikachu);
        entrenador.AñadirPokemon(charizard);
        entrenador.AñadirPokemon(blastoise);
        entrenador.AñadirPokemon(gengar);
        entrenador.AñadirPokemon(dragonite);
        entrenador.AñadirPokemon(machamp);


        Pokemon snorlax = new Pokemon("Snorlax", 450, 50, 110, 200);
        var resultado = entrenador.AñadirPokemon(snorlax);

        Assert.That(resultado, Is.False); 
        Assert.That(entrenador.Pokemones.Count, Is.EqualTo(6)); 
    }
    

    [Test]
    public void FijarPokemonActual()
    {
        var entrenador = new Entrenador("Ash");
        Pokemon pikachu = new Pokemon("Pikachu", 180, 150, 120, 150);

        entrenador.AñadirPokemon(pikachu);
        var resultado = entrenador.FijarPokemonActual(pikachu);

        Assert.That(resultado, Is.True);
        Assert.That(entrenador.PokemonActivo, Is.EqualTo(pikachu));
    }
    [Test]
    public void FijarPokemonActualSinPokemonEspecificadoConPokemonVivo()
    {
        var entrenador = new Entrenador("Ash");
        Pokemon pikachu = new Pokemon("Pikachu", 180, 150, 120, 150);
        Pokemon charmander = new Pokemon("Charmander", 0, 100, 80, 70);

        entrenador.AñadirPokemon(charmander);
        entrenador.AñadirPokemon(pikachu);
        var resultado = entrenador.FijarPokemonActual();

        Assert.That(resultado, Is.True);
        Assert.That(entrenador.PokemonActivo, Is.EqualTo(pikachu));
    }
    
    [Test]
    public void FijarPokemonActualSinPokemonEspecificadoSinPokemonVivo()
    {
        var entrenador = new Entrenador("Ash");
        Pokemon charmander = new Pokemon("Charmander", 0, 100, 80, 70); // Pokémon sin vida

        entrenador.AñadirPokemon(charmander);
        var resultado = entrenador.FijarPokemonActual();

        Assert.That(resultado, Is.False); // No debe fijarse ningún Pokémon activo
        Assert.That(entrenador.PokemonActivo, Is.Null); // No hay Pokémon vivos
    }


    [Test]
    public void FijarPokemonActualPokemonSinVida()
    {
        var entrenador = new Entrenador("Ash");
        Pokemon charmander = new Pokemon("Charmander", 0, 100, 80, 70);

        entrenador.AñadirPokemon(charmander);
        var resultado = entrenador.FijarPokemonActual(charmander);

        Assert.That(resultado, Is.False);
        Assert.That(entrenador.PokemonActivo, Is.Null);
    }
    
    [Test]
    public void TienePokemonesVivos()
    {
        var entrenador = new Entrenador("Ash");
        Pokemon pikachu = new Pokemon("Pikachu", 0, 150, 120, 150);

        entrenador.AñadirPokemon(pikachu);
        Assert.That(entrenador.TienePokemonesVivos(), Is.False);

        pikachu.Vida = 50;
        Assert.That(entrenador.TienePokemonesVivos(), Is.True);
    }
    
    [Test]
    public void ObtenerPokemonPorNombre()
    {
        var entrenador = new Entrenador("Ash");
        Pokemon pikachu = new Pokemon("Pikachu", 180, 150, 120, 150);

        entrenador.AñadirPokemon(pikachu);
        var resultado = entrenador.ObtenerPokemonPorNombre("Pikachu");

        Assert.That(resultado, Is.EqualTo(pikachu));
    }
    
      [Test]
    public void RecibirEquipoPokemon()
    {
        var entrenador = new Entrenador("Ash");
        Pokemon pikachu = new Pokemon("Pikachu", 180, 150, 120, 150);

        entrenador.AñadirPokemon(pikachu);
        var equipo = entrenador.RecibirEquipoPokemon();

        Assert.That(equipo, Has.Count.EqualTo(1));
        Assert.That(equipo[0], Is.EqualTo(pikachu));
    }
    [Test]
    public void EnBatalla()
    {
        var entrenador = new Entrenador("Ash");
        entrenador.EnBatalla = true;

        Assert.That(entrenador.EnBatalla, Is.True);
    }
}