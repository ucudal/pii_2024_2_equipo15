namespace program;
public class Ataque
{
    public string Nombre { get; }
    public int Danio { get; }
    public int Precision { get; } // Representado como porcentaje
    public bool EsEspecial { get; }
    public EfectoEspeciales? Efecto { get; }
        
    public string Usar(Pokemon atacante, Pokemon defensor)
    {
        Random random = new Random();
        if (random.Next(0, 100) >= Precision)
        {
            return $"{atacante.Nombre} intentó usar {Nombre}, pero falló.";
        }

        if (EsEspecial && Efecto != null && string.IsNullOrEmpty(defensor.Estado))
        {
            Efecto.AplicarEfecto(defensor);
            return $"{atacante.Nombre} usó {Nombre} y aplicó el efecto {Efecto.Nombre} en {defensor.Nombre}.";
        }

        // Daño con posibilidad de crítico
        double multiplicadorCritico = random.Next(0, 100) < 10 ? 1.2 : 1.0;
        int danioRealizado = (int)(Danio * multiplicadorCritico);
        defensor.Vida -= danioRealizado;
        defensor.Vida = Math.Max(defensor.Vida, 0);

        return $"{atacante.Nombre} usó {Nombre} causando {danioRealizado} puntos de daño. {defensor.Nombre} tiene {defensor.Vida}/{defensor.VidaBase} de vida restante.";
    }
}
