namespace program
{
    public class Pokemon : IPokemon
    {
        public string Nombre { get; }
        public int Vida { get; set; }
        public int VidaBase { get; set; }
        public int Velocidad { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        public List<IHabilidad> Habilidades { get; }
        public ITipo TipoPrincipal { get; }
        public IHabilidad HabilidadCargando { get; set; }
        public string Estado { get; set; } // Estado actual (paralizado, dormido, etc.)
        public int DuracionEstado { get; set; } // Duración restante del estado especial

        public Pokemon(string nombre, int vida, int velocidad, int ataque, int defensa, string estado = null)
        {
            Nombre = nombre;
            Vida = vida;
            VidaBase = vida;
            Velocidad = velocidad;
            Ataque = ataque;
            Defensa = defensa;
            Habilidades = new List<IHabilidad>();
            HabilidadCargando = null;
            Estado = estado;
            DuracionEstado = 0; // Por defecto, sin estado especial
        }

        public void AprenderHabilidad(IHabilidad habilidad)
        {
            Habilidades.Add(habilidad);
        }

        public string MostrarHabilidades()
        {
            string resultado = "";

            for (int i = 0; i < Habilidades.Count; i++)
            {
                var habilidad = Habilidades[i];
                resultado += $"**{i + 1}. {habilidad.Nombre}** | Daño: {habilidad.Danio} | Precisión: {habilidad.Precision} | PP: {habilidad.Puntos_de_Poder} | Ataque Cargado: *{habilidad.EsDobleTurno}*\n";
            }

            return resultado;
        }

        public IHabilidad? ObtenerHabilidad(string nombreHabilidad)
        {
            return Habilidades.FirstOrDefault(habilidad => habilidad.Nombre.Equals(nombreHabilidad, StringComparison.OrdinalIgnoreCase));
        }
    }
}