/*using NUnit.Framework;
namespace LibraryTests;
using Library;

public class AtaquesTest
{
    /// <summary>
    /// Verifica que los ataques se inicialicen correctamente y que sus propiedades sean válidas.
    /// </summary>
    [Test]
    public void Ataques()
    {
        // Creamos un ataque de tipo Fuego
        var tipo_fuego = new Tipos("Fuego");
        var ataqueLanzallama = new Ataques("Lanzallamas", 90, tipo_fuego, true);

        // Creamos un ataque de tipo Volador
        var tipo_volador = new Tipos("Volador");
        var ataqueAcero = new Ataques("AlaDeAcero", 70, tipo_volador, false);

        // Creamos un ataque de tipo Veneno
        var tipo_veneno = new Tipos("Veneno");
        var ataqueMugre = new Ataques("LanzaMugre", 65, tipo_veneno, false);

        // Creamos de un ataque de tipo Psíquico
        var tipo_psiquico = new Tipos("Psiquico");
        var ataqueConfusion = new Ataques("Confusion", 50, tipo_psiquico, true);

        // Validacion del ataque de tipo Fuego
        Assert.That(ataqueLanzallama.Nombre, Is.EqualTo("Lanzallamas"));
        Assert.That(ataqueLanzallama.Daño, Is.EqualTo(90));
        Assert.That(ataqueLanzallama.Tipo.NombreTipo, Is.EqualTo("Fuego"));
        Assert.That(ataqueLanzallama.EsEspecial, Is.True);

        // Validacion del ataque de tipo Volador
        Assert.That(ataqueAcero.Nombre, Is.EqualTo("AlaDeAcero"));
        Assert.That(ataqueAcero.Daño, Is.EqualTo(70));
        Assert.That(ataqueAcero.Tipo.NombreTipo, Is.EqualTo("Volador"));
        Assert.That(ataqueAcero.EsEspecial, Is.False);

        // Validacion del ataque de tipo Veneno
        Assert.That(ataqueMugre.Nombre, Is.EqualTo("LanzaMugre"));
        Assert.That(ataqueMugre.Daño, Is.EqualTo(65));
        Assert.That(ataqueMugre.Tipo.NombreTipo, Is.EqualTo("Veneno"));
        Assert.That(ataqueMugre.EsEspecial, Is.False);

        // Validacion del ataque de tipo Psíquico
        Assert.That(ataqueConfusion.Nombre, Is.EqualTo("Confusion"));
        Assert.That(ataqueConfusion.Daño, Is.EqualTo(50));
        Assert.That(ataqueConfusion.Tipo.NombreTipo, Is.EqualTo("Psiquico"));
        Assert.That(ataqueConfusion.EsEspecial, Is.True);
    }
}
*/