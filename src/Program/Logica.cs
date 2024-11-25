//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------

using Library;

public class Logica
{
    //--------------------------------------------------------------------------------
    //     A continuación se instancian todos los tipos disponibles
    //--------------------------------------------------------------------------------

    
    public static Tipos Agua = new Tipos("Agua"); //Creamos un tipo llamado Agua
    public static Tipos Bicho = new Tipos("Bicho"); //Creamos un tipo llamado Bicho
    public static Tipos Dragon = new Tipos("Dragon"); //Creamos un tipo llamado Dragon    
    public static Tipos Electrico = new Tipos("Electrico"); //Creamos un tipo llamado Electrico    
    public static Tipos Fantasma = new Tipos("Fantasma"); //Creamos un tipo llamado Fantasma  
    public static Tipos Fuego = new Tipos("Fuego"); //Creamos un tipo llamado Fuego    
    public static Tipos Hielo = new Tipos("Hielo"); //Creamos un tipo llamado Hielo    
    public static Tipos Lucha = new Tipos("Lucha"); //Creamos un tipo llamado Lucha    
    public static Tipos Normal = new Tipos("Normal"); //Creamos un tipo llamado Normal    
    public static Tipos Planta = new Tipos("Planta"); //Creamos un tipo llamado Planta    
    public static Tipos Roca = new Tipos("Roca"); //Creamos un tipo llamado Roca    
    public static Tipos Tierra = new Tipos("Tierra"); //Creamos un tipo llamado Tierra    
    public static Tipos Veneno = new Tipos("Veneno"); //Creamos un tipo llamado Veneno    
    public static Tipos Volador = new Tipos("Volador"); //Creamos un tipo llamado Volador    
    public static Tipos Psiquico = new Tipos("Psiquico"); //Creamos un tipo llamado Psiquico
    
    //--------------------------------------------------------------------------------
    //     A continuación se instancian todos los ataques disponibles
    //--------------------------------------------------------------------------------
    
    // Ataques de Tipo Normal
    public static Ataques Placaje = new Ataques("Placaje", 40, Normal, true);
    public static Ataques Hiperrayo = new Ataques("Hiperrayo", 150, Normal, false);
    public static Ataques CorteNoche = new Ataques("Corte Noche", 70, Normal, true);
    public static Ataques Triturar = new Ataques("Triturar", 80, Normal, true);

    // Ataques de Tipo Fuego
    public static Ataques Lanzallamas = new Ataques("Lanzallamas", 90, Fuego, true);
    public static Ataques Ascuas = new Ataques("Ascuas", 40, Fuego, false);

    // Ataques de Tipo Agua
    public static Ataques RayoBurubuja = new Ataques("Rayo Burbuja", 65, Agua, true);
    public static Ataques Surf = new Ataques("Surf", 90, Agua, true);
    public static Ataques HidroBomba = new Ataques("Hidro Bomba", 110, Agua, false);

    // Ataques de Tipo Planta
    public static Ataques HojaAfilada = new Ataques("Hoja Afilada", 55, Planta, true);
    public static Ataques RayoSolar = new Ataques("Rayo Solar", 120, Planta, false);
    public static Ataques DanzaPetalo = new Ataques("Danza Petalo", 120, Planta, false);

    // Ataques de Tipo Eléctrico
    public static Ataques Trueno = new Ataques("Trueno", 110, Electrico, true);
    public static Ataques Chispazo = new Ataques("Chispazo", 65, Electrico, false);
    public static Ataques Impactrueno = new Ataques("Impactureno", 40, Electrico, true);

    // Ataques de Tipo Tierra
    public static Ataques Terremoto = new Ataques("Terremoto", 100, Tierra, true);
    public static Ataques DisparoLodo = new Ataques("Disparo Lodo", 55, Tierra, true);

    // Ataques de Tipo Volador
    public static Ataques AlaDeAcero = new Ataques("Ala de Acero", 70, Volador, false);
    public static Ataques Tornado = new Ataques("Tornado", 40, Volador, true);
    public static Ataques Picotazo = new Ataques("Picotazo", 35, Volador, false);

    // Ataques de Tipo Veneno
    public static Ataques LanzaMugre = new Ataques("Lanza Mugre", 65, Veneno, false);
    public static Ataques BombaLodo = new Ataques("Bomba Lodo", 90, Veneno, false);

    // Ataques de Tipo Roca
    public static Ataques RocaAfilada = new Ataques("Roca Afilada", 100, Roca, false);
    public static Ataques Avalancha = new Ataques("Avalancha", 75, Roca, false);
    public static Ataques CabezaDeHierro = new Ataques("Cabeza de Hierro", 80, Roca, false);

