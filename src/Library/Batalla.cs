namespace Library;

public class Batalla
{
    public Entrenador Entrenador1 { get; }
    public Entrenador Entrenador2 { get; }

    public Batalla(Entrenador entrenador1, Entrenador entrenador2)
    {
        Entrenador1 = entrenador1;
        Entrenador2 = entrenador2;
    }

    public void CambiarTurno()
    {
        
    }
    
    public void ConocerGanador()
    {
        {
            bool TodosSinSaludEntrenador1 = true;
            bool TodosSinSaludEntrenador2 = true;

            foreach (Pokemon pokemon in Entrenador1.Equipo)  //Buscar si hay algún pokemon de Entrenador1 que tenga Salud
            {
                if (pokemon.Salud > 0)  //Si encontramos un pokemon que su Ssalud sea mayor que 0
                {
                    TodosSinSaludEntrenador1 = false;
                    break; 
                }
            }

            foreach (var pokemon in Entrenador2.Equipo) //Buscar si hay algún pokemon de Entrenador2 que tenga Salud
            {
                if (pokemon.Salud > 0) //Si encontramos un pokemon que su Salud sea mayor que 0
                {
                    TodosSinSaludEntrenador2 = false;
                    break;  
                }
            }

            if (TodosSinSaludEntrenador1) //Si uno de los dos equipos tiene a todos sus pokemons con Salud=0
            {
                Console.WriteLine( $"El equipo de {Entrenador2.Nombre} ha ganado"); 
            }
            else if (TodosSinSaludEntrenador2)
            {
                Console.WriteLine($"El equipo de {Entrenador1.Nombre} ha ganado"); 
            }
            
        }

    }
    public void PokemonDebilitado()
    {
        
    }
    
}