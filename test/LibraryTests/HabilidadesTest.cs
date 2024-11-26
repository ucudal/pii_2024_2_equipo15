namespace LibraryTests;

using NUnit.Framework;
using program;


public class HabilidadesTest
{
    [Test]
    public void CrearHabilidad()
    {
        var tipoFuego = new Tipos("Fuego", new Dictionary<string, double>());
        var efectoQuemar = new Efectos("Quemar");
        var habilidad = new Habilidades("Lanzallamas", tipoFuego, 90, 85, 15, false, efectoQuemar, 120);

        Assert.That(habilidad.Nombre, Is.EqualTo("Lanzallamas"));
        Assert.That(habilidad.Tipo, Is.EqualTo(tipoFuego));
        Assert.That(habilidad.Danio, Is.EqualTo(90));
        Assert.That(habilidad.Precision, Is.EqualTo(85));
        Assert.That(habilidad.Puntos_de_Poder, Is.EqualTo(15));
        Assert.That(habilidad.EsDobleTurno, Is.False);
        Assert.That(habilidad.Poder, Is.EqualTo(120));
        Assert.That(habilidad.Efectos.Nombre, Is.EqualTo("Quemar"));
    }
}
