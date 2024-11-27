/*namespace LibraryTests;
using NUnit.Framework;
using program;

public class EntrenadorTest
{
    [Test]
    public void CrearEntrenador()
    {
        var entrenador = new Entrenador("Ash");
        Assert.That(entrenador.Nombre, Is.EqualTo("Ash"));
        Assert.That(entrenador.Pokemones, Is.Empty);
    }

    [Test]
    public void AñadirPokemon_Correcto()
    {
        var entrenador = new Entrenador("Ash");
        var pikachu = new Pokemon("Pikachu", 100, new Tipos("Electrico", new Dictionary<string, double>()));

        // Añadir un Pokémon al equipo
        var resultado = entrenador.AñadirPokemon(pikachu);

        Assert.That(resultado, Is.True);
        Assert.That(entrenador.Pokemones.Count, Is.EqualTo(1));
        Assert.That(entrenador.Pokemones[0].Nombre, Is.EqualTo("Pikachu"));
    }

    [Test]
    public void AñadirPokemon_YaEnEquipo()
    {
        var entrenador = new Entrenador("Ash");
        var pikachu = new Pokemon("Pikachu", 100, new Tipos("Electrico", new Dictionary<string, double>()));

        // Añadir el mismo Pokémon dos veces
        entrenador.AñadirPokemon(pikachu);
        var resultado = entrenador.AñadirPokemon(pikachu);

        Assert.That(resultado, Is.False); // No se debe añadir dos veces
        Assert.That(entrenador.Pokemones.Count, Is.EqualTo(1)); // El equipo debe seguir teniendo un solo Pokémon
    }

    [Test]
    public void AñadirPokemon_EquipoLleno()
    {
        var entrenador = new Entrenador("Ash");

        // Añadir 6 Pokémon al equipo
        for (int i = 0; i < 6; i++)
        {
            entrenador.AñadirPokemon(new Pokemon($"Pokemon{i}", 100, new Tipos("Normal", new Dictionary<string, double>())));
        }

        // Intentar añadir un séptimo Pokémon
        var nuevoPokemon = new Pokemon("ExtraPokemon", 100, new Tipos("Electrico", new Dictionary<string, double>()));
        var resultado = entrenador.AñadirPokemon(nuevoPokemon);

        Assert.That(resultado, Is.False); // No debe permitirse añadir más de 6 Pokémon
        Assert.That(entrenador.Pokemones.Count, Is.EqualTo(6)); // El equipo debe seguir teniendo 6 Pokémon
    }

    [Test]
    public void AñadirPokemon_EstablecerPokemonActivo()
    {
        var entrenador = new Entrenador("Ash");
        var pikachu = new Pokemon("Pikachu", 100, new Tipos("Electrico", new Dictionary<string, double>()));

        // Añadir un Pokémon al equipo
        entrenador.AñadirPokemon(pikachu);

        // Verificar que el Pokémon activo se estableció automáticamente
        Assert.That(entrenador.PokemonActivo, Is.EqualTo(pikachu));
    }
    [Test]
    public void FijarPokemonActual()
    {
        var entrenador = new Entrenador("Ash");
        var pikachu = new Pokemon("Pikachu", 100, new Tipos("Electrico", new Dictionary<string, double>()));

        entrenador.AñadirPokemon(pikachu);
        var resultado = entrenador.FijarPokemonActual();

        Assert.That(resultado, Is.True);
        Assert.That(entrenador.PokemonActivo, Is.EqualTo(pikachu));
    }

    [Test]
    public void TienePokemonesVivos()
    {
        var entrenador = new Entrenador("Ash");
        var pikachu = new Pokemon("Pikachu", 0, new Tipos("Electrico", new Dictionary<string, double>()));

        entrenador.AñadirPokemon(pikachu);
        Assert.That(entrenador.TienePokemonesVivos(), Is.False);

        pikachu.Vida = 50;
        Assert.That(entrenador.TienePokemonesVivos(), Is.True);
    }
    
    [Test]
    public void ObtenerPokemonPorNombre()
    {
        var entrenador = new Entrenador("Ash");
        var pikachu = new Pokemon("Pikachu", 100, new Tipos("Electrico", new Dictionary<string, double>()));

        entrenador.AñadirPokemon(pikachu);
        var resultado = entrenador.ObtenerPokemonPorNombre("Pikachu");

        Assert.That(resultado, Is.EqualTo(pikachu));
    }
    
    [Test]
    public void RecibirEquipoPokemon()
    {
        var entrenador = new Entrenador("Ash");
        var pikachu = new Pokemon("Pikachu", 100, new Tipos("Electrico", new Dictionary<string, double>()));

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
}*/