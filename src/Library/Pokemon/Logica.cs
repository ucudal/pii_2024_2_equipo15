namespace program;

public class Logica
{
    private static Logica? _instance;
    private Pokemon Sceptile;
    private Pokemon Arcanine;
    private Pokemon Blastoise;
    private Pokemon Snorlax;
    private Pokemon Pikachu;
    private Pokemon Jynx;
    private Pokemon Lucario;
    private Pokemon Tyranitar;
    private Pokemon Flygon;
    private Pokemon Pidgeot;
    private Pokemon Scyther;
    private Pokemon Amoonguss;
    private Pokemon Umbreon;
    private Pokemon Gengar;
    private Pokemon Lapras;
    private Pokemon Metagross;
    private Pokemon Dragonite;
    private Pokemon Sylveon;
    
    public static Logica Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Logica();
            }

            return _instance;
        }
    }
    
    public List<Pokemon> InicializarPokemones()
    {
        var elementoFuego = new Dictionary<string, double>
        {
            { "Acero", 2.0 }, { "Volador", 0.5 }, { "Agua", 0.5 }, { "Hielo", 2.0 }, { "Planta", 2.0 },
            { "Bicho", 2.0 }, { "Electrico", 1.0 }, { "Normal", 1.0 }, { "Roca", 2.0 }, { "Tierra", 1.0 },
            { "Fuego", 0.5 }, { "Lucha", 1.0 }, { "Hada", 1.0 }, { "Psiquico", 1.0 }, { "Veneno", 1.0 },
            { "Dragon", 1.0 }, { "Fantasma", 1.0 }, { "Siniestro", 1.0 }
        };

        var elementoAgua = new Dictionary<string, double>
        {
            { "Acero", 1.0 }, { "Volador", 0.5 }, { "Agua", 0.5 }, { "Hielo", 1.0 }, { "Planta", 0.5 },
            { "Bicho", 1.0 }, { "Electrico", 1.0 }, { "Normal", 1.0 }, { "Roca", 2.0 }, { "Tierra", 2.0 },
            { "Fuego", 2.0 }, { "Lucha", 1.0 }, { "Hada", 1.0 }, { "Psiquico", 1.0 }, { "Veneno", 1.0 },
            { "Dragon", 1.0 }, { "Fantasma", 1.0 }, { "Siniestro", 1.0 }
        };

        var elementoPlanta = new Dictionary<string, double>
        {
            { "Acero", 0.5 }, { "Volador", 0.5 }, { "Agua", 2.0 }, { "Hielo", 1.0 },
            { "Planta", 0.5 }, { "Bicho", 0.5 }, { "Electrico", 1.0 }, { "Normal", 1.0 },
            { "Roca", 2.0 }, { "Tierra", 2.0 }, { "Fuego", 0.5 }, { "Lucha", 1.0 },
            { "Hada", 1.0 }, { "Psiquico", 1.0 }, { "Veneno", 0.5 }, { "Dragon", 0.5 },
            { "Fantasma", 1.0 }, { "Siniestro", 1.0 }
        };

        var elementoVolador = new Dictionary<string, double>
        {
            { "Acero", 0.5 }, { "Volador", 1.0 }, { "Agua", 1.0 }, { "Hielo", 1.0 },
            { "Planta", 2.0 }, { "Bicho", 2.0 }, { "Electrico", 0.5 }, { "Normal", 1.0 },
            { "Roca", 0.5 }, { "Tierra", 1.0 }, { "Fuego", 1.0 }, { "Lucha", 2.0 },
            { "Hada", 1.0 }, { "Psiquico", 1.0 }, { "Veneno", 1.0 }, { "Dragon", 1.0 },
            { "Fantasma", 1.0 }, { "Siniestro", 1.0 }
        };

        var elementoAcero = new Dictionary<string, double>
        {
            { "Acero", 0.5 }, { "Volador", 1.0 }, { "Agua", 0.5 }, { "Hielo", 2.0 },
            { "Planta", 1.0 }, { "Bicho", 1.0 }, { "Electrico", 0.5 }, { "Normal", 1.0 },
            { "Roca", 2.0 }, { "Tierra", 1.0 }, { "Fuego", 0.5 }, { "Lucha", 1.0 },
            { "Hada", 2.0 }, { "Psiquico", 1.0 }, { "Veneno", 1.0 }, { "Dragon", 1.0 },
            { "Fantasma", 1.0 }, { "Siniestro", 1.0 }
        };

        var elementoBicho = new Dictionary<string, double>
        {
            { "Acero", 0.5 }, { "Volador", 0.5 }, { "Agua", 1.0 }, { "Hielo", 1.0 },
            { "Planta", 2.0 }, { "Bicho", 1.0 }, { "Electrico", 1.0 }, { "Normal", 1.0 },
            { "Roca", 0.5 }, { "Tierra", 1.0 }, { "Fuego", 0.5 }, { "Lucha", 0.5 },
            { "Hada", 0.5 }, { "Psiquico", 2.0 }, { "Veneno", 0.5 }, { "Dragon", 1.0 },
            { "Fantasma", 0.5 }, { "Siniestro", 2.0 }
        };

        var elementoElectrico = new Dictionary<string, double>
        {
            { "Acero", 1.0 }, { "Volador", 2.0 }, { "Agua", 2.0 }, { "Hielo", 1.0 },
            { "Planta", 0.5 }, { "Bicho", 1.0 }, { "Electrico", 0.5 }, { "Normal", 1.0 },
            { "Roca", 0.5 }, { "Tierra", 0.0 }, { "Fuego", 1.0 }, { "Lucha", 1.0 },
            { "Hada", 1.0 }, { "Psiquico", 1.0 }, { "Veneno", 1.0 }, { "Dragon", 0.5 },
            { "Fantasma", 1.0 }, { "Siniestro", 1.0 }
        };

        var elementoNormal = new Dictionary<string, double>
        {
            { "Acero", 0.5 }, { "Volador", 1.0 }, { "Agua", 1.0 }, { "Hielo", 1.0 },
            { "Planta", 1.0 }, { "Bicho", 1.0 }, { "Electrico", 1.0 }, { "Normal", 1.0 },
            { "Roca", 0.5 }, { "Tierra", 1.0 }, { "Fuego", 1.0 }, { "Lucha", 1.0 },
            { "Hada", 1.0 }, { "Psiquico", 1.0 }, { "Veneno", 1.0 }, { "Dragon", 1.0 },
            { "Fantasma", 0.0 }, { "Siniestro", 1.0 }
        };

        var elementoHielo = new Dictionary<string, double>
        {
            { "Acero", 0.5 }, { "Volador", 2.0 }, { "Agua", 0.5 }, { "Hielo", 0.5 },
            { "Planta", 2.0 }, { "Bicho", 1.0 }, { "Electrico", 1.0 }, { "Normal", 1.0 },
            { "Roca", 2.0 }, { "Tierra", 2.0 }, { "Fuego", 0.5 }, { "Lucha", 1.0 },
            { "Hada", 1.0 }, { "Psiquico", 1.0 }, { "Veneno", 1.0 }, { "Dragon", 2.0 },
            { "Fantasma", 1.0 }, { "Siniestro", 1.0 }
        };

        var elementoLucha = new Dictionary<string, double>
        {
            { "Acero", 2.0 }, { "Volador", 0.5 }, { "Agua", 1.0 }, { "Hielo", 2.0 },
            { "Planta", 1.0 }, { "Bicho", 0.5 }, { "Electrico", 1.0 }, { "Normal", 2.0 },
            { "Roca", 2.0 }, { "Tierra", 1.0 }, { "Fuego", 1.0 }, { "Lucha", 1.0 },
            { "Hada", 0.5 }, { "Psiquico", 0.5 }, { "Veneno", 0.5 }, { "Dragon", 1.0 },
            { "Fantasma", 0.0 }, { "Siniestro", 2.0 }
        };

        var elementoHada = new Dictionary<string, double>
        {
            { "Acero", 0.5 }, { "Volador", 1.0 }, { "Agua", 1.0 }, { "Hielo", 1.0 },
            { "Planta", 1.0 }, { "Bicho", 1.0 }, { "Electrico", 1.0 }, { "Normal", 1.0 },
            { "Roca", 1.0 }, { "Tierra", 1.0 }, { "Fuego", 0.5 }, { "Lucha", 2.0 },
            { "Hada", 1.0 }, { "Psiquico", 1.0 }, { "Veneno", 0.5 }, { "Dragon", 2.0 },
            { "Fantasma", 1.0 }, { "Siniestro", 2.0 }
        };

        var elementoPsiquico = new Dictionary<string, double>
        {
            { "Acero", 0.5 }, { "Volador", 1.0 }, { "Agua", 1.0 }, { "Hielo", 1.0 },
            { "Planta", 1.0 }, { "Bicho", 1.0 }, { "Electrico", 1.0 }, { "Normal", 1.0 },
            { "Roca", 1.0 }, { "Tierra", 1.0 }, { "Fuego", 1.0 }, { "Lucha", 2.0 },
            { "Hada", 1.0 }, { "Psiquico", 0.5 }, { "Veneno", 2.0 }, { "Dragon", 1.0 },
            { "Fantasma", 1.0 }, { "Siniestro", 0.5 }
        };

        var elementoVeneno = new Dictionary<string, double>
        {
            { "Acero", 0.0 }, { "Volador", 1.0 }, { "Agua", 1.0 }, { "Hielo", 1.0 },
            { "Planta", 2.0 }, { "Bicho", 1.0 }, { "Electrico", 1.0 }, { "Normal", 1.0 },
            { "Roca", 0.5 }, { "Tierra", 0.5 }, { "Fuego", 1.0 }, { "Lucha", 1.0 },
            { "Hada", 2.0 }, { "Psiquico", 1.0 }, { "Veneno", 1.0 }, { "Dragon", 1.0 },
            { "Fantasma", 0.5 }, { "Siniestro", 1.0 }
        };

        var elementoRoca = new Dictionary<string, double>
        {
            { "Acero", 0.5 }, { "Volador", 2.0 }, { "Agua", 1.0 }, { "Hielo", 2.0 },
            { "Planta", 1.0 }, { "Bicho", 2.0 }, { "Electrico", 1.0 }, { "Normal", 1.0 },
            { "Roca", 1.0 }, { "Tierra", 0.5 }, { "Fuego", 2.0 }, { "Lucha", 0.5 },
            { "Hada", 1.0 }, { "Psiquico", 1.0 }, { "Veneno", 1.0 }, { "Dragon", 1.0 },
            { "Fantasma", 1.0 }, { "Siniestro", 1.0 }
        };

        var elementoTierra = new Dictionary<string, double>
        {
            { "Acero", 2.0 }, { "Volador", 0.0 }, { "Agua", 1.0 }, { "Hielo", 1.0 },
            { "Planta", 0.5 }, { "Bicho", 0.5 }, { "Electrico", 2.0 }, { "Normal", 1.0 },
            { "Roca", 2.0 }, { "Tierra", 1.0 }, { "Fuego", 2.0 }, { "Lucha", 1.0 },
            { "Hada", 1.0 }, { "Psiquico", 1.0 }, { "Veneno", 2.0 }, { "Dragon", 1.0 },
            { "Fantasma", 1.0 }, { "Siniestro", 1.0 }
        };

        var elementoFantasma = new Dictionary<string, double>
        {
            { "Acero", 1.0 }, { "Volador", 1.0 }, { "Agua", 1.0 }, { "Hielo", 1.0 },
            { "Planta", 1.0 }, { "Bicho", 1.0 }, { "Electrico", 1.0 }, { "Normal", 0.0 },
            { "Roca", 1.0 }, { "Tierra", 1.0 }, { "Fuego", 1.0 }, { "Lucha", 1.0 },
            { "Hada", 1.0 }, { "Psiquico", 1.0 }, { "Veneno", 1.0 }, { "Dragon", 1.0 },
            { "Fantasma", 2.0 }, { "Siniestro", 0.5 }
        };

        var elementoSiniestro = new Dictionary<string, double>
        {
            { "Acero", 1.0 }, { "Volador", 1.0 }, { "Agua", 1.0 }, { "Hielo", 1.0 },
            { "Planta", 1.0 }, { "Bicho", 1.0 }, { "Electrico", 1.0 }, { "Normal", 1.0 },
            { "Roca", 1.0 }, { "Tierra", 1.0 }, { "Fuego", 1.0 }, { "Lucha", 0.5 },
            { "Hada", 0.5 }, { "Psiquico", 2.0 }, { "Veneno", 1.0 }, { "Dragon", 1.0 },
            { "Fantasma", 2.0 }, { "Siniestro", 0.5 }
        };

        var elementoDragon = new Dictionary<string, double>
        {
            { "Acero", 0.5 }, { "Volador", 1.0 }, { "Agua", 1.0 }, { "Hielo", 2.0 },
            { "Planta", 1.0 }, { "Bicho", 1.0 }, { "Electrico", 1.0 }, { "Normal", 1.0 },
            { "Roca", 1.0 }, { "Tierra", 1.0 }, { "Fuego", 1.0 }, { "Lucha", 1.0 },
            { "Hada", 0.0 }, { "Psiquico", 1.0 }, { "Veneno", 1.0 }, { "Dragon", 2.0 },
            { "Fantasma", 1.0 }, { "Siniestro", 1.0 }
        };

        ITipo tipoFuego = new Tipos("Fuego", elementoFuego);
        ITipo tipoAgua = new Tipos("Agua", elementoAgua);
        ITipo tipoHielo = new Tipos("Hielo", elementoHielo);
        ITipo tipoLucha = new Tipos("Lucha", elementoLucha);
        ITipo tipoHada = new Tipos("Hada", elementoHada);
        ITipo tipoPsiquico = new Tipos("Psiquico", elementoPsiquico);
        ITipo tipoVeneno = new Tipos("Veneno", elementoVeneno);
        ITipo tipoDragon = new Tipos("Dragon", elementoDragon);
        ITipo tipoFantasma = new Tipos("Fantasma", elementoFantasma);
        ITipo tipoSiniestro = new Tipos("Siniestro", elementoSiniestro);
        ITipo tipoElectrico = new Tipos("Electrico", elementoElectrico);
        ITipo tipoBicho = new Tipos("Bicho", elementoBicho);
        ITipo tipoPlanta = new Tipos("Planta", elementoPlanta);
        ITipo tipoTierra = new Tipos("Tierra", elementoTierra);
        ITipo tipoRoca = new Tipos("Roca", elementoRoca);
        ITipo tipoAcero = new Tipos("Acero", elementoAcero);
        ITipo tipoNormal = new Tipos("Normal", elementoNormal);
        ITipo tipoVolador = new Tipos("Volador", elementoVolador);

        IEfectos paralisis = new Efectos("paralizado");
        IEfectos noqueado = new Efectos("noqueado");
        IEfectos quemadura = new Efectos("quemado");
        IEfectos envenenado = new Efectos("envenenado");

        Sceptile = new Pokemon("SCEPTILE", 281, tipoPlanta);
        Arcanine = new Pokemon("ARCANINE", 321, tipoFuego);
        Blastoise = new Pokemon("BLASTOISE", 299, tipoAgua);
        Snorlax = new Pokemon("SNORLAX", 461, tipoNormal);
        Pikachu = new Pokemon("PIKACHU", 211, tipoElectrico);
        Jynx = new Pokemon("JYNX", 271, tipoPsiquico, tipoHielo);
        Lucario = new Pokemon("LUCARIO", 281, tipoLucha, tipoAcero);
        Tyranitar = new Pokemon("TYRANITAR", 341, tipoRoca, tipoSiniestro);
        Flygon = new Pokemon("FLYGON", 301, tipoTierra, tipoDragon);
        Pidgeot = new Pokemon("PIDGEOT", 307, tipoVolador, tipoNormal);
        Scyther = new Pokemon("SCYTHER", 281, tipoBicho, tipoVolador);
        Amoonguss = new Pokemon("AMOONGUSS", 369, tipoVeneno, tipoPlanta);
        Umbreon = new Pokemon("UMBREON", 331, tipoSiniestro);
        Gengar = new Pokemon("GENGAR", 261, tipoFantasma, tipoSiniestro);
        Lapras = new Pokemon("LAPRAS", 401, tipoHielo, tipoAgua);
        Metagross = new Pokemon("METAGROSS", 351, tipoAcero, tipoPsiquico);
        Dragonite = new Pokemon("DRAGONITE", 323, tipoDragon, tipoVolador);
        Sylveon = new Pokemon("SYLVEON", 331, tipoHada);

        // SCEPTILE
        IHabilidad cortefuria = new Habilidades("Corte furia", tipoBicho, 40, 95, 20, false);
        IHabilidad energibola = new Habilidades("Energibola", tipoPlanta, 90, 100, 10, false);
        IHabilidad hojaguda = new Habilidades("Hoja Aguda", tipoPlanta, 90, 100, 15, false);
        IHabilidad lluevehojas = new Habilidades("Lluevehojas", tipoPlanta, 130, 80, 5, true);

        Sceptile.AprenderHabilidad(cortefuria);
        Sceptile.AprenderHabilidad(energibola);
        Sceptile.AprenderHabilidad(hojaguda);
        Sceptile.AprenderHabilidad(lluevehojas);
        
        // ARCANINE

        IHabilidad ascuas = new Habilidades("Ascuas", tipoFuego, 40, 100, 25, false);
        IHabilidad lanzallamas = new Habilidades("Lanzallamas", tipoFuego, 90, 90, 15, false);
        IHabilidad velocidadExtrema = new Habilidades("Velocidad Extrema", tipoNormal, 80, 70, 5, false);
        IHabilidad enviteigneo = new Habilidades("Envite igneo", tipoFuego, 120, 100, 15, true, quemadura);

        Arcanine.AprenderHabilidad(ascuas);
        Arcanine.AprenderHabilidad(lanzallamas);
        Arcanine.AprenderHabilidad(velocidadExtrema);
        Arcanine.AprenderHabilidad(enviteigneo);

        // BLASTOISE
        
        IHabilidad pistolaAgua = new Habilidades("Pistola Agua", tipoAgua, 40, 100, 25, false);
        IHabilidad hidropulso = new Habilidades("Hidropulso", tipoAgua, 60, 100, 20, false);
        IHabilidad acuacola = new Habilidades("Acua cola", tipoAgua, 90, 90, 10, false);
        IHabilidad hidroBomba = new Habilidades("Hidroomba", tipoAgua, 110, 80, 5, true);

        Blastoise.AprenderHabilidad(hidroBomba);
        Blastoise.AprenderHabilidad(hidropulso);
        Blastoise.AprenderHabilidad(acuacola);
        Blastoise.AprenderHabilidad(pistolaAgua);

        // SNORLAX
        
        IHabilidad golpecuerpo = new Habilidades("Golpe cuerpo", tipoNormal, 85, 100, 15, false);
        IHabilidad mordisco = new Habilidades("Mordisco", tipoSiniestro, 60, 100, 25, false);
        IHabilidad fuerzaequina = new Habilidades("Fuerza equina", tipoTierra, 95, 95, 10, false);
        IHabilidad gigaimpacto = new Habilidades("Gigaimpacto", tipoNormal, 150, 60, 5, true, noqueado);
        
        Snorlax.AprenderHabilidad(golpecuerpo);
        Snorlax.AprenderHabilidad(mordisco);
        Snorlax.AprenderHabilidad(fuerzaequina);
        Snorlax.AprenderHabilidad(gigaimpacto);

        // PIKACHU
        IHabilidad electrobola = new Habilidades("Electrobola", tipoElectrico, 90, 90, 6, false);
        IHabilidad rayo = new Habilidades("Rayo", tipoElectrico, 110, 70, 15, false);
        IHabilidad puniotrueno = new Habilidades("Puño Trueno", tipoElectrico, 60, 100, 15, false);
        IHabilidad trueno = new Habilidades("Trueno", tipoElectrico, 120, 50, 5, true, paralisis);

        Pikachu.AprenderHabilidad(electrobola);
        Pikachu.AprenderHabilidad(rayo);
        Pikachu.AprenderHabilidad(puniotrueno);
        Pikachu.AprenderHabilidad(trueno);

        // JYNX
        IHabilidad bolasombra = new Habilidades("Bola Sombra", tipoFantasma, 70, 80, 15, false);
        IHabilidad psiquico = new Habilidades("Psiquico", tipoPsiquico, 90, 90, 10, false);
        IHabilidad confusion = new Habilidades("Confusion", tipoPsiquico, 70, 100, 20, false);
        IHabilidad cabezazozen = new Habilidades("Cabezazo Zen", tipoPsiquico, 130, 70, 5, true, noqueado);

        Jynx.AprenderHabilidad(bolasombra);
        Jynx.AprenderHabilidad(psiquico);
        Jynx.AprenderHabilidad(confusion);
        Jynx.AprenderHabilidad(cabezazozen);

        // LUCARIO
        IHabilidad golperoca = new Habilidades("Golpe Roca", tipoLucha, 40, 100, 15, false);
        IHabilidad puniodehierro = new Habilidades("Puño de Hierro", tipoAcero, 80, 100, 10, false);
        IHabilidad garrametal = new Habilidades("Garra Metal", tipoAcero, 95, 90, 15, false);
        IHabilidad abocajarro = new Habilidades("A bocajarro", tipoLucha, 120, 80, 5, true);

        Lucario.AprenderHabilidad(golperoca);
        Lucario.AprenderHabilidad(puniodehierro);
        Lucario.AprenderHabilidad(garrametal);
        Lucario.AprenderHabilidad(abocajarro);

        // FLYGON
        IHabilidad terremoto = new Habilidades("Terremoto", tipoTierra, 70, 70, 15, false);
        IHabilidad pataleta = new Habilidades("Pataleta", tipoTierra, 75, 100, 10, false);
        IHabilidad danzadeldragon = new Habilidades("Danza del Dragon", tipoDragon, 80, 90, 20, false);
        IHabilidad cataclismo = new Habilidades("Cataclismo", tipoTierra, 140, 60, 5, true, noqueado);

        Flygon.AprenderHabilidad(terremoto);
        Flygon.AprenderHabilidad(pataleta);
        Flygon.AprenderHabilidad(danzadeldragon);
        Flygon.AprenderHabilidad(cataclismo);

        // TYRANITAR
        IHabilidad terratemblor = new Habilidades("Terratemblor", tipoTierra, 60, 100, 20, false);
        IHabilidad avalancha = new Habilidades("Avalancha", tipoRoca, 75, 80, 15, false);
        IHabilidad lanzarrocas = new Habilidades("Lanzarrocas", tipoRoca, 50, 100, 20, false);
        IHabilidad rocaafilada = new Habilidades("Roca afilada", tipoRoca, 110, 70, 10, true);

        Tyranitar.AprenderHabilidad(terratemblor);
        Tyranitar.AprenderHabilidad(avalancha);
        Tyranitar.AprenderHabilidad(lanzarrocas);
        Tyranitar.AprenderHabilidad(rocaafilada);

        // PIDGEOT
        IHabilidad aereocontrol = new Habilidades("Aereocontrol", tipoVolador, 85, 100, 10, false);
        IHabilidad corteAereo = new Habilidades("Corte Aereo", tipoVolador, 90, 100, 15, false);
        IHabilidad vientoAullador = new Habilidades("Viento Aullador", tipoVolador, 75, 95, 20, false);
        IHabilidad tormentaAerea = new Habilidades("Tormenta Aerea", tipoVolador, 130, 70, 5, true);

        Pidgeot.AprenderHabilidad(aereocontrol);
        Pidgeot.AprenderHabilidad(corteAereo);
        Pidgeot.AprenderHabilidad(vientoAullador);
        Pidgeot.AprenderHabilidad(tormentaAerea);

        // SCYTHER
        IHabilidad tajoAereo = new Habilidades("Tajo Aereo", tipoBicho, 80, 100, 15, false);
        IHabilidad danzaDeHojas = new Habilidades("Danza de Hojas", tipoPlanta, 70, 100, 20, false);
        IHabilidad punioDeAcero = new Habilidades("Puño de Acero", tipoBicho, 75, 100, 15, false);
        IHabilidad tormentaBichos = new Habilidades("Tormenta Bichos", tipoBicho, 130, 60, 5, true, envenenado);

        Scyther.AprenderHabilidad(tajoAereo);
        Scyther.AprenderHabilidad(danzaDeHojas);
        Scyther.AprenderHabilidad(punioDeAcero);
        Scyther.AprenderHabilidad(tormentaBichos);


        // AMOONGUSS
        IHabilidad tijeraDeHojas = new Habilidades("Tijera de Hojas", tipoPlanta, 65, 90, 15, false);
        IHabilidad bombardeoDeEsporas = new Habilidades("Bombardeo de Esporas", tipoVeneno, 70, 95, 15, false);
        IHabilidad ataqueVenenoso = new Habilidades("Ataque Venenoso", tipoVeneno, 80, 80, 15, false);
        IHabilidad tormentaVenenosa = new Habilidades("Tormenta Venenosa", tipoVeneno, 130, 60, 5, true, envenenado);

        Amoonguss.AprenderHabilidad(tijeraDeHojas);
        Amoonguss.AprenderHabilidad(bombardeoDeEsporas);
        Amoonguss.AprenderHabilidad(ataqueVenenoso);
        Amoonguss.AprenderHabilidad(tormentaVenenosa);

        // UMBREON
        IHabilidad sombraVil = new Habilidades("Sombra Vil", tipoSiniestro, 90, 80, 10, false);
        IHabilidad punioFuego = new Habilidades("Puño Fuego", tipoFuego, 75, 100, 15, false);
        IHabilidad oscuro = new Habilidades("Oscuro", tipoSiniestro, 80, 100, 15, false);
        IHabilidad mareaOscura = new Habilidades("Marea Oscura", tipoSiniestro, 130, 70, 5, true);

        Umbreon.AprenderHabilidad(sombraVil);
        Umbreon.AprenderHabilidad(punioFuego);
        Umbreon.AprenderHabilidad(oscuro);
        Umbreon.AprenderHabilidad(mareaOscura);

        // GENGAR
        IHabilidad sombraBola = new Habilidades("Bola Sombra", tipoFantasma, 80, 100, 15, false);
        IHabilidad sombraAterradora = new Habilidades("Sombra Aterradora", tipoSiniestro, 75, 100, 15, false);
        IHabilidad punioSiniestro = new Habilidades("Puño Siniestro", tipoSiniestro, 70, 100, 20, false);
        IHabilidad tormentaSombria = new Habilidades("Tormenta Sombria", tipoFantasma, 155, 60, 5, true);

        Gengar.AprenderHabilidad(sombraBola);
        Gengar.AprenderHabilidad(sombraAterradora);
        Gengar.AprenderHabilidad(punioSiniestro);
        Gengar.AprenderHabilidad(tormentaSombria);


        // LAPRAS
        IHabilidad rayoHielo = new Habilidades("Rayo Hielo", tipoHielo, 90, 100, 10, false);
        IHabilidad cascada = new Habilidades("Cascada", tipoAgua, 80, 100, 15, false);
        IHabilidad hipnosis = new Habilidades("Hipnosis", tipoPsiquico, 50, 70, 20, false);
        IHabilidad tormentaDeHielo = new Habilidades("Tormenta de Hielo", tipoHielo, 130, 60, 5, true);

        Lapras.AprenderHabilidad(rayoHielo);
        Lapras.AprenderHabilidad(cascada);
        Lapras.AprenderHabilidad(hipnosis);
        Lapras.AprenderHabilidad(tormentaDeHielo);

        // METAGROSS
        IHabilidad punioAcero = new Habilidades("Puño de Acero", tipoAcero, 90, 90, 10, false);
        IHabilidad poderPsiquico = new Habilidades("Poder Psiquico", tipoPsiquico, 90, 60, 10, false);
        IHabilidad golpePsiquico = new Habilidades("Golpe Psiquico", tipoPsiquico, 40, 100, 15, false);
        IHabilidad meteorito = new Habilidades("Meteorito", tipoAcero, 140, 50, 5, true, noqueado);

        Metagross.AprenderHabilidad(punioAcero);
        Metagross.AprenderHabilidad(poderPsiquico);
        Metagross.AprenderHabilidad(golpePsiquico);
        Metagross.AprenderHabilidad(meteorito);


        // DRAGONITE
        IHabilidad golpeDragon = new Habilidades("Golpe Dragon", tipoDragon, 75, 100, 15, false);
        IHabilidad hiperrayo = new Habilidades("Hiperrayo", tipoNormal, 100, 90, 5, false);
        IHabilidad colasDeFuego = new Habilidades("Colas de Fuego", tipoFuego, 90, 100, 15, false);
        IHabilidad tormentaDeDragones = new Habilidades("Furia Dragon", tipoDragon, 150, 50, 5, true, paralisis);

        Dragonite.AprenderHabilidad(golpeDragon);
        Dragonite.AprenderHabilidad(hiperrayo);
        Dragonite.AprenderHabilidad(colasDeFuego);
        Dragonite.AprenderHabilidad(tormentaDeDragones);

        // SYLVEON
        IHabilidad besoEncantado = new Habilidades("Beso Encantado", tipoHada, 90, 100, 10, false);
        IHabilidad vientoHadas = new Habilidades("Viento Hadas", tipoHada, 75, 100, 15, false);
        IHabilidad golpeHada = new Habilidades("Golpe Hada", tipoHada, 80, 100, 15, false);
        IHabilidad poderDeLosSuenos = new Habilidades("Poder de los Sueños", tipoHada, 130, 60, 5, true);

        Sylveon.AprenderHabilidad(besoEncantado);
        Sylveon.AprenderHabilidad(vientoHadas);
        Sylveon.AprenderHabilidad(golpeHada);
        Sylveon.AprenderHabilidad(poderDeLosSuenos);
        
        return new List<Pokemon> { Sceptile, Arcanine, Blastoise, Snorlax, 
            Pikachu, Jynx, Lucario, Tyranitar, Flygon, Pidgeot, Scyther, Amoonguss, 
            Umbreon, Gengar, Lapras, Metagross, Dragonite, Sylveon };
    }
    
    public string MostrarPokemones()
    {
        string pokemones = "```";
        foreach (Pokemon pokemon in InicializarPokemones())
        {
            pokemones += pokemon.Nombre + ", Tipo: " +
                         pokemon.TipoPrincipal.Nombre + ", HP: " +
                         pokemon.Vida + "\n";
        }
        pokemones += "```";
        return pokemones;
    }
    
}