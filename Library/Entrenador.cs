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
            return 0 ;
        }

        public void SeleccionarPokemonAlEquipo(Pokemon pokemon)
        {
            

        }

        public void CambiarPokemonDelEquipo(Pokemon pokemon)
        {
            
        }

        public void MostrarEquipo()
        {
            
        }
    }
}
