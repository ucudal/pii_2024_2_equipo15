namespace Library;

public class Ataques : IAtaque
{
    public string Nombre { get;  set; }
    public int Daño { get;  set; }
    public bool EsEspecial { get;  set; }
    public ITipo Tipo { get;  set; }
    
    public Ataques(string nombre, int daño, ITipo tipo, bool esEspecial)
    {
        Nombre = nombre;
        Daño = daño;
        Tipo = tipo;
        EsEspecial = esEspecial;
    }
}