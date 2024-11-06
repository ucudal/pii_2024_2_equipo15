namespace Library;

public class Pokemon : IPokemon
{
    public string Nombre { get;  set; }        
    public ITipo Tipo { get;  set; }            
    public int Salud { get; set; }             
    public List<IAtaque> Ataques { get;  set; }
    
    public List<IAtaque> AtaquesEspeciales { get; set; }

    public Pokemon(string nombre, ITipo tipo, int salud, List<IAtaque> ataques, List<IAtaque> ataquesEspeciales)
    {
        Nombre = nombre;
        Tipo = tipo;
        Salud = salud;
        Ataques = ataques;
        AtaquesEspeciales = ataquesEspeciales;
    }

    public void RecibirDaño(int daño)
    {
      
    }


    public int MostrarSalud()
    {
        return 0;
    }
    
    public string ConocerAtaques()
    {
        return null;
    }
}