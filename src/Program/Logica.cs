//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------

using Library;

public class bLogica
{

    //--------------------------------------------------------------------------------
    //     A continuación se instancian todos los tipos disponibles
    //--------------------------------------------------------------------------------

    
    private static Tipos Agua = new Tipos("Agua"); //Creamos un tipo llamado Agua
    private static Tipos Bicho = new Tipos("Bicho"); //Creamos un tipo llamado Bicho
    private static Tipos Dragon = new Tipos("Dragon"); //Creamos un tipo llamado Dragon    
    private static Tipos Electrico = new Tipos("Electrico"); //Creamos un tipo llamado Electrico    
    private static Tipos Fantasma = new Tipos("Fantasma"); //Creamos un tipo llamado Fantasma  
    private static Tipos Fuego = new Tipos("Fuego"); //Creamos un tipo llamado Fuego    
    private static Tipos Hielo = new Tipos("Hielo"); //Creamos un tipo llamado Hielo    
    private static Tipos Lucha = new Tipos("Lucha"); //Creamos un tipo llamado Lucha    
    private static Tipos Normal = new Tipos("Normal"); //Creamos un tipo llamado Normal    
    private static Tipos Planta = new Tipos("Planta"); //Creamos un tipo llamado Planta    
    private static Tipos Roca = new Tipos("Roca"); //Creamos un tipo llamado Roca    
    private static Tipos Tierra = new Tipos("Tierra"); //Creamos un tipo llamado Tierra    
    private static Tipos Veneno = new Tipos("Veneno"); //Creamos un tipo llamado Veneno    
    private static Tipos Volador = new Tipos("Volador"); //Creamos un tipo llamado Volador    
    
    //--------------------------------------------------------------------------------
    //     A continuación se instancian todos los ataques disponibles
    //--------------------------------------------------------------------------------
    
    private static Ataques Placaje = new Ataques("Placaje", 40, Normal); //Creamos un ataque llamado Placaje
    private static Ataques Hiperrayo = new Ataques("Hiperrayo", 150, Normal); //Creamos un ataque llamado Hiperrayo
    private static Ataques Lanzallamas = new Ataques("Lanzallamas", 90, Fuego); //Creamos un ataque llamado Lanzallamas
    private static Ataques Ascuas = new Ataques("Ascuas", 40, Fuego); //Creamos un ataque llamado Ascuas
    private static Ataques RayoBurubuja = new Ataques("Rayo Burbuja", 65, Agua); //Creamos un ataque llamado Rayo Burbuja
    private static Ataques Surf = new Ataques("Surf", 90, Agua); //Creamos un ataque llamado Surf
    private static Ataques HojaAfilada = new Ataques("Hoja Afilada", 55, Planta); //Creamos un ataque llamado Hoja Afilada
    private static Ataques RayoSolar = new Ataques("Rayo Solar", 120, Planta); //Creamos un ataque llamado Rayo Solar
    private static Ataques Trueno = new Ataques("Trueno", 110, Electrico); //Creamos un ataque llamado Trueno
    private static Ataques Chispazo = new Ataques("Chispazo", 65, Electrico); //Creamos un ataque llamado Chispazo
    private static Ataques Terremoto = new Ataques("Terremoto", 100, Tierra); //Creamos un ataque llamado Terremoto
    private static Ataques DisparoLodo = new Ataques("Disparo Lodo", 55, Tierra); //Creamos un ataque llamado Disparo Lodo
    private static Ataques AlaDeAcero = new Ataques("Ala de Acero", 70, Volador); //Creamos un ataque llamado Ala de Acero
    private static Ataques Tornado = new Ataques("Tornado", 40, Volador); //Creamos un ataque llamado Tornado
    private static Ataques CorteNoche = new Ataques("Corte Noche", 70, Normal); //Creamos un ataque llamado Corte Noche
    private static Ataques Triturar = new Ataques("Triturar", 80, Normal); //Creamos un ataque llamado Triturar
    private static Ataques LanzaMugre = new Ataques("Lanza Mugre", 65, Veneno); //Creamos un ataque llamado Lanza Mugre
    private static Ataques BombaLodo = new Ataques("Bomba Lodo", 90, Veneno); //Creamos un ataque llamado Bomba Lodo
    private static Ataques RocaAfilada = new Ataques("Roca Afilada", 100, Roca); //Creamos un ataque llamado Roca Afilada
    private static Ataques Avalancha = new Ataques("Avalancha", 75, Roca); //Creamos un ataque llamado Avalancha
    private static Ataques ColaFerrea = new Ataques("Cola Ferrea", 100, Dragon); //Creamos un ataque llamado Cola Ferrea
    private static Ataques CabezaDeHierro = new Ataques("Cabeza de Hierro", 80, Roca); //Creamos un ataque llamado Cabeza de Hierro
    private static Ataques GarraDragon = new Ataques("Garra Dragon", 80, Dragon); //Creamos un ataque llamado Garra Dragon
    private static Ataques CometaDraco = new Ataques("Cometa Draco", 130, Dragon); //Creamos un ataque llamado Cometa Draco
    private static Ataques PuñoHielo = new Ataques("Puño Hielo", 75, Hielo); //Creamos un ataque llamado Puño Hielo
    private static Ataques RayoHielo = new Ataques("Rayo Hielo", 90, Hielo); //Creamos un ataque llamado Rayo Hielo
    private static Ataques SombraVil = new Ataques("Sombra Vil", 40, Fantasma); //Creamos un ataque llamado Sombra Vil
    private static Ataques BolaSombra = new Ataques("Bola Sombra", 80, Fantasma); //Creamos un ataque llamado Bola Sombra
    private static Ataques ABocajarro = new Ataques("A Bocajarro", 120, Lucha); //Creamos un ataque llamado A Bocajarro
    private static Ataques DanzaPetalo = new Ataques("Danza Petalo", 120, Planta); //Creamos un ataque llamado Danza Petalo
    private static Ataques Ventisca = new Ataques("Ventisca", 110, Hielo); //Creamos un ataque llamado Ventisca
    private static Ataques HidroBomba = new Ataques("Hidro Bomba", 110, Agua); //Creamos un ataque llamado Hidro Bomba
    private static Ataques Impactrueno = new Ataques("Impactureno", 40,Electrico); //Creamos un ataque llamado Impactrueno
    private static Ataques Picotazo = new Ataques("Picotazo", 35, Volador); //Creamos un ataque llamado Picotazo
    private static Ataques Garraumbria = new Ataques("Garra Umbria", 60, Bicho); //Creamos un ataque llamado Garra Umbria
    private static Ataques GolpeMordaza = new Ataques("Golpe Mordaza", 90, Bicho); //Creamos un ataque llamado Golpe Mordaza
    
