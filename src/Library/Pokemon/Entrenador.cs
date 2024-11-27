namespace program
{
    public class Entrenador
    {
        public string Nombre { get; }
        public List<Pokemon> Pokemones { get; }
        public Pokemon? PokemonActivo { get; set; }
        public bool EnBatalla { get; set; }

        public Entrenador(string nombre)
        {
            Nombre = nombre;
            Pokemones = new List<Pokemon>();
            EnBatalla = false;
        }

        // Buscar un Pokémon por su nombre
        public Pokemon? ObtenerPokemonPorNombre(string nombrePokemon)
        {
            return Pokemones.Find(p => p.Nombre.Equals(nombrePokemon, StringComparison.OrdinalIgnoreCase));
        }

        

        // Verificar si hay Pokémon vivos en el equipo
        public bool TienePokemonesVivos()
        {
            return Pokemones.Any(pokemon => pokemon.Vida > 0);
        }

        // Añadir un Pokémon al equipo del entrenador (máximo 6)
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

        // Devolver una lista de todos los Pokémon del entrenador
        public List<Pokemon> RecibirEquipoPokemon()
        {
            return new List<Pokemon>(Pokemones);
        }
    }
}
