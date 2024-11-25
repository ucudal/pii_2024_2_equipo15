using NUnit.Framework;
namespace LibraryTests;
using Library;

public class TiposTest
{
    // ----------------------------Bicho----------------------------------------//
    
    /// <summary>
    /// Válida que el tipo Bicho sea muy efectivo contra Planta.
    /// </summary>
    [Test] 
    public void EfectividadBichoVsPlanta() 
    { 
        var tipo_bicho = new Tipos("Bicho"); 
        var tipo_planta = new Tipos("Planta"); 
        Assert.That(tipo_bicho.EfectividadDeDaño(tipo_planta), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Bicho sea muy efectivo contra Psíquico.
    /// </summary>
    [Test] 
    public void EfectividadBichoVsPsiquico() 
    { 
        var tipo_bicho = new Tipos("Bicho"); 
        var tipo_psiquico = new Tipos("Psíquico"); 
        Assert.That(tipo_bicho.EfectividadDeDaño(tipo_psiquico), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Bicho sea muy efectivo contra Lucha.
    /// </summary>
    [Test] 
    public void EfectividadBichoVsLucha() 
    { 
        var tipo_bicho = new Tipos("Bicho"); 
        var tipo_lucha = new Tipos("Lucha"); 
        Assert.That(tipo_bicho.EfectividadDeDaño(tipo_lucha), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Bicho sea muy efectivo contra Veneno.
    /// </summary>
    [Test] 
    public void EfectividadBichoVsVeneno() 
    { 
        var tipo_bicho = new Tipos("Bicho"); 
        var tipo_veneno = new Tipos("Veneno"); 
        Assert.That(tipo_bicho.EfectividadDeDaño(tipo_veneno), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Bicho sea poco efectivo contra Fuego.
    /// </summary>
    [Test] 
    public void EfectividadBichoVsFuego() 
    { 
        var tipo_bicho = new Tipos("Bicho"); 
        var tipo_fuego = new Tipos("Fuego"); 
        Assert.That(tipo_bicho.EfectividadDeDaño(tipo_fuego), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Bicho sea poco efectivo contra Volador.
    /// </summary>
    [Test] 
    public void EfectividadBichoVsVolador() 
    { 
        var tipo_bicho = new Tipos("Bicho"); 
        var tipo_volador = new Tipos("Volador"); 
        Assert.That(tipo_bicho.EfectividadDeDaño(tipo_volador), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Bicho tenga efectividad neutral contra Eléctrico.
    /// </summary>
    [Test] 
    public void EfectividadBichoVsElectrico() 
    { 
        var tipo_bicho = new Tipos("Bicho"); 
        var tipo_electrico = new Tipos("Eléctrico"); 
        Assert.That(tipo_bicho.EfectividadDeDaño(tipo_electrico), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Bicho tenga efectividad neutral contra Fantasma.
    /// </summary>
    [Test] 
    public void EfectividadBichoVsFantasma() 
    { 
        var tipo_bicho = new Tipos("Bicho"); 
        var tipo_fantasma = new Tipos("Fantasma"); 
        Assert.That(tipo_bicho.EfectividadDeDaño(tipo_fantasma), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Bicho tenga efectividad neutral contra Normal.
    /// </summary>
    [Test] 
    public void EfectividadBichoVsNormal() 
    { 
        var tipo_bicho = new Tipos("Bicho"); 
        var tipo_normal = new Tipos("Normal"); 
        Assert.That(tipo_bicho.EfectividadDeDaño(tipo_normal), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Bicho tenga efectividad neutral contra Tierra.
    /// </summary>
    [Test] 
    public void EfectividadBichoVsTierra() 
    { 
        var tipo_bicho = new Tipos("Bicho"); 
        var tipo_tierra = new Tipos("Tierra"); 
        Assert.That(tipo_bicho.EfectividadDeDaño(tipo_tierra), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Bicho tenga efectividad neutral contra Roca.
    /// </summary>
    [Test] 
    public void EfectividadBichoVsRoca() 
    { 
        var tipo_bicho = new Tipos("Bicho"); 
        var tipo_roca = new Tipos("Roca"); 
        Assert.That(tipo_bicho.EfectividadDeDaño(tipo_roca), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Bicho tenga efectividad neutral contra Agua.
    /// </summary>
    [Test] 
    public void EfectividadBichoVsAgua() 
    { 
        var tipo_bicho = new Tipos("Bicho"); 
        var tipo_agua = new Tipos("Agua"); 
        Assert.That(tipo_bicho.EfectividadDeDaño(tipo_agua), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Bicho tenga efectividad neutral contra Dragón.
    /// </summary>
    [Test] 
    public void EfectividadBichoVsDragon() 
    { 
        var tipo_bicho = new Tipos("Bicho"); 
        var tipo_dragon = new Tipos("Dragón"); 
        Assert.That(tipo_bicho.EfectividadDeDaño(tipo_dragon), Is.EqualTo(1)); 
    }
    
    // ----------------------------Agua----------------------------------------//
    
    /// <summary>
    /// Válida que el tipo Agua sea muy efectivo contra Fuego.
    /// </summary>
    [Test] 
    public void EfectividadAguaVsFuego() 
    { 
        var tipo_agua = new Tipos("Agua"); 
        var tipo_fuego = new Tipos("Fuego"); 
        Assert.That(tipo_agua.EfectividadDeDaño(tipo_fuego), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Agua sea muy efectivo contra Tierra.
    /// </summary>
    [Test] 
    public void EfectividadAguaVsTierra() 
    { 
        var tipo_agua = new Tipos("Agua"); 
        var tipo_tierra = new Tipos("Tierra"); 
        Assert.That(tipo_agua.EfectividadDeDaño(tipo_tierra), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Agua sea muy efectivo contra Roca.
    /// </summary>
    [Test] 
    public void EfectividadAguaVsRoca() 
    { 
        var tipo_agua = new Tipos("Agua"); 
        var tipo_roca = new Tipos("Roca"); 
        Assert.That(tipo_agua.EfectividadDeDaño(tipo_roca), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Agua sea poco efectivo contra Agua.
    /// </summary>
    [Test] 
    public void EfectividadAguaVsAgua() 
    { 
        var tipo_agua = new Tipos("Agua"); 
        var tipo_agua2 = new Tipos("Agua"); 
        Assert.That(tipo_agua.EfectividadDeDaño(tipo_agua2), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Agua sea poco efectivo contra Dragón.
    /// </summary>
    [Test] 
    public void EfectividadAguaVsDragon() 
    { 
        var tipo_agua = new Tipos("Agua"); 
        var tipo_dragon = new Tipos("Dragón"); 
        Assert.That(tipo_agua.EfectividadDeDaño(tipo_dragon), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Agua sea poco efectivo contra Planta.
    /// </summary>
    [Test] 
    public void EfectividadAguaVsPlanta() 
    { 
        var tipo_agua = new Tipos("Agua"); 
        var tipo_planta = new Tipos("Planta"); 
        Assert.That(tipo_agua.EfectividadDeDaño(tipo_planta), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Agua tenga efectividad neutral contra Bicho.
    /// </summary>
    [Test] 
    public void EfectividadAguaVsBicho() 
    { 
        var tipo_agua = new Tipos("Agua"); 
        var tipo_bicho = new Tipos("Bicho"); 
        Assert.That(tipo_agua.EfectividadDeDaño(tipo_bicho), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Agua tenga efectividad neutral contra Psíquico.
    /// </summary>
    [Test] 
    public void EfectividadAguaVsPsiquico() 
    { 
        var tipo_agua = new Tipos("Agua"); 
        var tipo_psiquico = new Tipos("Psíquico"); 
        Assert.That(tipo_agua.EfectividadDeDaño(tipo_psiquico), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Agua tenga efectividad neutral contra Lucha.
    /// </summary>
    [Test] 
    public void EfectividadAguaVsLucha() 
    { 
        var tipo_agua = new Tipos("Agua"); 
        var tipo_lucha = new Tipos("Lucha"); 
        Assert.That(tipo_agua.EfectividadDeDaño(tipo_lucha), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Agua tenga efectividad neutral contra Eléctrico.
    /// </summary>
    [Test] 
    public void EfectividadAguaVsElectrico() 
    { 
        var tipo_agua = new Tipos("Agua"); 
        var tipo_electrico = new Tipos("Eléctrico"); 
        Assert.That(tipo_agua.EfectividadDeDaño(tipo_electrico), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Agua tenga efectividad neutral contra Fantasma.
    /// </summary>
    [Test] 
    public void EfectividadAguaVsFantasma() 
    { 
        var tipo_agua = new Tipos("Agua"); 
        var tipo_fantasma = new Tipos("Fantasma"); 
        Assert.That(tipo_agua.EfectividadDeDaño(tipo_fantasma), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Agua tenga efectividad neutral contra Normal.
    /// </summary>
    [Test] 
    public void EfectividadAguaVsNormal() 
    { 
        var tipo_agua = new Tipos("Agua"); 
        var tipo_normal = new Tipos("Normal"); 
        Assert.That(tipo_agua.EfectividadDeDaño(tipo_normal), Is.EqualTo(1)); 
    }
    
     // ----------------------------Dragón----------------------------------------//
    
    /// <summary>
    /// Válida que el tipo Dragón sea muy efectivo contra Dragón.
    /// </summary>
    [Test]
    public void EfectividadDragonVsDragon() 
    { 
        var tipo_dragón = new Tipos("Dragón"); 
        var otro_dragón = new Tipos("Dragón"); 
        Assert.That(tipo_dragón.EfectividadDeDaño(otro_dragón), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Dragón tenga efectividad neutral contra Agua.
    /// </summary>
    [Test]
    public void EfectividadDragonVsAgua() 
    { 
        var tipo_dragón = new Tipos("Dragón"); 
        var tipo_agua = new Tipos("Agua"); 
        Assert.That(tipo_dragón.EfectividadDeDaño(tipo_agua), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Dragón tenga efectividad neutral contra Fuego.
    /// </summary>
    [Test]
    public void EfectividadDragonVsFuego() 
    { 
        var tipo_dragón = new Tipos("Dragón"); 
        var tipo_fuego = new Tipos("Fuego"); 
        Assert.That(tipo_dragón.EfectividadDeDaño(tipo_fuego), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Dragón tenga efectividad neutral contra Tierra.
    /// </summary>
    [Test]
    public void EfectividadDragonVsTierra() 
    { 
        var tipo_dragón = new Tipos("Dragón"); 
        var tipo_tierra = new Tipos("Tierra"); 
        Assert.That(tipo_dragón.EfectividadDeDaño(tipo_tierra), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Dragón tenga efectividad neutral contra Roca.
    /// </summary>
    [Test]
    public void EfectividadDragonVsRoca() 
    { 
        var tipo_dragón = new Tipos("Dragón"); 
        var tipo_roca = new Tipos("Roca"); 
        Assert.That(tipo_dragón.EfectividadDeDaño(tipo_roca), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Dragón sea poco neutral contra Eléctrico.
    /// </summary>
    [Test]
    public void EfectividadDragonVsElectrico() 
    { 
        var tipo_dragón = new Tipos("Dragón"); 
        var tipo_electrico = new Tipos("Eléctrico"); 
        Assert.That(tipo_dragón.EfectividadDeDaño(tipo_electrico), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Dragón tenga efectividad neutral contra Bicho.
    /// </summary>
    [Test]
    public void EfectividadDragonVsBicho() 
    { 
        var tipo_dragón = new Tipos("Dragón"); 
        var tipo_bicho = new Tipos("Bicho"); 
        Assert.That(tipo_dragón.EfectividadDeDaño(tipo_bicho), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Dragón tenga efectividad neutral contra Psíquico.
    /// </summary>
    [Test]
    public void EfectividadDragonVsPsiquico() 
    { 
        var tipo_dragón = new Tipos("Dragón"); 
        var tipo_psiquico = new Tipos("Psíquico"); 
        Assert.That(tipo_dragón.EfectividadDeDaño(tipo_psiquico), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Dragón tenga efectividad neutral contra Lucha.
    /// </summary>
    [Test]
    public void EfectividadDragonVsLucha() 
    { 
        var tipo_dragón = new Tipos("Dragón"); 
        var tipo_lucha = new Tipos("Lucha"); 
        Assert.That(tipo_dragón.EfectividadDeDaño(tipo_lucha), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Dragón tenga efectividad neutral contra Fantasma.
    /// </summary>
    [Test]
    public void EfectividadDragonVsFantasma() 
    { 
        var tipo_dragón = new Tipos("Dragón"); 
        var tipo_fantasma = new Tipos("Fantasma"); 
        Assert.That(tipo_dragón.EfectividadDeDaño(tipo_fantasma), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Dragón tenga efectividad neutral contra Normal.
    /// </summary>
    [Test]
    public void EfectividadDragonVsNormal() 
    { 
        var tipo_dragón = new Tipos("Dragón"); 
        var tipo_normal = new Tipos("Normal"); 
        Assert.That(tipo_dragón.EfectividadDeDaño(tipo_normal), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Dragón tenga efectividad neutral contra Veneno.
    /// </summary>
    [Test]
    public void EfectividadDragonVsVeneno() 
    { 
        var tipo_dragón = new Tipos("Dragón"); 
        var tipo_veneno = new Tipos("Veneno"); 
        Assert.That(tipo_dragón.EfectividadDeDaño(tipo_veneno), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Dragón tenga efectividad neutral contra Volador.
    /// </summary>
    [Test]
    public void EfectividadDragonVsVolador() 
    { 
        var tipo_dragón = new Tipos("Dragón"); 
        var tipo_volador = new Tipos("Volador"); 
        Assert.That(tipo_dragón.EfectividadDeDaño(tipo_volador), Is.EqualTo(1)); 
    }
    
       // ----------------------------Eléctrico----------------------------------------//
    
    /// <summary>
    /// Válida que el tipo Eléctrico sea muy efectivo contra Volador.
    /// </summary>
    [Test]
    public void EfectividadElectricoVsVolador() 
    { 
        var tipo_electrico = new Tipos("Eléctrico"); 
        var tipo_volador = new Tipos("Volador"); 
        Assert.That(tipo_electrico.EfectividadDeDaño(tipo_volador), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Eléctrico sea muy efectivo contra Agua.
    /// </summary>
    [Test]
    public void EfectividadElectricoVsAgua() 
    { 
        var tipo_electrico = new Tipos("Eléctrico"); 
        var tipo_agua = new Tipos("Agua"); 
        Assert.That(tipo_electrico.EfectividadDeDaño(tipo_agua), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Eléctrico tenga efectividad poco efectiva contra Dragón.
    /// </summary>
    [Test]
    public void EfectividadElectricoVsDragon() 
    { 
        var tipo_electrico = new Tipos("Eléctrico"); 
        var tipo_dragon = new Tipos("Dragón"); 
        Assert.That(tipo_electrico.EfectividadDeDaño(tipo_dragon), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Eléctrico tenga efectividad poco efectiva contra Tierra.
    /// </summary>
    [Test]
    public void EfectividadElectricoVsTierra() 
    { 
        var tipo_electrico = new Tipos("Eléctrico"); 
        var tipo_tierra = new Tipos("Tierra"); 
        Assert.That(tipo_electrico.EfectividadDeDaño(tipo_tierra), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Eléctrico tenga efectividad poco efectiva contra Planta.
    /// </summary>
    [Test]
    public void EfectividadElectricoVsPlanta() 
    { 
        var tipo_electrico = new Tipos("Eléctrico"); 
        var tipo_planta = new Tipos("Planta"); 
        Assert.That(tipo_electrico.EfectividadDeDaño(tipo_planta), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Eléctrico tenga efectividad neutral contra Fuego.
    /// </summary>
    [Test]
    public void EfectividadElectricoVsFuego() 
    { 
        var tipo_electrico = new Tipos("Eléctrico"); 
        var tipo_fuego = new Tipos("Fuego"); 
        Assert.That(tipo_electrico.EfectividadDeDaño(tipo_fuego), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Eléctrico tenga efectividad neutral contra Agua.
    /// </summary>
    [Test]
    public void EfectividadElectricoVsNormal() 
    { 
        var tipo_electrico = new Tipos("Eléctrico"); 
        var tipo_normal = new Tipos("Normal"); 
        Assert.That(tipo_electrico.EfectividadDeDaño(tipo_normal), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Eléctrico sea inmune a Eléctrico.
    /// </summary>
    [Test]
    public void EfectividadElectricoVsElectrico() 
    { 
        var tipo_electrico = new Tipos("Eléctrico"); 
        var otro_tipo_electrico = new Tipos("Eléctrico"); 
        Assert.That(tipo_electrico.EfectividadDeDaño(otro_tipo_electrico), Is.EqualTo(0)); 
    }

    /// <summary>
    /// Válida que el tipo Eléctrico tenga efectividad neutral contra Roca.
    /// </summary>
    [Test]
    public void EfectividadElectricoVsRoca() 
    { 
        var tipo_electrico = new Tipos("Eléctrico"); 
        var tipo_roca = new Tipos("Roca"); 
        Assert.That(tipo_electrico.EfectividadDeDaño(tipo_roca), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Eléctrico tenga efectividad neutral contra Psíquico.
    /// </summary>
    [Test]
    public void EfectividadElectricoVsPsiquico() 
    { 
        var tipo_electrico = new Tipos("Eléctrico"); 
        var tipo_psiquico = new Tipos("Psíquico"); 
        Assert.That(tipo_electrico.EfectividadDeDaño(tipo_psiquico), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Eléctrico tenga efectividad neutral contra Lucha.
    /// </summary>
    [Test]
    public void EfectividadElectricoVsLucha() 
    { 
        var tipo_electrico = new Tipos("Eléctrico"); 
        var tipo_lucha = new Tipos("Lucha"); 
        Assert.That(tipo_electrico.EfectividadDeDaño(tipo_lucha), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Eléctrico tenga efectividad neutral contra Fantasma.
    /// </summary>
    [Test]
    public void EfectividadElectricoVsFantasma() 
    { 
        var tipo_electrico = new Tipos("Eléctrico"); 
        var tipo_fantasma = new Tipos("Fantasma"); 
        Assert.That(tipo_electrico.EfectividadDeDaño(tipo_fantasma), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Eléctrico tenga efectividad neutral contra Veneno.
    /// </summary>
    [Test]
    public void EfectividadElectricoVsVeneno() 
    { 
        var tipo_electrico = new Tipos("Eléctrico"); 
        var tipo_veneno = new Tipos("Veneno"); 
        Assert.That(tipo_electrico.EfectividadDeDaño(tipo_veneno), Is.EqualTo(1)); 
    }
    
     // ----------------------------Fantasma----------------------------------------//
    
    
    /// <summary>
    /// Válida que el tipo Fantasma sea muy efectivo contra Psíquico.
    /// </summary>
    [Test]
    public void EfectividadFantasmaVsPsiquico() 
    { 
        var tipo_fantasma = new Tipos("Fantasma"); 
        var tipo_psiquico = new Tipos("Psíquico"); 
        Assert.That(tipo_fantasma.EfectividadDeDaño(tipo_psiquico), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Fantasma sea inmune a Normal.
    /// </summary>
    [Test]
    public void EfectividadFantasmaVsNormal() 
    { 
        var tipo_fantasma = new Tipos("Fantasma"); 
        var tipo_normal = new Tipos("Normal"); 
        Assert.That(tipo_fantasma.EfectividadDeDaño(tipo_normal), Is.EqualTo(0)); 
    }

    /// <summary>
    /// Válida que el tipo Fantasma tenga efectividad neutral contra Fuego.
    /// </summary>
    [Test]
    public void EfectividadFantasmaVsFuego() 
    { 
        var tipo_fantasma = new Tipos("Fantasma"); 
        var tipo_fuego = new Tipos("Fuego"); 
        Assert.That(tipo_fantasma.EfectividadDeDaño(tipo_fuego), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Fantasma tenga efectividad neutral contra Agua.
    /// </summary>
    [Test]
    public void EfectividadFantasmaVsAgua() 
    { 
        var tipo_fantasma = new Tipos("Fantasma"); 
        var tipo_agua = new Tipos("Agua"); 
        Assert.That(tipo_fantasma.EfectividadDeDaño(tipo_agua), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Fantasma tenga efectividad neutral contra Dragón.
    /// </summary>
    [Test]
    public void EfectividadFantasmaVsDragon() 
    { 
        var tipo_fantasma = new Tipos("Fantasma"); 
        var tipo_dragon = new Tipos("Dragón"); 
        Assert.That(tipo_fantasma.EfectividadDeDaño(tipo_dragon), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Fantasma tenga efectividad neutral contra Tierra.
    /// </summary>
    [Test]
    public void EfectividadFantasmaVsTierra() 
    { 
        var tipo_fantasma = new Tipos("Fantasma"); 
        var tipo_tierra = new Tipos("Tierra"); 
        Assert.That(tipo_fantasma.EfectividadDeDaño(tipo_tierra), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Fantasma tenga efectividad neutral contra Planta.
    /// </summary>
    [Test]
    public void EfectividadFantasmaVsPlanta() 
    { 
        var tipo_fantasma = new Tipos("Fantasma"); 
        var tipo_planta = new Tipos("Planta"); 
        Assert.That(tipo_fantasma.EfectividadDeDaño(tipo_planta), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Fantasma tenga efectividad neutral contra Lucha.
    /// </summary>
    [Test]
    public void EfectividadFantasmaVsLucha() 
    { 
        var tipo_fantasma = new Tipos("Fantasma"); 
        var tipo_lucha = new Tipos("Lucha"); 
        Assert.That(tipo_fantasma.EfectividadDeDaño(tipo_lucha), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Fantasma tenga efectividad neutral contra Veneno.
    /// </summary>
    [Test]
    public void EfectividadFantasmaVsVeneno() 
    { 
        var tipo_fantasma = new Tipos("Fantasma"); 
        var tipo_veneno = new Tipos("Veneno"); 
        Assert.That(tipo_fantasma.EfectividadDeDaño(tipo_veneno), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Fantasma tenga efectividad alta contra Fantasma.
    /// </summary>
    [Test]
    public void EfectividadFantasmaVsFantasma() 
    { 
        var tipo_fantasma = new Tipos("Fantasma"); 
        var otro_tipo_fantasma = new Tipos("Fantasma"); 
        Assert.That(tipo_fantasma.EfectividadDeDaño(otro_tipo_fantasma), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Fantasma tenga efectividad neutral contra Roca.
    /// </summary>
    [Test]
    public void EfectividadFantasmaVsRoca() 
    { 
        var tipo_fantasma = new Tipos("Fantasma"); 
        var tipo_roca = new Tipos("Roca"); 
        Assert.That(tipo_fantasma.EfectividadDeDaño(tipo_roca), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Fantasma tenga efectividad neutral contra Volador.
    /// </summary>
    [Test]
    public void EfectividadFantasmaVsVolador() 
    { 
        var tipo_fantasma = new Tipos("Fantasma"); 
        var tipo_volador = new Tipos("Volador"); 
        Assert.That(tipo_fantasma.EfectividadDeDaño(tipo_volador), Is.EqualTo(1)); 
    }
    
        // ----------------------------Fuego----------------------------------------//

    /// <summary>
    /// Válida que el tipo Fuego sea muy efectivo contra Bicho.
    /// </summary>
    [Test]
    public void EfectividadFuegoVsBicho() 
    { 
        var tipo_fuego = new Tipos("Fuego"); 
        var tipo_bicho = new Tipos("Bicho"); 
        Assert.That(tipo_fuego.EfectividadDeDaño(tipo_bicho), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Fuego sea muy efectivo contra Hielo.
    /// </summary>
    [Test]
    public void EfectividadFuegoVsHielo() 
    { 
        var tipo_fuego = new Tipos("Fuego"); 
        var tipo_hielo = new Tipos("Hielo"); 
        Assert.That(tipo_fuego.EfectividadDeDaño(tipo_hielo), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Fuego sea muy efectivo contra Planta.
    /// </summary>
    [Test]
    public void EfectividadFuegoVsPlanta() 
    { 
        var tipo_fuego = new Tipos("Fuego"); 
        var tipo_planta = new Tipos("Planta"); 
        Assert.That(tipo_fuego.EfectividadDeDaño(tipo_planta), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Fuego sea poco efectivo contra Agua.
    /// </summary>
    [Test]
    public void EfectividadFuegoVsAgua() 
    { 
        var tipo_fuego = new Tipos("Fuego"); 
        var tipo_agua = new Tipos("Agua"); 
        Assert.That(tipo_fuego.EfectividadDeDaño(tipo_agua), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Fuego sea poco efectivo contra Dragón.
    /// </summary>
    [Test]
    public void EfectividadFuegoVsDragon() 
    { 
        var tipo_fuego = new Tipos("Fuego"); 
        var tipo_dragon = new Tipos("Dragón"); 
        Assert.That(tipo_fuego.EfectividadDeDaño(tipo_dragon), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Fuego sea poco efectivo contra Fuego.
    /// </summary>
    [Test]
    public void EfectividadFuegoVsFuego() 
    { 
        var tipo_fuego = new Tipos("Fuego"); 
        var tipo_fuego2 = new Tipos("Fuego"); 
        Assert.That(tipo_fuego.EfectividadDeDaño(tipo_fuego2), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Fuego sea poco efectivo contra Roca.
    /// </summary>
    [Test]
    public void EfectividadFuegoVsRoca() 
    { 
        var tipo_fuego = new Tipos("Fuego"); 
        var tipo_roca = new Tipos("Roca"); 
        Assert.That(tipo_fuego.EfectividadDeDaño(tipo_roca), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Fuego tenga efectividad neutral contra Fantasma.
    /// </summary>
    [Test]
    public void EfectividadFuegoVsFantasma() 
    { 
        var tipo_fuego = new Tipos("Fuego"); 
        var tipo_fantasma = new Tipos("Fantasma"); 
        Assert.That(tipo_fuego.EfectividadDeDaño(tipo_fantasma), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Fuego tenga efectividad neutral contra Normal.
    /// </summary>
    [Test]
    public void EfectividadFuegoVsNormal() 
    { 
        var tipo_fuego = new Tipos("Fuego"); 
        var tipo_normal = new Tipos("Normal"); 
        Assert.That(tipo_fuego.EfectividadDeDaño(tipo_normal), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Fuego tenga efectividad neutral contra Veneno.
    /// </summary>
    [Test]
    public void EfectividadFuegoVsVeneno() 
    { 
        var tipo_fuego = new Tipos("Fuego"); 
        var tipo_veneno = new Tipos("Veneno"); 
        Assert.That(tipo_fuego.EfectividadDeDaño(tipo_veneno), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Fuego tenga efectividad neutral contra Tierra.
    /// </summary>
    [Test]
    public void EfectividadFuegoVsTierra() 
    { 
        var tipo_fuego = new Tipos("Fuego"); 
        var tipo_tierra = new Tipos("Tierra"); 
        Assert.That(tipo_fuego.EfectividadDeDaño(tipo_tierra), Is.EqualTo(1)); 
    }
    

    
        // ----------------------------Hielo----------------------------------------//

    /// <summary>
    /// Válida que el tipo Hielo sea muy efectivo contra Dragón.
    /// </summary>
    [Test]
    public void EfectividadHieloVsDragon() 
    { 
        var tipo_hielo = new Tipos("Hielo"); 
        var tipo_dragon = new Tipos("Dragón"); 
        Assert.That(tipo_hielo.EfectividadDeDaño(tipo_dragon), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Hielo sea muy efectivo contra Planta.
    /// </summary>
    [Test]
    public void EfectividadHieloVsPlanta() 
    { 
        var tipo_hielo = new Tipos("Hielo"); 
        var tipo_planta = new Tipos("Planta"); 
        Assert.That(tipo_hielo.EfectividadDeDaño(tipo_planta), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Hielo sea muy efectivo contra Tierra.
    /// </summary>
    [Test]
    public void EfectividadHieloVsTierra() 
    { 
        var tipo_hielo = new Tipos("Hielo"); 
        var tipo_tierra = new Tipos("Tierra"); 
        Assert.That(tipo_hielo.EfectividadDeDaño(tipo_tierra), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Hielo sea muy efectivo contra Volador.
    /// </summary>
    [Test]
    public void EfectividadHieloVsVolador() 
    { 
        var tipo_hielo = new Tipos("Hielo"); 
        var tipo_volador = new Tipos("Volador"); 
        Assert.That(tipo_hielo.EfectividadDeDaño(tipo_volador), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Hielo sea poco efectivo contra Agua.
    /// </summary>
    [Test]
    public void EfectividadHieloVsAgua() 
    { 
        var tipo_hielo = new Tipos("Hielo"); 
        var tipo_agua = new Tipos("Agua"); 
        Assert.That(tipo_hielo.EfectividadDeDaño(tipo_agua), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Hielo sea poco efectivo contra Hielo.
    /// </summary>
    [Test]
    public void EfectividadHieloVsHielo() 
    { 
        var tipo_hielo = new Tipos("Hielo"); 
        var tipo_hielo2 = new Tipos("Hielo"); 
        Assert.That(tipo_hielo.EfectividadDeDaño(tipo_hielo2), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Hielo tenga efectividad neutral contra Fuego.
    /// </summary>
    [Test]
    public void EfectividadHieloVsFuego() 
    { 
        var tipo_hielo = new Tipos("Hielo"); 
        var tipo_fuego = new Tipos("Fuego"); 
        Assert.That(tipo_hielo.EfectividadDeDaño(tipo_fuego), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Hielo tenga efectividad neutral contra Fantasma.
    /// </summary>
    [Test]
    public void EfectividadHieloVsFantasma() 
    { 
        var tipo_hielo = new Tipos("Hielo"); 
        var tipo_fantasma = new Tipos("Fantasma"); 
        Assert.That(tipo_hielo.EfectividadDeDaño(tipo_fantasma), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Hielo tenga efectividad neutral contra Normal.
    /// </summary>
    [Test]
    public void EfectividadHieloVsNormal() 
    { 
        var tipo_hielo = new Tipos("Hielo"); 
        var tipo_normal = new Tipos("Normal"); 
        Assert.That(tipo_hielo.EfectividadDeDaño(tipo_normal), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Hielo tenga efectividad neutral contra Veneno.
    /// </summary>
    [Test]
    public void EfectividadHieloVsVeneno() 
    { 
        var tipo_hielo = new Tipos("Hielo"); 
        var tipo_veneno = new Tipos("Veneno"); 
        Assert.That(tipo_hielo.EfectividadDeDaño(tipo_veneno), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Hielo tenga efectividad neutral contra Roca.
    /// </summary>
    [Test]
    public void EfectividadHieloVsRoca() 
    { 
        var tipo_hielo = new Tipos("Hielo"); 
        var tipo_roca = new Tipos("Roca"); 
        Assert.That(tipo_hielo.EfectividadDeDaño(tipo_roca), Is.EqualTo(1)); 
    }
    
        // ----------------------------Lucha----------------------------------------//

    /// <summary>
    /// Válida que el tipo Lucha sea muy efectivo contra Hielo.
    /// </summary>
    [Test]
    public void EfectividadLuchaVsHielo() 
    { 
        var tipo_lucha = new Tipos("Lucha"); 
        var tipo_hielo = new Tipos("Hielo"); 
        Assert.That(tipo_lucha.EfectividadDeDaño(tipo_hielo), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Lucha sea muy efectivo contra Normal.
    /// </summary>
    [Test]
    public void EfectividadLuchaVsNormal() 
    { 
        var tipo_lucha = new Tipos("Lucha"); 
        var tipo_normal = new Tipos("Normal"); 
        Assert.That(tipo_lucha.EfectividadDeDaño(tipo_normal), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Lucha sea muy efectivo contra Roca.
    /// </summary>
    [Test]
    public void EfectividadLuchaVsRoca() 
    { 
        var tipo_lucha = new Tipos("Lucha"); 
        var tipo_roca = new Tipos("Roca"); 
        Assert.That(tipo_lucha.EfectividadDeDaño(tipo_roca), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Lucha sea muy efectivo contra Psíquico.
    /// </summary>
    [Test]
    public void EfectividadLuchaVsPsiquico() 
    { 
        var tipo_lucha = new Tipos("Lucha"); 
        var tipo_psiquico = new Tipos("Psíquico"); 
        Assert.That(tipo_lucha.EfectividadDeDaño(tipo_psiquico), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Lucha sea muy efectivo contra Veneno.
    /// </summary>
    [Test]
    public void EfectividadLuchaVsVeneno() 
    { 
        var tipo_lucha = new Tipos("Lucha"); 
        var tipo_veneno = new Tipos("Veneno"); 
        Assert.That(tipo_lucha.EfectividadDeDaño(tipo_veneno), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Lucha sea poco efectivo contra Bicho.
    /// </summary>
    [Test]
    public void EfectividadLuchaVsBicho() 
    { 
        var tipo_lucha = new Tipos("Lucha"); 
        var tipo_bicho = new Tipos("Bicho"); 
        Assert.That(tipo_lucha.EfectividadDeDaño(tipo_bicho), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Lucha sea poco efectivo contra Fantasma.
    /// </summary>
    [Test]
    public void EfectividadLuchaVsFantasma() 
    { 
        var tipo_lucha = new Tipos("Lucha"); 
        var tipo_fantasma = new Tipos("Fantasma"); 
        Assert.That(tipo_lucha.EfectividadDeDaño(tipo_fantasma), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Lucha sea poco efectivo contra Volador.
    /// </summary>
    [Test]
    public void EfectividadLuchaVsVolador() 
    { 
        var tipo_lucha = new Tipos("Lucha"); 
        var tipo_volador = new Tipos("Volador"); 
        Assert.That(tipo_lucha.EfectividadDeDaño(tipo_volador), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Lucha tenga efectividad neutral contra Eléctrico.
    /// </summary>
    [Test]
    public void EfectividadLuchaVsElectrico() 
    { 
        var tipo_lucha = new Tipos("Lucha"); 
        var tipo_electrico = new Tipos("Electrico"); 
        Assert.That(tipo_lucha.EfectividadDeDaño(tipo_electrico), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Lucha tenga efectividad neutral contra Agua.
    /// </summary>
    [Test]
    public void EfectividadLuchaVsAgua() 
    { 
        var tipo_lucha = new Tipos("Lucha"); 
        var tipo_agua = new Tipos("Agua"); 
        Assert.That(tipo_lucha.EfectividadDeDaño(tipo_agua), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Lucha tenga efectividad neutral contra Dragón.
    /// </summary>
    [Test]
    public void EfectividadLuchaVsDragon() 
    { 
        var tipo_lucha = new Tipos("Lucha"); 
        var tipo_dragon = new Tipos("Dragón"); 
        Assert.That(tipo_lucha.EfectividadDeDaño(tipo_dragon), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Lucha tenga efectividad neutral contra Planta.
    /// </summary>
    [Test]
    public void EfectividadLuchaVsPlanta() 
    { 
        var tipo_lucha = new Tipos("Lucha"); 
        var tipo_planta = new Tipos("Planta"); 
        Assert.That(tipo_lucha.EfectividadDeDaño(tipo_planta), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Lucha tenga efectividad neutral contra Fuego.
    /// </summary>
    [Test]
    public void EfectividadLuchaVsFuego() 
    { 
        var tipo_lucha = new Tipos("Lucha"); 
        var tipo_fuego = new Tipos("Fuego"); 
        Assert.That(tipo_lucha.EfectividadDeDaño(tipo_fuego), Is.EqualTo(1)); 
    }
    
        // ----------------------------Normal----------------------------------------//

    /// <summary>
    /// Válida que el tipo Normal sea poco efectivo contra Roca.
    /// </summary>
    [Test]
    public void EfectividadNormalVsRoca() 
    { 
        var tipo_normal = new Tipos("Normal"); 
        var tipo_roca = new Tipos("Roca"); 
        Assert.That(tipo_normal.EfectividadDeDaño(tipo_roca), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Normal sea poco efectivo contra Fantasma.
    /// </summary>
    [Test]
    public void EfectividadNormalVsFantasma() 
    { 
        var tipo_normal = new Tipos("Normal"); 
        var tipo_fantasma = new Tipos("Fantasma"); 
        Assert.That(tipo_normal.EfectividadDeDaño(tipo_fantasma), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Normal tenga efectividad neutral contra Hielo.
    /// </summary>
    [Test]
    public void EfectividadNormalVsHielo() 
    { 
        var tipo_normal = new Tipos("Normal"); 
        var tipo_hielo = new Tipos("Hielo"); 
        Assert.That(tipo_normal.EfectividadDeDaño(tipo_hielo), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Normal tenga efectividad neutral contra Lucha.
    /// </summary>
    [Test]
    public void EfectividadNormalVsLucha() 
    { 
        var tipo_normal = new Tipos("Normal"); 
        var tipo_lucha = new Tipos("Lucha"); 
        Assert.That(tipo_normal.EfectividadDeDaño(tipo_lucha), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Normal tenga efectividad neutral contra Eléctrico.
    /// </summary>
    [Test]
    public void EfectividadNormalVsElectrico() 
    { 
        var tipo_normal = new Tipos("Normal"); 
        var tipo_electrico = new Tipos("Electrico"); 
        Assert.That(tipo_normal.EfectividadDeDaño(tipo_electrico), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Normal tenga efectividad neutral contra Agua.
    /// </summary>
    [Test]
    public void EfectividadNormalVsAgua() 
    { 
        var tipo_normal = new Tipos("Normal"); 
        var tipo_agua = new Tipos("Agua"); 
        Assert.That(tipo_normal.EfectividadDeDaño(tipo_agua), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Normal tenga efectividad neutral contra Dragón.
    /// </summary>
    [Test]
    public void EfectividadNormalVsDragon() 
    { 
        var tipo_normal = new Tipos("Normal"); 
        var tipo_dragon = new Tipos("Dragón"); 
        Assert.That(tipo_normal.EfectividadDeDaño(tipo_dragon), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Normal tenga efectividad neutral contra Planta.
    /// </summary>
    [Test]
    public void EfectividadNormalVsPlanta() 
    { 
        var tipo_normal = new Tipos("Normal"); 
        var tipo_planta = new Tipos("Planta"); 
        Assert.That(tipo_normal.EfectividadDeDaño(tipo_planta), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Normal tenga efectividad neutral contra Fuego.
    /// </summary>
    [Test]
    public void EfectividadNormalVsFuego() 
    { 
        var tipo_normal = new Tipos("Normal"); 
        var tipo_fuego = new Tipos("Fuego"); 
        Assert.That(tipo_normal.EfectividadDeDaño(tipo_fuego), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Normal tenga efectividad neutral contra Veneno.
    /// </summary>
    [Test]
    public void EfectividadNormalVsVeneno() 
    { 
        var tipo_normal = new Tipos("Normal"); 
        var tipo_veneno = new Tipos("Veneno"); 
        Assert.That(tipo_normal.EfectividadDeDaño(tipo_veneno), Is.EqualTo(1)); 
    }


    /// <summary>
    /// Válida que el tipo Normal tenga efectividad neutral contra Psíquico.
    /// </summary>
    [Test]
    public void EfectividadNormalVsPsiquico() 
    { 
        var tipo_normal = new Tipos("Normal"); 
        var tipo_psiquico = new Tipos("Psíquico"); 
        Assert.That(tipo_normal.EfectividadDeDaño(tipo_psiquico), Is.EqualTo(1)); 
    }
    
        // ----------------------------Tierra----------------------------------------//

    /// <summary>
    /// Válida que el tipo Tierra sea neutro contra Eléctrico.
    /// </summary>
    [Test]
    public void EfectividadTierraVsElectrico() 
    { 
        var tipo_tierra = new Tipos("Tierra"); 
        var tipo_electrico = new Tipos("Electrico"); 
        Assert.That(tipo_tierra.EfectividadDeDaño(tipo_electrico), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Tierra sea muy efectivo contra Fuego.
    /// </summary>
    [Test]
    public void EfectividadTierraVsFuego() 
    { 
        var tipo_tierra = new Tipos("Tierra"); 
        var tipo_fuego = new Tipos("Fuego"); 
        Assert.That(tipo_tierra.EfectividadDeDaño(tipo_fuego), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Tierra sea muy efectivo contra Roca.
    /// </summary>
    [Test]
    public void EfectividadTierraVsRoca() 
    { 
        var tipo_tierra = new Tipos("Tierra"); 
        var tipo_roca = new Tipos("Roca"); 
        Assert.That(tipo_tierra.EfectividadDeDaño(tipo_roca), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Tierra sea muy efectivo contra Veneno.
    /// </summary>
    [Test]
    public void EfectividadTierraVsVeneno() 
    { 
        var tipo_tierra = new Tipos("Tierra"); 
        var tipo_veneno = new Tipos("Veneno"); 
        Assert.That(tipo_tierra.EfectividadDeDaño(tipo_veneno), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Tierra sea poco efectivo contra Bicho.
    /// </summary>
    [Test]
    public void EfectividadTierraVsBicho() 
    { 
        var tipo_tierra = new Tipos("Tierra"); 
        var tipo_bicho = new Tipos("Bicho"); 
        Assert.That(tipo_tierra.EfectividadDeDaño(tipo_bicho), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Tierra sea poco efectivo contra Planta.
    /// </summary>
    [Test]
    public void EfectividadTierraVsPlanta() 
    { 
        var tipo_tierra = new Tipos("Tierra"); 
        var tipo_planta = new Tipos("Planta"); 
        Assert.That(tipo_tierra.EfectividadDeDaño(tipo_planta), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Tierra sea poco efectivo contra Volador.
    /// </summary>
    [Test]
    public void EfectividadTierraVsVolador() 
    { 
        var tipo_tierra = new Tipos("Tierra"); 
        var tipo_volador = new Tipos("Volador"); 
        Assert.That(tipo_tierra.EfectividadDeDaño(tipo_volador), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Tierra tenga efectividad neutral contra Agua.
    /// </summary>
    [Test]
    public void EfectividadTierraVsAgua() 
    { 
        var tipo_tierra = new Tipos("Tierra"); 
        var tipo_agua = new Tipos("Agua"); 
        Assert.That(tipo_tierra.EfectividadDeDaño(tipo_agua), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Tierra tenga efectividad neutral contra Dragón.
    /// </summary>
    [Test]
    public void EfectividadTierraVsDragon() 
    { 
        var tipo_tierra = new Tipos("Tierra"); 
        var tipo_dragon = new Tipos("Dragón"); 
        Assert.That(tipo_tierra.EfectividadDeDaño(tipo_dragon), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Tierra tenga efectividad neutral contra Lucha.
    /// </summary>
    [Test]
    public void EfectividadTierraVsLucha() 
    { 
        var tipo_tierra = new Tipos("Tierra"); 
        var tipo_lucha = new Tipos("Lucha"); 
        Assert.That(tipo_tierra.EfectividadDeDaño(tipo_lucha), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Tierra tenga efectividad neutral contra Hielo.
    /// </summary>
    [Test]
    public void EfectividadTierraVsHielo() 
    { 
        var tipo_tierra = new Tipos("Tierra"); 
        var tipo_hielo = new Tipos("Hielo"); 
        Assert.That(tipo_tierra.EfectividadDeDaño(tipo_hielo), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Tierra tenga efectividad neutral contra Normal.
    /// </summary>
    [Test]
    public void EfectividadTierraVsNormal() 
    { 
        var tipo_tierra = new Tipos("Tierra"); 
        var tipo_normal = new Tipos("Normal"); 
        Assert.That(tipo_tierra.EfectividadDeDaño(tipo_normal), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Tierra tenga efectividad neutral contra Psíquico.
    /// </summary>
    [Test]
    public void EfectividadTierraVsPsiquico() 
    { 
        var tipo_tierra = new Tipos("Tierra"); 
        var tipo_psiquico = new Tipos("Psíquico"); 
        Assert.That(tipo_tierra.EfectividadDeDaño(tipo_psiquico), Is.EqualTo(1)); 
    }
    
       // ----------------------------Veneno----------------------------------------//

    /// <summary>
    /// Válida que el tipo Veneno sea muy efectivo contra Bicho.
    /// </summary>
    [Test]
    public void EfectividadVenenoVsBicho() 
    { 
        var tipo_veneno = new Tipos("Veneno"); 
        var tipo_bicho = new Tipos("Bicho"); 
        Assert.That(tipo_veneno.EfectividadDeDaño(tipo_bicho), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Veneno sea muy efectivo contra Planta.
    /// </summary>
    [Test]
    public void EfectividadVenenoVsPlanta() 
    { 
        var tipo_veneno = new Tipos("Veneno"); 
        var tipo_planta = new Tipos("Planta"); 
        Assert.That(tipo_veneno.EfectividadDeDaño(tipo_planta), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Veneno sea muy efectivo contra Tierra.
    /// </summary>
    [Test]
    public void EfectividadVenenoVsTierra() 
    { 
        var tipo_veneno = new Tipos("Veneno"); 
        var tipo_tierra = new Tipos("Tierra"); 
        Assert.That(tipo_veneno.EfectividadDeDaño(tipo_tierra), Is.EqualTo(2)); 
    }

    /// <summary>
    /// Válida que el tipo Veneno sea poco efectivo contra Fantasma.
    /// </summary>
    [Test]
    public void EfectividadVenenoVsFantasma() 
    { 
        var tipo_veneno = new Tipos("Veneno"); 
        var tipo_fantasma = new Tipos("Fantasma"); 
        Assert.That(tipo_veneno.EfectividadDeDaño(tipo_fantasma), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Veneno sea poco efectivo contra Veneno.
    /// </summary>
    [Test]
    public void EfectividadVenenoVsVeneno() 
    { 
        var tipo_veneno = new Tipos("Veneno"); 
        var tipo_veneno2 = new Tipos("Veneno"); 
        Assert.That(tipo_veneno.EfectividadDeDaño(tipo_veneno2), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Veneno sea poco efectivo contra Roca.
    /// </summary>
    [Test]
    public void EfectividadVenenoVsRoca() 
    { 
        var tipo_veneno = new Tipos("Veneno"); 
        var tipo_roca = new Tipos("Roca"); 
        Assert.That(tipo_veneno.EfectividadDeDaño(tipo_roca), Is.EqualTo(0.5)); 
    }

    /// <summary>
    /// Válida que el tipo Veneno tenga efectividad neutral contra Eléctrico.
    /// </summary>
    [Test]
    public void EfectividadVenenoVsElectrico() 
    { 
        var tipo_veneno = new Tipos("Veneno"); 
        var tipo_electrico = new Tipos("Electrico"); 
        Assert.That(tipo_veneno.EfectividadDeDaño(tipo_electrico), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Veneno tenga efectividad neutral contra Fuego.
    /// </summary>
    [Test]
    public void EfectividadVenenoVsFuego() 
    { 
        var tipo_veneno = new Tipos("Veneno"); 
        var tipo_fuego = new Tipos("Fuego"); 
        Assert.That(tipo_veneno.EfectividadDeDaño(tipo_fuego), Is.EqualTo(1)); 
    }



    /// <summary>
    /// Válida que el tipo Veneno tenga efectividad neutral contra Agua.
    /// </summary>
    [Test]
    public void EfectividadVenenoVsAgua() 
    { 
        var tipo_veneno = new Tipos("Veneno"); 
        var tipo_agua = new Tipos("Agua"); 
        Assert.That(tipo_veneno.EfectividadDeDaño(tipo_agua), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Veneno tenga efectividad neutral contra Dragón.
    /// </summary>
    [Test]
    public void EfectividadVenenoVsDragon() 
    { 
        var tipo_veneno = new Tipos("Veneno"); 
        var tipo_dragon = new Tipos("Dragon"); 
        Assert.That(tipo_veneno.EfectividadDeDaño(tipo_dragon), Is.EqualTo(1)); 
    }

    /// <summary>
    /// Válida que el tipo Veneno tenga efectividad neutral contra Lucha.
    /// </summary>
    [Test]
    public void EfectividadVenenoVsLucha() 
    { 
        var tipo_veneno = new Tipos("Veneno"); 
        var tipo_lucha = new Tipos("Lucha"); 
        Assert.That(tipo_veneno.EfectividadDeDaño(tipo_lucha), Is.EqualTo(1)); 
    }
    
    
    // ----------------------------Volador----------------------------------------//
    
    /// <summary>
    /// Verifica que el tipo Volador sea muy efectivo contra Bicho.
    /// </summary>
    [Test]
    public void EfectividadVoladorBicho()
    {
        var tipoVolador = new Tipos("Volador");
        var tipoBicho = new Tipos("Bicho");
        var efectividad = tipoVolador.EfectividadDeDaño(tipoBicho);
        Assert.That(efectividad, Is.EqualTo(2));
    }

    /// <summary>
    /// Verifica que el tipo Volador sea muy efectivo contra Lucha.
    /// </summary>
    [Test]
    public void EfectividadVoladorLucha()
    {
        var tipoVolador = new Tipos("Volador");
        var tipoLucha = new Tipos("Lucha");
        var efectividad = tipoVolador.EfectividadDeDaño(tipoLucha);
        Assert.That(efectividad, Is.EqualTo(2));
    }

    /// <summary>
    /// Verifica que el tipo Volador sea muy efectivo contra Planta.
    /// </summary>
    [Test]
    public void EfectividadVoladorPlanta()
    {
        var tipoVolador = new Tipos("Volador");
        var tipoPlanta = new Tipos("Planta");
        var efectividad = tipoVolador.EfectividadDeDaño(tipoPlanta);
        Assert.That(efectividad, Is.EqualTo(2));
    }

    /// <summary>
    /// Verifica que el tipo Volador sea neutro efectivo contra Eléctrico.
    /// </summary>
    [Test]
    public void EfectividadVoladorElectrico()
    {
        var tipoVolador = new Tipos("Volador");
        var tipoElectrico = new Tipos("Electrico");
        var efectividad = tipoVolador.EfectividadDeDaño(tipoElectrico);
        Assert.That(efectividad, Is.EqualTo(1));
    }

    /// <summary>
    /// Verifica que el tipo Volador sea poco efectivo contra Roca.
    /// </summary>
    [Test]
    public void EfectividadVoladorRoca()
    {
        var tipoVolador = new Tipos("Volador");
        var tipoRoca = new Tipos("Roca");
        var efectividad = tipoVolador.EfectividadDeDaño(tipoRoca);
        Assert.That(efectividad, Is.EqualTo(0.5));
    }

    /// <summary>
    /// Verifica que el tipo Volador sea neutral contra Volador.
    /// </summary>
    [Test]
    public void EfectividadVoladorVolador()
    {
        var tipoVolador = new Tipos("Volador");
        var otroVolador = new Tipos("Volador");
        var efectividad = tipoVolador.EfectividadDeDaño(otroVolador);
        Assert.That(efectividad, Is.EqualTo(1));
    }

    /// <summary>
    /// Verifica que el tipo Volador sea neutro efectivo contra Tierra.
    /// </summary>
    [Test]
    public void EfectividadVoladorTierra()
    {
        var tipoVolador = new Tipos("Volador");
        var tipoTierra = new Tipos("Tierra");
        var efectividad = tipoVolador.EfectividadDeDaño(tipoTierra);
        Assert.That(efectividad, Is.EqualTo(1));
    }
    
    /// <summary>
    /// Verifica que el tipo Volador sea neutral contra Eléctrico.
    /// </summary>
    [Test]
    public void EfectividadVoladorElectricoNeutral()
    {
        var tipoVolador = new Tipos("Volador");
        var tipoElectrico = new Tipos("Electrico");
        var efectividad = tipoVolador.EfectividadDeDaño(tipoElectrico);
        Assert.That(efectividad, Is.EqualTo(1));
    }

    /// <summary>
    /// Verifica que el tipo Volador poco efectivo contra Roca.
    /// </summary>
    [Test]
    public void EfectividadVoladorRocaNeutral()
    {
        var tipoVolador = new Tipos("Volador");
        var tipoRoca = new Tipos("Roca");
        var efectividad = tipoVolador.EfectividadDeDaño(tipoRoca);
        Assert.That(efectividad, Is.EqualTo(0.5));
    }

    /// <summary>
    /// Verifica que el tipo Volador sea neutro efectivo contra Agua.
    /// </summary>
    [Test]
    public void EfectividadVoladorAgua()
    {
        var tipoVolador = new Tipos("Volador");
        var tipoAgua = new Tipos("Agua");
        var efectividad = tipoVolador.EfectividadDeDaño(tipoAgua);
        Assert.That(efectividad, Is.EqualTo(1));
    }
    
    
    // ----------------------------Dañiti----------------------------------------//
    
    
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
    

// Verifica que la relación entre un tipo y sí mismo sea neutra 
    [Test]
    public void EfectividadMismoTipo()
    {
        var tipoPlanta = new Tipos("Planta");
        var tipoPlantaMismo = new Tipos("Planta");

        // Verificamos que un tipo contra sí mismo tiene un daño neutral
        var efectividad = tipoPlanta.EfectividadDeDaño(tipoPlantaMismo);

        Assert.That(efectividad, Is.EqualTo(0.5)); 
    }

    
    // Agregar casos que validan los ataques sin interacciones especiales (deberían devolver 1)
    [Test]
    public void DañoSinEfectividad()
    {
        var tipoFuego = new Tipos("Fuego");
        var tipoNormal = new Tipos("Normal");

        var efectividad = tipoFuego.EfectividadDeDaño(tipoNormal);
        Assert.That(efectividad, Is.EqualTo(1));
    }

    [Test]
    public void DañoSinEfectividadEntreTipos()
    {
        var tipoRoca = new Tipos("Roca");
        var tipoFuego = new Tipos("Fuego");

        // Verificamos que el tipo "Roca" no tenga ventaja ni desventaja contra "Fuego"
        var efectividad = tipoRoca.EfectividadDeDaño(tipoFuego);

        Assert.That(efectividad, Is.EqualTo(2));
    }
    

 
}
