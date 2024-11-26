namespace program;

public interface IHabilidad
{
    string Nombre { set; get; }
    ITipo Tipo { set; get; }
    int Danio { set; get; }
    int Precision { get; set; }
    int Puntos_de_Poder { get; set; }
    bool EsDobleTurno { get; set; }
    public IEfectos Efectos { get; set; }
    
}