    // Ataques de Tipo Dragón
    public static Ataques ColaFerrea = new Ataques("Cola Ferrea", 100, Dragon, false);
    public static Ataques GarraDragon = new Ataques("Garra Dragon", 80, Dragon, false);
    public static Ataques CometaDraco = new Ataques("Cometa Draco", 130, Dragon, true);

    // Ataques de Tipo Hielo
    public static Ataques PuñoHielo = new Ataques("Puño Hielo", 75, Hielo, false);
    public static Ataques RayoHielo = new Ataques("Rayo Hielo", 90, Hielo, false);
    public static Ataques Ventisca = new Ataques("Ventisca", 110, Hielo, false);
    public static Ataques Congelado = new Ataques("Congelado", 90, Hielo, false);

    // Ataques de Tipo Fantasma
    public static Ataques SombraVil = new Ataques("Sombra Vil", 40, Fantasma, true);
    public static Ataques BolaSombra = new Ataques("Bola Sombra", 80, Fantasma, false);

    // Ataques de Tipo Lucha
    public static Ataques ABocajarro = new Ataques("A Bocajarro", 120, Lucha, true);

    // Ataques de Tipo Bicho
    public static Ataques Garraumbria = new Ataques("Garra Umbria", 60, Bicho, false);
    public static Ataques GolpeMordaza = new Ataques("Golpe Mordaza", 90, Bicho, false);

    // Ataques de Tipo Psíquico
    public static Ataques Confusion = new Ataques("Confusión", 50, Psiquico, true);
    public static Ataques Psicorayo = new Ataques("Psicorayo", 65, Psiquico, false);
    
    //--------------------------------------------------------------------------------
    //     A continuación se instancian todos los pokemon disponibles
    //--------------------------------------------------------------------------------

    public static Pokemon Blastoise = new Pokemon("Blastoise", Agua, 268);
    public static Pokemon Arbok = new Pokemon("Arbok", Veneno, 230);
    public static Pokemon Pikachu = new Pokemon("Pikachu", Electrico, 180);
    public static Pokemon Sandslash = new Pokemon("Sandslash", Tierra, 260);
    public static Pokemon Ninetales = new Pokemon("Ninetales", Fuego, 256);
    public static Pokemon Persian = new Pokemon("Persian", Normal, 240);
    public static Pokemon Dragonair = new Pokemon("Dragonair", Dragon, 232);
    public static Pokemon Meganium = new Pokemon("Meganium", Planta, 270);
    public static Pokemon Misdreavus = new Pokemon("Misdreavus", Fantasma, 230);
    public static Pokemon Hariyama = new Pokemon("Hariyama", Lucha, 398);
    public static Pokemon Nosepass = new Pokemon("Nosepass", Roca, 170);
    public static Pokemon Glaceon = new Pokemon("Glaceon", Hielo, 240);
    public static Pokemon Accelgor = new Pokemon("Accelgor", Bicho, 270);
    public static Pokemon Tornadus = new Pokemon("Tornadus", Volador, 268);
    public static Pokemon Samurott = new Pokemon("Samurott", Agua, 300);
    public static Pokemon Weezing = new Pokemon("Weezing", Veneno, 240);
    public static Pokemon Ampharos = new Pokemon("Ampharos", Electrico, 290);
    public static Pokemon Donphan = new Pokemon("Donphan", Tierra, 290);
    public static Pokemon Darmanitan = new Pokemon("Darmanitan", Fuego, 320);
    public static Pokemon Snorlax = new Pokemon("Snorlaz", Normal, 430);
    public static Pokemon Goodra = new Pokemon("Goodra", Dragon, 290);
    public static Pokemon Sceptile = new Pokemon("Sceptile", Planta, 250);
    public static Pokemon Mismagius = new Pokemon("Mismagius", Fantasma, 230);
    public static Pokemon Passimian = new Pokemon("Passimian", Lucha, 310);
    public static Pokemon Rampardos = new Pokemon("Rampardos", Roca, 304);
    public static Pokemon Beartic = new Pokemon("Beartic", Hielo, 300);
    public static Pokemon Pinsir = new Pokemon("Pinsir", Bicho, 240);
    public static Pokemon Hypno = new Pokemon("Hypno", Psiquico, 220);
    public static Pokemon Pidgeotto = new Pokemon("Pidgeotto", Volador, 236);
    public static Pokemon Mewtwo = new Pokemon("Mewtwo", Psiquico, 305);
    public static Pokemon Charmnder = new Pokemon("Charmander", Fuego, 100);
    
    
    
    

}