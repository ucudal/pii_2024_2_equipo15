namespace LibraryTests;
using NUnit.Framework;
using program;

public class EfectosTest
{
    [Test]
    public void CrearEfecto()
    {
        var efecto = new Efectos("Paralizar");
        Assert.That(efecto.Nombre, Is.EqualTo("Paralizar"));
    }
}