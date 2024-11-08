using System;
using Library;
using System.Collections.Generic;

class Program
{
    private static List<Entrenador> listaEspera = new List<Entrenador>();
    static void Main(string[] args)
    {
        
    Entrenador entrenador1 = new Entrenador("lolo");
    Entrenador entrenador2 = new Entrenador("pepe");

    Console.WriteLine(entrenador1.UnirseAListaDeEspera(listaEspera));
    Console.WriteLine(entrenador2.UnirseAListaDeEspera(listaEspera));

    

    if (listaEspera.Count >= 2)
    {
        IniciarBatalla();
        
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
            var entrenador2 = listaEspera[0]; 

            
            Batalla batalla = new Batalla(entrenador1, entrenador2);
            Console.WriteLine($"¡Batalla iniciada entre {entrenador1.Nombre} y {entrenador2.Nombre}!");
            Console.WriteLine(batalla.MostrarTurnoActual());

            Console.WriteLine(batalla.CambiarPokemon(entrenador1, entrenador1.Equipo[0]));
            Console.WriteLine(batalla.MostrarTurnoActual());


            Console.WriteLine(batalla.MostrarTurnoActual());
        }
    }
    }
}           