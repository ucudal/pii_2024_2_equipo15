/*namespace LibraryTests;
using NUnit.Framework;
using program;

public class AtaquesTest
{
    [Test]
    public void AtaqueEspecialConEfecto()
    {
        var efectoQuemar = new Efectos("Quemar");

        var ataque = new Ataques("PulsoUmbrio", 120, true, efectoQuemar);

        Assert.That(ataque.Nombre, Is.EqualTo("PulsoUmbrio"));
        Assert.That(ataque.Danio, Is.EqualTo(120));
        Assert.That(ataque.EsEspecial, Is.True);
        Assert.That(ataque.Efectos.Nombre, Is.EqualTo("Quemar"));
    }
    
    [Test]
    public void AtaqueSinEfectos()
    {
        var ataque = new Ataques("Trueno", 110, false);

        Assert.That(ataque.Nombre, Is.EqualTo("Trueno"));
        Assert.That(ataque.EsEspecial, Is.False);
        Assert.That(ataque.Efectos, Is.Null);
    }
}

