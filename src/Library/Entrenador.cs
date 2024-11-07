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
            int efectividadObjetivo= ataque.Tipo.efectividadDeDaño(objetivo.Tipo);  // Calcula la efectividad del tipo del ataque en relación con el tipo del objetivo
            int dañoTotal = (int)(ataque.Daño * efectividadObjetivo); //Cálculo del daño del ataque aumentado con la efectividad del tipo
            objetivo.recibirDaño(dañoTotal); //Realiza el ataque restándole salud al objetivo

            return dañoTotal;
        }

        public void MostrarPokemon()
        {
            foreach (Pokemon pokemon in Equipo)
            {
                Console.WriteLine(pokemon);
            }
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