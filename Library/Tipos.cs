namespace Library;

public class Tipos : ITipo
{
    public string NombreTipo { get; set; }

    public Tipos(string nombreTipo)
    {
        NombreTipo = nombreTipo;

    }

    public double EfectividadDeDaño(ITipo tipoObjetivo)
    {
        return 0;
    }
}