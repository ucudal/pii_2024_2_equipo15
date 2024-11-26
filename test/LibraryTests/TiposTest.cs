using NUnit.Framework;
namespace LibraryTests;
using program;

public class TiposTest
{
    [Test]
    public void CrearTipo()
    {
        var ventajas = new Dictionary<string, double>
        {
            { "Agua", 2.0 },
            { "Fuego", 0.5 }
        };

        var tipo = new Tipos("Electrico", ventajas);

        Assert.That(tipo.Nombre, Is.EqualTo("Electrico"));
    }

    [Test]
    public void EsEfectivoOPocoEfectivo()
    {
        var ventajas = new Dictionary<string, double>
        {
            { "Agua", 2.0 },
            { "Fuego", 0.5 }
        };

        var tipo = new Tipos("Electrico", ventajas);
        var tipoAgua = new Tipos("Agua", new Dictionary<string, double>());

        Assert.That(tipo.EsEfectivoOPocoEfectivo(tipoAgua), Is.EqualTo(2.0));
        Assert.That(tipo.EsEfectivoOPocoEfectivo(new Tipos("Roca", new Dictionary<string, double>())), Is.EqualTo(1.0));
    }
}
