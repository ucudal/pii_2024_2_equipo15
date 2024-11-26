/*using NUnit.Framework;
namespace LibraryTests;
using Library;

public class BatallaTest
{
    /// <summary>
    /// Válida que los entrenadores inicializados en la batalla sean los esperados.
    /// Comprueba que las propiedades <see cref="Batalla.Entrenador1"/> y <see cref="Batalla.Entrenador2"/> 
    /// correspondan a los valores dados durante la creación de la batalla.
    /// </summary>
    [Test]
    public void Batalla()
    {
        var entrenador1 = new Entrenador("Juan");
        var entrenador2 = new Entrenador("Mateo");
        var batalla = new Batalla(entrenador1, entrenador2);

        Assert.That(batalla.Entrenador1.Nombre, Is.EqualTo("Juan"));
        Assert.That(batalla.Entrenador2.Nombre, Is.EqualTo("Mateo"));
        Assert.That(batalla.MostrarTurnoActual(), Is.EqualTo($"Es el turno de: {entrenador1.Nombre}").Or.EqualTo($"Es el turno de: {entrenador2.Nombre}"));
    }

    /// <summary>
    /// Válida el cambio de turno en la batalla.
    /// Comprueba que el turno actual cambia después de llamar al método <see cref="Batalla.CambiarTurno"/>.
    /// </summary>
    [Test]
    public void CambiarTurno()
    {
        var entrenador1 = new Entrenador("Juan");
        var entrenador2 = new Entrenador("Mateo");
        var batalla = new Batalla(entrenador1, entrenador2);

        var turnoInicial = batalla.MostrarTurnoActual();
        batalla.CambiarTurno();
        var turnoFinal = batalla.MostrarTurnoActual();

        Assert.That(turnoInicial, Is.Not.EqualTo(turnoFinal));
    }
    
    /// <summary>
    /// Válida que el método <see cref="Batalla.ConocerGanador"/> devuelva el entrenador ganador
    /// cuando todos los Pokémon de uno de los entrenadores están debilitados.
    /// </summary>
    [Test]
    public void ConocerGanador()
    {
        var entrenador1 = new Entrenador("Juan");
        var entrenador2 = new Entrenador("Mateo");
        var batalla = new Batalla(entrenador1, entrenador2);
        
        entrenador1.AgregarPokemonAlEquipo(new Pokemon("Charmander", new Tipos("Fuego"), 50));
        entrenador2.AgregarPokemonAlEquipo(new Pokemon("Squirtle", new Tipos("Agua"), 0)); 
        Assert.That(batalla.ConocerGanador(), Contains.Substring($"El equipo de {entrenador1.Nombre} ha ganado"));

        entrenador1.Equipo[0].Salud = 0; 
        entrenador2.Equipo[0].Salud = 50; 
        Assert.That(batalla.ConocerGanador(), Contains.Substring($"El equipo de {entrenador2.Nombre} ha ganado"));

        entrenador1.Equipo[0].Salud = 50; 
        Assert.That(batalla.ConocerGanador(), Is.Null);
    }

    /// <summary>
    /// Válida que el método <see cref="Batalla.PokemonDebilitado"/> identifique correctamente
    /// si un Pokémon ha sido derrotado en la batalla.
    /// </summary>
    [Test]
    public void PokemonDebilitado()
    {
        var entrenador1 = new Entrenador("Juan");
        var entrenador2 = new Entrenador("Mateo");
        var batalla = new Batalla(entrenador1, entrenador2);

        // Aseguramos que entrenador1 tenga al menos un Pokémon
        entrenador1.AgregarPokemonAlEquipo(new Pokemon("Charmander", new Tipos("Fuego"), 0));
        entrenador2.AgregarPokemonAlEquipo(new Pokemon("Squirtle", new Tipos("Agua"), 100));
        
        var resultado1 = batalla.PokemonDebilitado();
        Assert.That(resultado1, Is.EqualTo("Charmander ha sido abatido"));
        
        entrenador1.Equipo[0].Salud = 50; // Revive al Pokémon de Entrenador1
        entrenador2.Equipo[0].Salud = 0;  // Debilita al Pokémon de Entrenador2

        var resultado2 = batalla.PokemonDebilitado();
        Assert.That(resultado2, Is.EqualTo("Squirtle ha sido abatido"));

        //No hay Pokémon debilitados en ninguno de los equipos
        entrenador1.Equipo[0].Salud = 50;
        entrenador2.Equipo[0].Salud = 50;

        var resultado3 = batalla.PokemonDebilitado();
        Assert.That(resultado3, Is.Null);
    }

    /// <summary>
    /// Válida que el método <see cref="Batalla.MostrarTurnoActual"/> devuelva correctamente
    /// el entrenador cuyo turno es el actual.
    /// </summary>
    [Test]
    public void MostrarTurnoActual()
    {
        var entrenador1 = new Entrenador("Juan");
        var entrenador2 = new Entrenador("Mateo");
        var batalla = new Batalla(entrenador1, entrenador2);

        var turnoInicial = batalla.MostrarTurnoActual();
        Assert.That(turnoInicial, Is.EqualTo($"Es el turno de: {entrenador1.Nombre}") .Or.EqualTo($"Es el turno de: {entrenador2.Nombre}"));
        batalla.CambiarTurno();

        var turnoFinal = batalla.MostrarTurnoActual();
        Assert.That(turnoFinal, Is.Not.EqualTo(turnoInicial));
    }

    /// <summary>
    /// Válida que el Pokémon dormido no pueda atacar.
    /// Este test hace que cuando un Pokémon está dormido, no puede realizar un ataque.
    /// </summary>
    [Test]
    public void VerificarEstado_Dormido_NoAtacar()
    {
        var entrenador1 = new Entrenador("Juan");
        var pokemon = new Pokemon("Charmander", new Tipos("Fuego"), 100);
        entrenador1.AgregarPokemonAlEquipo(pokemon);
        var batalla = new Batalla(entrenador1, new Entrenador("Mateo"));

        pokemon.EstaDormido = true;  // Marcamos al Pokémon como dormido

        // Simulamos que no puede atacar (probabilidad de no atacar si el valor aleatorio es >= 4)
        var resultado = batalla.VerificarEstado(pokemon);

        Assert.That(resultado, Contains.Substring("Charmander se ha despertado y ha realizado su ataque"));
    }

    /// <summary>
    /// Válida que el Pokémon dormido pueda atacar.
    /// Este test hace que si el Pokémon dormido se despierta, pueda atacar.
    /// </summary>
    [Test]
    public void VerificarEstado_Dormido_Atacar()
    {
        var entrenador1 = new Entrenador("Juan");
        var pokemon = new Pokemon("Charmander", new Tipos("Fuego"), 100);
        entrenador1.AgregarPokemonAlEquipo(pokemon);
        var batalla = new Batalla(entrenador1, new Entrenador("Mateo"));

        pokemon.EstaDormido = true;  // Marcamos al Pokémon como dormido

        // Simulamos que puede atacar (probabilidad de poder atacar si el valor aleatorio es < 4)
        var resultado = batalla.VerificarEstado(pokemon);

        Assert.That(resultado, Contains.Substring("se ha despertado y ha realizado su ataque"));
    }

    /// <summary>
    /// Válida que el Pokémon paralizado no pueda atacar.
    /// Este test hace que cuando un Pokémon está paralizado, no puede realizar un ataque.
    /// </summary>
    [Test]
    public void VerificarEstado_Paralizado_NoAtacar()
    {
        var entrenador1 = new Entrenador("Juan");
        var pokemon = new Pokemon("Pikachu", new Tipos("Electrico"), 100);
        entrenador1.AgregarPokemonAlEquipo(pokemon);
        var batalla = new Batalla(entrenador1, new Entrenador("Mateo"));

        pokemon.EstaParalizado = true;  // Marcamos al Pokémon como paralizado

        // Simulamos que no puede atacar (probabilidad de no atacar si el valor aleatorio es >= 4)
        var resultado = batalla.VerificarEstado(pokemon);

        Assert.That(resultado, Does.Contain("Pikachu se ha librado de la paralisis y ha realizado su ataque"));
    }

    /// <summary>
    /// Válida que el Pokémon paralizado pueda atacar.
    /// Este test hace que si el Pokémon paralizado se libera, pueda atacar .
    /// </summary>
    [Test]
    public void VerificarEstado_Paralizado_Atacar()
    {
        var entrenador1 = new Entrenador("Juan");
        var pokemon = new Pokemon("Pikachu", new Tipos("Electrico"), 100);
        entrenador1.AgregarPokemonAlEquipo(pokemon);
        var batalla = new Batalla(entrenador1, new Entrenador("Mateo"));

        pokemon.EstaParalizado = true;  // Marcamos al Pokémon como paralizado

        // Simulamos que puede atacar (probabilidad de poder atacar si el valor aleatorio es < 4)
        var resultado = batalla.VerificarEstado(pokemon);

        Assert.That(resultado, Contains.Substring("Pikachu se ha librado de la paralisis y ha realizado su ataque"));
    }
    
    
}
*/