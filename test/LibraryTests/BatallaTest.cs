using NUnit.Framework;
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
    /// Válida que un entrenador pueda usar un ítem durante su turno.
    /// Comprueba que el mensaje devuelto por el método <see cref="Batalla.UsarItem"/> sea correcto.
    /// </summary>
    [Test]
    public void UsarItem()
    {
        var entrenador1 = new Entrenador("Juan");
        var entrenador2 = new Entrenador("Mateo");
        var batalla = new Batalla(entrenador1, entrenador2);

        var resultado = batalla.UsarItem(entrenador1, "SuperPocion");

        Assert.That(resultado, Contains.Substring("Uso un item y pierde el turno"));
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

        // Se debilitan todos los Pokémon del entrenador1
        foreach (var pokemon in entrenador1.Equipo)
        {
            pokemon.Salud = 0;
        }

        var ganador = batalla.ConocerGanador();

        Assert.That(ganador, Contains.Substring("El equipo de Mateo es el ganador"));
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

        // Se debilita un Pokémon del entrenador1
        entrenador1.Equipo[0].Salud = 0;

        var resultado = batalla.PokemonDebilitado();

        Assert.That(resultado, Contains.Substring("no puede continuar peleando"));
    }
}
