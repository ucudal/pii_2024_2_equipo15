namespace Library;

public class Pokemon : IPokemon
{
    public string Nombre { get;  set; }        
    public ITipo Tipo { get;  set; }            
    public int Salud { get; set; }             
    public List<IAtaque> Ataques { get;  set; }
    
    public List<IAtaque> AtaquesEspeciales { get; set; }

    //Cambio la clase pokemon para que en el constructor no se pida agregar una lista de ataques, la lista se crea y se agrega un metodo para agregar los ataques a la misma
    public Pokemon(string nombre, ITipo tipo, int salud)
    {
        Nombre = nombre;
        Tipo = tipo;
        Salud = salud;
        this.Ataques = new List<IAtaque>();
        this.AtaquesEspeciales = new List<IAtaque>();
    }

    public void RecibirDaño(int daño)
    {
      
    }


    public int MostrarSalud()
    {
        return 0;
    }

    public void AgregarAtaques(IAtaque ataque)
    {
        this.Ataques.Add(ataque);
    }
    
    public void AgregarAtaquesEspeciales(IAtaque ataque)
    {
        this.AtaquesEspeciales.Add(ataque);
    }

    public string ConocerAtaques()
    {
        return null;
    }
}