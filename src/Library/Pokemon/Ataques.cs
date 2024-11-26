namespace program
{
    public class Ataques : IHabilidad
    {
        public string Nombre { get; set; }
        public ITipo Tipo { get; set; }
        public int Danio { get; set; }
        public int Poder { get; set; } // Implementamos la propiedad Poder
        public int Precision { get; set; } = 100; // Precisión por defecto
        public int Puntos_de_Poder { get; set; } = 15; // PP por defecto
        public bool EsDobleTurno { get; set; } = false; // Por defecto, no es un ataque de doble turno
        public IEfectos? Efectos { get; set; } // Los efectos son opcionales

        public Ataques(string nombre, int danio, ITipo tipo, bool esFisico)
        {
            Nombre = nombre;
            Danio = danio;
            Tipo = tipo;
            EsDobleTurno = esFisico;
            Poder = danio; // Asumimos que el Poder equivale al daño del ataque
        }
    }
}