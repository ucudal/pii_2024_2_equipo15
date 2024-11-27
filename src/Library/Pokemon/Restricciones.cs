namespace program;

public class Restricciones
{
    public static List<List<string>> ListaDeRestricciones;
    public static List<string> RestriccionesPokemon;
    public static List<string> RestriccionesTipos;
    public static List<String> RestriccionesItems;
    public static bool AceptacionRestriccion;

    public Restricciones()
    {
        ListaDeRestricciones = new List<List<string>>();
        RestriccionesPokemon = new List<string>();
        RestriccionesTipos = new List<string>();
        RestriccionesItems = new List<String>();
    }

    public string RestringirItems(string nombreObjeto)
    {
        RestriccionesItems.Add(nombreObjeto);
        return $"Se ha agregado el item {nombreObjeto} a los items restringidos para la batalla";
    }

    public string RestringirTipos(string nombreTipo)
    {
        RestriccionesTipos.Add(nombreTipo);
        return $"Se ha agregado el tipo {nombreTipo} a los tipos restringidos para la batalla";
    }

    public string RestringirPokemon(string nombrePokemon)
    {
        RestriccionesPokemon.Add(nombrePokemon);
        return $"Se ha agregado el Pokemon {nombrePokemon} a los pokemon restringidos para la batalla";
    }

    public static string MostrarRestricciones()
    {
        ListaDeRestricciones.Add(RestriccionesTipos);
        ListaDeRestricciones.Add(RestriccionesPokemon);
        ListaDeRestricciones.Add(RestriccionesItems);
        string respuestaFinal = $"------------------------- \n";
        foreach (List<string> listaRestricciones in ListaDeRestricciones)
        {
            respuestaFinal += $"Las {listaRestricciones} son: \n";
            foreach (string restriccion in listaRestricciones)
            {
                respuestaFinal += $" - {restriccion} \n";
            }
        }

        return respuestaFinal;
    }

    public static void AceptarRestricciones(string decision)
    {
        if (decision == "si")
        {
            AceptacionRestriccion = true;
        }

        AceptacionRestriccion = false;
    }

}