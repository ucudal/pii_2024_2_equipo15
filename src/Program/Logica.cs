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
    
}