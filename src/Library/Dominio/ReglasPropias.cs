namespace program;

public class ReglasPropias
{
    public List<string> TiposProhibir { get; private set; } // Lista de tipos prohibidos
    public List<string> PokemonesProhibir { get; private set; } // Lista de pokemones prohibidos
    public List<string> ItemsProhibir { get; private set; } // Lista de ítems prohibidos

    public ReglasPropias()
    {
        TiposProhibir = new List<string>();
        PokemonesProhibir = new List<string>();
        ItemsProhibir = new List<string>();
    }

    public void ProhibirTipo(string tipo)
    {
        if (!TiposProhibir.Contains(tipo))
            TiposProhibir.Add(tipo);
    }

    public void ProhibirPokemon(string nombre)
    {
        if (!PokemonesProhibir.Contains(nombre))
            PokemonesProhibir.Add(nombre);
    }

    public void ProhibirItem(string item)
    {
        if (!ItemsProhibir.Contains(item))
            ItemsProhibir.Add(item);
    }

    public string MostrarReglas()
    {
        string reglas = "Reglas Custom:\n";
        reglas += $"- Tipos prohibidos: {string.Join(", ", TiposProhibir)}\n";
        reglas += $"- Pokemones prohibidos: {string.Join(", ", PokemonesProhibir)}\n";
        reglas += $"- Ítems prohibidos: {string.Join(", ", ItemsProhibir)}\n";
        return reglas;
    }

}

