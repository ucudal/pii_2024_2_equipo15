/*namespace LibraryTests;
using NUnit.Framework;
using program;

public class AtaquesTest
{
    [Test]
    public void CrearAtaqueConPoder()
    {
        var tipoFuego = new Tipos("Fuego", new Dictionary<string, double>());
        var efectoQuemar = new Efectos("Quemar");

        var ataque = new Ataques("Lanzallamas", 90, tipoFuego, false);
        ataque.Poder = 120;
        ataque.Efectos = efectoQuemar;

        Assert.That(ataque.Nombre, Is.EqualTo("Lanzallamas"));
        Assert.That(ataque.Poder, Is.EqualTo(120));
        Assert.That(ataque.Efectos.Nombre, Is.EqualTo("Quemar"));
    }
}*/