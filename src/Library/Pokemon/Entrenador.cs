namespace program;

/// <summary>
/// Representa un entrenador de Pokémon que puede participar en batallas.
/// </summary>
public class Entrenador
{
    /// <summary>
    /// Obtiene el nombre del entrenador.
    /// </summary>
    public string Nombre { get; }

    /// <summary>
    /// Lista de Pokémon en posesión del entrenador.
    /// </summary>
    public List<Pokemon> Pokemones { get; }

    /// <summary>
    /// Obtiene o establece el Pokémon actualmente activo en batalla.
    /// </summary>
    public Pokemon? PokemonActivo { get; set; }

    /// <summary>
    /// Indica si el entrenador está participando actualmente en una batalla.
    /// </summary>
    public bool EnBatalla { get; set; }

    /// <summary>
    /// Constructor de la clase Entrenador.
    /// </summary>
    /// <param name="nombre">El nombre del entrenador.</param>
    public Entrenador(string nombre)
    {
        Nombre = nombre;
        Pokemones = new List<Pokemon>();
        EnBatalla = false;
    }

    /// <summary>
    /// Busca un Pokémon en el equipo del entrenador por su nombre.
    /// </summary>
    /// <param name="nombrePokemon">El nombre del Pokémon a buscar.</param>
    /// <returns>El Pokémon encontrado o <c>null</c> si no existe.</returns>
    public Pokemon? ObtenerPokemonPorNombre(string nombrePokemon)
    {
        return Pokemones.Find(p => p.Nombre.Equals(nombrePokemon, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Establece un Pokémon como el Pokémon activo para la batalla.
    /// </summary>
    /// <param name="pokemon">El Pokémon a establecer como activo (opcional).</param>
    /// <returns><c>true</c> si el Pokémon fue establecido como activo; de lo contrario, <c>false</c>.</returns>
    public bool FijarPokemonActual(Pokemon? pokemon = null)
    {
        if (pokemon != null && Pokemones.Contains(pokemon) && pokemon.Vida > 0)
        {
            PokemonActivo = pokemon;
            return true;
        }

        // Si no se especifica un Pokémon, buscar uno vivo
        foreach (var poke in Pokemones)
        {
            if (poke.Vida > 0)
            {
                PokemonActivo = poke;
                return true;
            }
        }

        PokemonActivo = null; // Aseguramos que no haya un Pokémon activo
        return false; // No hay Pokémon vivos
    }

    /// <summary>
    /// Verifica si hay Pokémon vivos en el equipo del entrenador.
    /// </summary>
    /// <returns><c>true</c> si hay Pokémon vivos; de lo contrario, <c>false</c>.</returns>
    public bool TienePokemonesVivos()
    {
        return Pokemones.Any(pokemon => pokemon.Vida > 0);
    }

    /// <summary>
    /// Añade un Pokémon al equipo del entrenador.
    /// </summary>
    /// <param name="pokemon">El Pokémon a añadir.</param>
    /// <returns><c>true</c> si el Pokémon fue añadido exitosamente; de lo contrario, <c>false</c>.</returns>
    /// <remarks>
    /// El equipo tiene un límite de 6 Pokémon. Si ya contiene 6, no se añadirá.
    /// </remarks>
    public bool AñadirPokemon(Pokemon pokemon)
    {
        if (Pokemones.Count >= 6) return false; // Limitar a 6 Pokémon

        if (!Pokemones.Contains(pokemon))
        {
            Pokemones.Add(pokemon);

            // Si no hay Pokémon activo, establecer el primero añadido como activo
            if (PokemonActivo == null)
            {
                PokemonActivo = pokemon;
            }

            return true;
        }

        return false; // El Pokémon ya está en el equipo
    }

    /// <summary>
    /// Devuelve una lista de todos los Pokémon en el equipo del entrenador.
    /// </summary>
    /// <returns>Una lista de objetos <see cref="Pokemon"/> pertenecientes al entrenador.</returns>
    public List<Pokemon> RecibirEquipoPokemon()
    {
        return new List<Pokemon>(Pokemones);
    }
}
