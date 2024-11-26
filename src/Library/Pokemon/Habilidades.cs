namespace program
{
    public class Habilidades : IHabilidad
    {
        public string Nombre { get; set; }
        public int Danio { get; set; }
        public int Precision { get; set; }
        public int Puntos_de_Poder { get; set; }
        public bool EsDobleTurno { get; set; }
        public int Poder { get; set; } 
        public IEfectos Efectos { get; set; }


        public bool EsEspecial { get; set; }


        public Habilidades(string nombre, int danio, bool esDobleTurno, bool esEspecial = false)
        {
            Nombre = nombre;
            Danio = danio;
            EsDobleTurno = esDobleTurno;
            EsEspecial = esEspecial;
            Precision = 100; 
            Puntos_de_Poder = 15; 
        }
    }
}