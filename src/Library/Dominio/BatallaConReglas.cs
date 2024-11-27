namespace program;

public class BatallaConReglas : Batalla
{
    private ReglasPropias reglas;

    public BatallaConReglas(Entrenador jugador1, Entrenador jugador2, ReglasPropias reglas)
        : base(jugador1, jugador2)
    {
        this.reglas = reglas;
    }

    public bool ValidarReglas()
    {
        var entrenadores = JugadoresDisponibles();

        foreach (var entrenador in entrenadores)
        {
            foreach (var pokemon in entrenador.Pokemones)
            {
                if (reglas.PokemonesProhibir.Contains(pokemon.Nombre))
                    return false;

                if (reglas.TiposProhibir.Contains(pokemon.TipoPrincipal.Nombre))
                    return false;
            }
        }

        return true;
    }

    public bool AceptarReglas(Entrenador oponente)
    {
        Console.WriteLine(reglas.MostrarReglas());
        Console.WriteLine($"{oponente.Nombre}, ¿aceptas las reglas? (si/no)");

        string respuesta = Console.ReadLine();
        return respuesta?.ToLower() == "si";
    }

    public string IniciarBatalla_ConReglas()
    {
        var entrenadores = JugadoresDisponibles();
        var oponente = entrenadores.FirstOrDefault(entre => entre != entrenadorActual);

        if (!ValidarReglas())
            return "La batalla no puede comenzar porque no se cumplen las reglas.";

        if (oponente != null && !AceptarReglas(oponente))
            return "El oponente no aceptó las reglas. La batalla fue cancelada.";

        return base.IniciarBatalla();
    }
}