    //--------------------------------------------------------------------------------
    //     A continuación se instancian todos los pokemon disponibles
    //--------------------------------------------------------------------------------

    private static Pokemon Blastoise = new Pokemon("Blastoise", Agua, 268);
    private static Pokemon Arbok = new Pokemon("Arbok", Veneno, 230);
    private static Pokemon Pikachu = new Pokemon("Pikachu", Electrico, 180);
    private static Pokemon Sandslash = new Pokemon("Sandslash", Tierra, 260);
    private static Pokemon Ninetales = new Pokemon("Ninetales", Fuego, 256);
    private static Pokemon Persian = new Pokemon("Persian", Normal, 240);
    private static Pokemon Dragonair = new Pokemon("Dragonair", Dragon, 232);
    private static Pokemon Meganium = new Pokemon("Meganium", Planta, 270);
    private static Pokemon Misdreavus = new Pokemon("Misdreavus", Fantasma, 230);
    private static Pokemon Hariyama = new Pokemon("Hariyama", Lucha, 398);
    private static Pokemon Nosepass = new Pokemon("Nosepass", Roca, 170);
    private static Pokemon Glaceon = new Pokemon("Glaceon", Hielo, 240);
    private static Pokemon Accelgor = new Pokemon("Accelgor", Bicho, 270);
    private static Pokemon Tornadus = new Pokemon("Tornadus", Volador, 268);
    private static Pokemon Samurott = new Pokemon("Samurott", Agua, 300);
    private static Pokemon Weezing = new Pokemon("Weezing", Veneno, 240);
    private static Pokemon Ampharos = new Pokemon("Ampharos", Electrico, 290);
    private static Pokemon Donphan = new Pokemon("Donphan", Tierra, 290);
    private static Pokemon Darmanitan = new Pokemon("Darmanitan", Fuego, 320);
    private static Pokemon Snorlax = new Pokemon("Snorlaz", Normal, 430);
    private static Pokemon Goodra = new Pokemon("Goodra", Dragon, 290);
    private static Pokemon Sceptile = new Pokemon("Sceptile", Planta, 250);
    private static Pokemon Mismagius = new Pokemon("Mismagius", Fantasma, 230);
    private static Pokemon Passimian = new Pokemon("Passimian", Lucha, 310);
    private static Pokemon Rampardos = new Pokemon("Rampardos", Roca, 304);
    private static Pokemon Beartic = new Pokemon("Beartic", Hielo, 300);
    private static Pokemon Pinsir = new Pokemon("Pinsir", Bicho, 240);
    private static Pokemon Pidgeotto = new Pokemon("Pidgeotto", Volador, 236);
    
    
    
    

}