namespace Library;

public class Pokemon : IPokemon
{
    public string Nombre { get;  set; }        
    public ITipo Tipo { get;  set; }            
    public int Salud { get; set; }   
    public int SaludTotal { get; set; }
    public List<IAtaque> Ataques { get;  set; }
    
    public List<IAtaque> AtaquesEspeciales { get; set; }

    //Cambio la clase pokemon para que en el constructor no se pida agregar una lista de ataques, la lista se crea y se agrega un metodo para agregar los ataques a la misma
    public Pokemon(string nombre, ITipo tipo, int salud)
    {
        Nombre = nombre;
        Tipo = tipo;
        Salud = salud;
        SaludTotal = salud;
        Ataques = new List<IAtaque>();
        AtaquesEspeciales = new List<IAtaque>();
    }

    public void recibirDaño(int daño)
    {
        Salud -= daño;
        if (Salud <= 0)
        {
            Salud = 0;
        }
    }
    
    public string MostrarSalud(Pokemon pokemon)
    {
        return $"{pokemon.Salud}/{pokemon.SaludTotal}" ;
    }

    public void AgregarAtaques(IAtaque ataque)
    {
        this.Ataques.Add(ataque);
    }
    
    public void AgregarAtaquesEspeciales(IAtaque ataque)
    {
        this.AtaquesEspeciales.Add(ataque);
    }

    public string ConocerAtaques(Pokemon pokemon)
    {
        return $"---Ataques disponibles---" +
               $"{pokemon.Ataques}" +
               $"{pokemon.AtaquesEspeciales}";

    }
}