namespace program
{
    public class Prohibiciones
    {
        public List<string> PokemonesProhibidos { get; private set; }
        public List<string> TiposProhibidos { get; private set; }
        public List<string> ItemsProhibidos { get; private set; }
        public Prohibiciones()
        {
            PokemonesProhibidos = new List<string>();
            TiposProhibidos = new List<string>();
            ItemsProhibidos = new List<string>();
        }

        public string ProhibirPokemon(string pokemon)
        {
            if (!PokemonesProhibidos.Contains(pokemon))
            {
                PokemonesProhibidos.Add(pokemon);
                return "El Pokémon ha sido prohibido.";
            }
            return "El Pokémon ya estaba prohibido.";
        }
        public string ProhibirTipo(string tipo)
        {
            if (!TiposProhibidos.Contains(tipo))
            {
                TiposProhibidos.Add(tipo);
                return "El tipo ha sido prohibido.";
            }
            return "El tipo ya estaba prohibido.";
        }
        public string ProhibirItem(string item)
        {
            if (!ItemsProhibidos.Contains(item))
            {
                ItemsProhibidos.Add(item);
                return "El ítem ha sido prohibido.";
            }
            return "El ítem ya estaba prohibido.";
        }
    }
}