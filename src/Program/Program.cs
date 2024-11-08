using System;
using System.Collections.Generic;

class Program
{
    static List<Entrenador> listaEspera = new List<Entrenador>();

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Ejemplo: Crear entrenadores y unirse a la lista de espera
        Entrenador entrenador1 = new Entrenador("Ash");
        Entrenador entrenador2 = new Entrenador("Gary");

        Console.WriteLine(entrenador1.UnirseAListaDeEspera(listaEspera));
        Console.WriteLine(entrenador2.UnirseAListaDeEspera(listaEspera));

        // Mostrar lista de espera
        MostrarListaEspera();

        // Iniciar batalla si hay dos jugadores en la lista de espera
        if (listaEspera.Count >= 2)
        {
            IniciarBatalla();
        }
    }

    static void MostrarListaEspera()
    {
        Console.WriteLine("--- Jugadores en espera ---");
        foreach (var entrenador in listaEspera)
        {
            Console.WriteLine(entrenador.Nombre);
        }
    }
    static void IniciarBatalla()
    {
        var entrenador1 = listaEspera[0];
        var entrenador2 = listaEspera[1];
        listaEspera.RemoveRange(0, 2);

        Batalla batalla = new Batalla(entrenador1, entrenador2);
        Console.WriteLine($"¡Batalla iniciada entre {entrenador1.Nombre} y {entrenador2.Nombre}!");
    }
}