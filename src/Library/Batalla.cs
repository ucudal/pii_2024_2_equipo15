namespace Library;

public class Batalla
{
    public Entrenador Entrenador1 { get; }
    public Entrenador Entrenador2 { get; }
    private bool turnoEntrenador1;
    public Batalla(Entrenador entrenador1, Entrenador entrenador2)
    {
        Entrenador1 = entrenador1;
        Entrenador2 = entrenador2;
        turnoEntrenador1 = new Random().Next(2) == 0;
    }

    public void CambiarTurno()
    {
        turnoEntrenador1 = !turnoEntrenador1;
    }
    public string CambiarPokemon(Entrenador entrenador, Pokemon nuevoPokemon)
    {
        if (turnoEntrenador1 && entrenador==Entrenador1 || !turnoEntrenador1 && entrenador == Entrenador2)
        {
            entrenador.CambiarPokemonDeEquipo(entrenador.Equipo[0], nuevoPokemon); 
            CambiarTurno();
            return $"el entrenador que tenia el turno ha cambiado de Pokémon y pierde el turno.";
        }
        return "No es tu turno para cambiar de Pokémon.";
    }
    public string MostrarTurnoActual()
    {
        string turnoActual;
        if (turnoEntrenador1)
        {
            turnoActual = Entrenador1.Nombre;
        }
        else
        {
            turnoActual = Entrenador2.Nombre;
        }
        return $"Es el turno de: {turnoActual}";
    }
    public string UsarItem(Entrenador entrenador, string item)
    {
        if (turnoEntrenador1 && entrenador == Entrenador1 || !turnoEntrenador1 && entrenador == Entrenador2)
        {
            CambiarTurno();
            return $"el entrenador que tenia el turno usó un item y pierde el turno.";
        }
        return "No es tu turno para usar un ítem.";
    }
    public void ConocerGanador()
    {
        
    }
    
    public void PokemonDebilitado()
    {
        
    }
    
}