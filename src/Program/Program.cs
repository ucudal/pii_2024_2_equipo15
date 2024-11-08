using System;
using Library;
using System.Collections.Generic;

class Program
{
    static List<Entrenador> listaEspera = new List<Entrenador>();

    static void Main(string[] args)
    {
        Console.WriteLine("Iniciando simulación de batalla Pokémon...");


        var entrenador1 = new Entrenador("Lolo");
        var entrenador2 = new Entrenador("Pepe");
        Console.WriteLine(entrenador1.UnirseAListaDeEspera(listaEspera));
        Console.WriteLine(entrenador2.UnirseAListaDeEspera(listaEspera));


        MostrarListaEspera();

        var ataqueAgua = Logica.HidroBomba;
        var ataqueElectrico = Logica.Impactrueno;
        
        // Usando los Pokémon definidos en la clase lógica
        var blastoise = Logica.Blastoise;
        var pikachu = Logica.Pikachu;
        

        //Mostrar equipos de entrenadores
        Console.WriteLine("Equipo de Lolo:");
        entrenador1.MostrarEquipo();
        Console.WriteLine("Equipo de Pepe:");
        entrenador2.MostrarEquipo();

        //Iniciar batalla si hay al menos 2 entrenadores en lista de espera
        if (listaEspera.Count >= 2)
        {
            IniciarBatalla(entrenador1, entrenador2);
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

    static void IniciarBatalla(Entrenador entrenador1, Entrenador entrenador2)
    {
        Batalla batalla = new Batalla(entrenador1, entrenador2);
        Console.WriteLine($"¡Batalla iniciada entre {entrenador1.Nombre} y {entrenador2.Nombre}!");

        //Mostrar turno actual**
        Console.WriteLine(batalla.MostrarTurnoActual());

        //Simular un ataque
        var atacante = entrenador1;
        var objetivo = entrenador2.Equipo[0];
        var ataque = atacante.Equipo[0].Ataques[0]; // Primer ataque del primer Pokémon
        int dañoRealizado = atacante.Atacar(objetivo, ataque);
        Console.WriteLine($"{atacante.Nombre} atacó con {ataque.Nombre} causando {dañoRealizado} de daño.");

        // Mostrar salud del Pokémon atacado
        Console.WriteLine($"{objetivo.Nombre} ahora tiene {objetivo.MostrarSalud(objetivo)} de salud.");

        //Usar ítem (simulado)
        Console.WriteLine(batalla.UsarItem(atacante, "Poción"));

        //Cambio de Pokémon
        if (atacante.Equipo.Count > 1)
        {
            Console.WriteLine(batalla.CambiarPokemon(atacante, atacante.Equipo[1]));
        }
        else
        {
            Console.WriteLine("No hay Pokémon en el equipo para cambiar.");
        }

        //Cambiar turno
        batalla.CambiarTurno();
        Console.WriteLine(batalla.MostrarTurnoActual());

        //Verificar si hay un Pokémon debilitado
        if (objetivo.Salud == 0)
        {
            Console.WriteLine($"{objetivo.Nombre} se ha debilitado.");
        }
    }
}