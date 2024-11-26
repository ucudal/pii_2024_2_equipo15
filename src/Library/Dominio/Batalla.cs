namespace Library;

public class Batalla
{
    public Entrenador Entrenador1 { get; }
    public Entrenador Entrenador2 { get; }
    private bool _turno;

    public Batalla(Entrenador entrenador1, Entrenador entrenador2)
    {
        Entrenador1 = entrenador1;
        Entrenador2 = entrenador2;
        _turno = new Random().Next(2) == 0;
        
    }

    public void CambiarTurno()
    {
        _turno = !_turno;
    }

    public string MostrarTurnoActual()
    {
        string turnoActual;
        if (_turno == false)
        {
            turnoActual = Entrenador1.Nombre;
        }
        else
        {
            turnoActual = Entrenador2.Nombre;
        }

        return $"Es el turno de: {turnoActual}";
    }
    public string ConocerGanador()
    {
        {
            bool todosSinSaludEntrenador1 = true;
            bool todosSinSaludEntrenador2 = true;

            foreach (Pokemon pokemon in Entrenador1.Equipo) //Buscar si hay algún pokemon de Entrenador1 que tenga Salud
            {
                if (pokemon.Salud > 0) //Si encontramos un pokemon que su Salud sea mayor que 0, dejamos de buscar
                {
                    todosSinSaludEntrenador1 = false;
                    break;
                }
            }

            foreach (Pokemon pokemon in Entrenador2.Equipo) //Buscar si hay algún pokemon de Entrenador2 que tenga Salud
            {
                if (pokemon.Salud > 0) //Si encontramos un pokemon que su Salud sea mayor que 0, dejamos de buscar
                {
                    todosSinSaludEntrenador2 = false;
                    break;
                }
            }

            if (todosSinSaludEntrenador1) //Si uno de los dos equipos tiene a todos sus pokemons con Salud=0
            {
                return $"El equipo de {Entrenador2.Nombre} ha ganado";
            }
            else if (todosSinSaludEntrenador2)
            {
                return $"El equipo de {Entrenador1.Nombre} ha ganado";
            }

        }
        return null!;
    }

    public string PokemonDebilitado()
    {
        foreach (Pokemon pokemon in Entrenador1.Equipo) //Buscar si hay algún pokemon de Entrenador1 abatido
        {
            if (pokemon.Salud == 0) //Si encontramos un pokemon que su Salud=0, aparece en pantalla
            {
                return $"{pokemon.Nombre} ha sido abatido";
            }
        }

        foreach (Pokemon pokemon in Entrenador2.Equipo) //Buscar si hay algún pokemon de Entrenador2 abatido
        {
            if (pokemon.Salud == 0) //Si encontramos un pokemon que su Salud=0, aparece en pantalla
            {
                return $"{pokemon.Nombre} ha sido abatido";
            }
        }

        return null!;
    }

    public string VerificarEstado(Pokemon pokemon)
    {
            if (pokemon.EstaDormido)
            {
                Random random = new Random(); 
                int chances = random.Next(0,4);
                if (chances >= 4 )
                {
                    return $"{pokemon.Nombre} no ha podido atacar, esta dormido como un tronco";
                }
                pokemon.EstaDormido = false;
                return $"{pokemon.Nombre} se ha despertado y ha realizado su ataque";
            }
            if (pokemon.EstaParalizado)
            {
                Random random = new Random(); 
                int chances = random.Next(0,4);
                if (chances >= 4 )
                {
                    return $"{pokemon.Nombre} esta paralizado y no se ha podido mover";
                }
                pokemon.EstaDormido = false;
                return $"{pokemon.Nombre} se ha librado de la paralisis y ha realizado su ataque";
            } 
            return null!;
    }
}