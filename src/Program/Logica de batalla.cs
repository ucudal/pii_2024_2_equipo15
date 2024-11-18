using System;
using Library;
using System.Collections.Generic;

class LogicaDeBatlla
{
    private static List<Entrenador> listaEspera = new List<Entrenador>();
    static void Main(string[] args)
    {
        Console.WriteLine("Iniciando simulación de batalla Pokémon...");


        var entrenador1 = new Entrenador("Lolo");
        var entrenador2 = new Entrenador("Pepe");
        Console.WriteLine(entrenador1.UnirseAListaDeEspera(listaEspera));
        Console.WriteLine(entrenador2.UnirseAListaDeEspera(listaEspera));

    

        var ataqueAgua = Logica.HidroBomba;
        var ataqueElectrico = Logica.Impactrueno;
        
        // Usando los Pokémon definidos en la clase lógica
        var blastoise = Logica.Blastoise;
        var pikachu = Logica.Pikachu;
        

        //Mostrar equipos de entrenadores
        Console.WriteLine("Equipo de Lolo:");
        entrenador1.MostrarPokemon();
        Console.WriteLine("Equipo de Pepe:");
        entrenador2.MostrarPokemon();

        //Iniciar batalla si hay al menos 2 entrenadores en lista de espera
        if (listaEspera.Count >= 2)
        {
            IniciarBatalla();
        }
    }

    static void MostrarListaEspera()
    {
        Console.WriteLine("-Jugadores en espera-");
        foreach (var entrenador in listaEspera)
        {
            Console.WriteLine(entrenador.Nombre);
        }
    }

        static void IniciarBatalla()
        {
            var entrenador1 = listaEspera[0]; 
            var entrenador2 = listaEspera[1]; 

            
            Batalla batalla = new Batalla(entrenador1, entrenador2);
            Console.WriteLine($"¡Batalla iniciada entre {entrenador1.Nombre} y {entrenador2.Nombre}!");
            Console.WriteLine(batalla.MostrarTurnoActual());
            Console.WriteLine(batalla.MostrarTurnoActual());


            Console.WriteLine(batalla.MostrarTurnoActual());
        }
    }
