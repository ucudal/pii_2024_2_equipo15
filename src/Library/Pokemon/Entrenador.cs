namespace program;

public class Entrenador
{
    public string Nombre { get; }
    public List<Pokemon> Pokemones { get; }
    public int CantidadDePokemones
    {
        get { return Pokemones.Count; }
    }
    public Pokemon PokemonActivo { get; set; }

    public bool EnBatalla { get; set; }

    public Entrenador(string nombre)
    {
        Nombre = nombre;
        Pokemones = new List<Pokemon>();
        EnBatalla = false;
    }

    public bool BuscarPokemon(string nombrePokemon)
    {
        foreach (Pokemon pokemon in Pokemones)
        {
            if (pokemon.Nombre == nombrePokemon)
            {
                return true;
            }
        }
        return false;
    }

    public Pokemon? BuscarPokemonYGuardar(string nombrePokemon)
    {
        foreach (Pokemon pokemon in Pokemones)
        {
            if (pokemon.Nombre == nombrePokemon)
            {
                return pokemon;
            }
        }
        return null;
    }

    public bool FijarPokemonActual(Pokemon? pokemon = null)
    {
        if (pokemon != null)
        {
            if (pokemon.Vida > 0)
            {
                PokemonActivo = pokemon;
                return true;
            }
            return false;
        }
        else
        {
            foreach (Pokemon poke in Pokemones)
            {
                if (poke.Vida > 0)
                {
                    PokemonActivo = poke;
                    return true;
                }
            }
        }
        return false;
    }

    public List<Pokemon> RecibirEquipoPokemon()
    {
        return Pokemones;
    }

    public bool TienePokemonesVivos()
    {
        return Pokemones.Any(pokemon => pokemon.Vida > 0);
    }

    public bool AñadirPokemon(Pokemon pokemon)
    {
        if (Pokemones.Count < 6)
        {
            if (!Pokemones.Contains(pokemon))
            {
                if (Pokemones.Count == 0)
                {
                    FijarPokemonActual(pokemon);
                }
                Pokemones.Add(pokemon);
                return true;
            }
        }
        return false;
    }
}
