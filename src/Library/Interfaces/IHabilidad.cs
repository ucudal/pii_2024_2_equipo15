namespace program;
public interface IHabilidad
{
    string Nombre { get; set; }
    int Danio { get; set; } // Daño base
    int Precision { get; set; } // Precisión del ataque
    int Puntos_de_Poder { get; set; } // Cantidad de veces que puede usarse
    bool EsDobleTurno { get; set; } // Indica si la habilidad requiere dos turnos
    int Poder { get; set; } // Poder base del ataque
    bool EsEspecial { get; set; } // Nuevo: indica si el ataque es especial
    IEfectos Efectos { get; set; } // Efectos adicionales de la habilidad
}