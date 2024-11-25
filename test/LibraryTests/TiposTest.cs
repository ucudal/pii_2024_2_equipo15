using NUnit.Framework;
namespace LibraryTests;
using Library;

public class TiposTest
{
    /// <summary>
    /// Válida que un objeto <see cref="Tipos"/> se inicialice correctamente.
    /// Comprueba que el nombre del tipo corresponda al valor esperado.
    /// </summary>
    [Test]
    public void Tipos()
    { 
        var tipo_agua = new Tipos("Agua");
        Assert.That(tipo_agua.NombreTipo, Is.EqualTo("Agua"));
    }

    /// <summary>
    /// Válida que el método <see cref="Tipos.efectividadDeDaño"/> devuelva correctamente
    /// la efectividad entre un tipo atacante y un tipo objetivo.
    /// En este caso, Agua es muy efectivo contra Fuego.
    /// </summary>
    [Test]
    public void EfectividadDaño()
    {
        var tipo_agua = new Tipos("Agua");
        var tipo_fuego = new Tipos("Fuego");
        double efectividad = tipo_agua.EfectividadDeDaño(tipo_fuego);

        Assert.That(efectividad, Is.EqualTo(2));
    }

    /// <summary>
    /// Válida que el daño sea poco efectivo entre tipos.
    /// En este caso, Agua es poco efectivo contra Planta.
    /// </summary>
    [Test]
    public void DañoPocoEfectivo()
    {
        var tipo_agua = new Tipos("Agua");
        var tipo_planta = new Tipos("Planta");
        double efectividad = tipo_agua.EfectividadDeDaño(tipo_planta);

        Assert.That(efectividad, Is.EqualTo(0.5));
    }

    /// <summary>
    /// Válida que el daño sea neutral entre tipos.
    /// En este caso, Agua contra Normal no tiene ventajas ni desventajas.
    /// </summary>
    [Test]
    public void DañoNeutral()
    {
        var tipo_agua = new Tipos("Agua");
        var tipo_normal = new Tipos("Normal");
        double efectividad = tipo_agua.EfectividadDeDaño(tipo_normal);

        Assert.That(efectividad, Is.EqualTo(1));
    }

    /// <summary>
    /// Válida que un tipo sea inmune al daño de otro.
    /// En este caso, Fantasma es inmune a Normal.
    /// </summary>
    [Test]
    public void DañoInmune()
    {
        var tipo_fantasma = new Tipos("Fantasma");
        var tipo_normal = new Tipos("Normal");
        double efectividad = tipo_fantasma.EfectividadDeDaño(tipo_normal);

        Assert.That(efectividad, Is.EqualTo(0));
    }

    /// <summary>
    /// Válida que los ataques de un tipo contra sí mismo sean neutrales.
    /// En este caso, Fuego contra Fuego.
    /// </summary>
    [Test]
    public void DañoMismoTipo()
    {
        var tipoFantasma = new Tipos("Fantasma");
        double efectividad = tipoFantasma.EfectividadDeDaño(tipoFantasma);

        Assert.That(efectividad, Is.EqualTo(2));
    }
}
