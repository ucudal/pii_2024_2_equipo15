namespace program
{
    public class Pokemon : IPokemon
    {
        public string Nombre { get; }
        public int Vida { get; set; }
        public int VidaBase { get; set; }
        public int Velocidad { get; set; } // Propiedad Velocidad
        public int Ataque { get; set; } // Propiedad Ataque
        public int Defensa { get; set; } // Propiedad Defensa
        public List<IHabilidad> Habilidades { get; }
        public ITipo TipoPrincipal { get; }
        public ITipo TipoSecundario { get; }
        public IHabilidad HabilidadCargando { get; set; }
        public string Estado { get; set; }

        public Pokemon(string nombre, int vida, ITipo tipoPrincipal, ITipo tipoSecundario = null, string estado = null, int velocidad = 100, int ataque = 50, int defensa = 50)
        {
            Nombre = nombre;
            Vida = vida;
            VidaBase = Vida;
            Velocidad = velocidad; // Inicializamos la velocidad
            Ataque = ataque; // Inicializamos el ataque
            Defensa = defensa; // Inicializamos la defensa
            TipoPrincipal = tipoPrincipal;
            TipoSecundario = tipoSecundario;
            Habilidades = new List<IHabilidad>();
            HabilidadCargando = null;
            Estado = estado;
        }

        // Método para que el Pokémon aprenda una nueva habilidad
        public void AprenderHabilidad(IHabilidad habilidad)
        {
            Habilidades.Add(habilidad);
        }

        // Método para mostrar todas las habilidades del Pokémon
        public string MostrarHabilidades()
        {
            string resultado = "";

            for (int i = 0; i < Habilidades.Count; i++)
            {
                var habilidad = Habilidades[i];
                resultado += $"**{i + 1}. {habilidad.Nombre}** | Daño: {habilidad.Danio} | Precisión: {habilidad.Precision} | Tipo: {habilidad.Tipo.Nombre} | PP: {habilidad.Puntos_de_Poder} | Ataque Cargado: *{habilidad.EsDobleTurno}*\n";
            }

            return resultado;
        }

        // Método para obtener una habilidad por nombre
        public IHabilidad? ObtenerHabilidad(string nombreHabilidad)
        {
            return Habilidades.FirstOrDefault(habilidad => habilidad.Nombre.Equals(nombreHabilidad, StringComparison.OrdinalIgnoreCase));
        }
    }
}
