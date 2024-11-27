using NUnit.Framework;
using program;

namespace LibraryTests;

[TestFixture]
public class RestriccionesTest
{
    private Restricciones restricciones;
    
    [SetUp]
    public void SetUp()
    {
        restricciones = new Restricciones();
    }

    [Test]
    public void RestringirItems_AgregaItemsALista()
    {
        string resultado = restricciones.RestringirItems("Súper poción");
        Assert.That(resultado, Does.Contain("Súper poción"));
    }
    [Test]
    public void RestringirTipos_AgregaTiposALista()
    {
        string resultado = restricciones.RestringirItems("Fuego");
        Assert.That(resultado, Does.Contain("Fuego"));
    }
    [Test]
    public void RestringirPokemon_AgregaPokemonALista()
    {
        string resultado = restricciones.RestringirItems("Pikachu");
        Assert.That(resultado, Does.Contain("Pikachu"));
    }

    [Test]
    public void AceptarRestricciones_DecisionSi()
    {
        Restricciones.AceptarRestricciones("si");
        Assert.That(Restricciones.AceptacionRestriccion, Is.EqualTo(true));
    }

    [Test]
    public void AceptarRestricciones_DecisionNo()
    {
        Restricciones.AceptarRestricciones("no");
        Assert.That(Restricciones.AceptacionRestriccion, Is.EqualTo(false));
    }

}


