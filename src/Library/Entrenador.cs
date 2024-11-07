namespace Library
{
    public class Entrenador
    {
        public string Nombre { get; set; }              
        public List<Pokemon> Equipo { get; set; }      

        public Entrenador(string nombre)
        {
            Nombre = nombre;
            Equipo = new List<Pokemon>();              
        }

        public int Atacar(IPokemon objetivo, IAtaque ataque)
        {
            //RECORDAR QUE LOS ATAQUES ESPECIALES SE PUEDEN SELECCIONAR CADA DOS TURNOS
            return 0 ;
        }

        public void MostrarPokemon()
        {
            foreach (Pokemon pokemon in Equipo)
            {
                Console.WriteLine(pokemon);
            }
        }

        public string AgregarPokemonAlEquipo(Pokemon pokemon)
        {
            int cantidad = Equipo.Count;
            if (cantidad < 6)
            {
                Equipo.Add(pokemon);
                return $"¡Se ha agragado a {pokemon.Nombre} al equipo!";
            }
            return $"No se puede agregar a {pokemon.Nombre} al equipo, este ya está completo.";
        }

        public string CambiarPokemonDeEquipo(Pokemon pokemonEnEquipo, Pokemon pokemonQueEntra)
        {
            if (pokemonEnEquipo == pokemonQueEntra)
            {
                return $"Se quiere cambiar al mismo pokemon";
            }
            int cantidad = Equipo.Count; 
            for (int i = 0; i < cantidad; i++)
            {
                if (Equipo[i] == pokemonEnEquipo)
                {
                    Equipo[i] = pokemonQueEntra;
                    return $"Se ha cambiado a {pokemonEnEquipo.Nombre} por {pokemonQueEntra.Nombre}";
                }
            }

            return $"{pokemonEnEquipo.Nombre} no está en el equipo";
        }

        public void MostrarEquipo()
        {
            
        }
    }
}