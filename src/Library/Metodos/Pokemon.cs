namespace Library;

public class Pokemon : IPokemon
{
    public string Nombre { get;  set; }        
    public ITipo Tipo { get;  set; }            
    public int Salud { get; set; }   
    public int SaludTotal { get; set; }
    public List<IAtaque> Ataques { get;  set; }
    public bool EstaQuemado { get; set; }
    public bool EstaParalizado { get; set; }
    public bool EstaDormido{ get; set; }
    public bool EstaEnvenenado { get; set; }

    //Cambio la clase pokemon para que en el constructor no se pida agregar una lista de ataques, la lista se crea y se agrega un metodo para agregar los ataques a la misma
    public Pokemon(string nombre, ITipo tipo, int salud)
    {
        Nombre = nombre;
        Tipo = tipo;
        Salud = salud;
        SaludTotal = salud;
        Ataques = new List<IAtaque>();
        EstaQuemado = false;
        EstaParalizado = false;
        EstaDormido = false;
        EstaEnvenenado = false;

    }

    public void RecibirDaño(int daño)
    {
        Salud -= daño;
        if (Salud <= 0)
        {
            Salud = 0;
        }
    }
    
    public string MostrarSalud(Pokemon pokemon)
    {
        return $"{Salud}/{SaludTotal}" ;
    }

    public void AgregarAtaques(IAtaque ataque)
    {
        Ataques.Add(ataque);
    }
    
    public string ConocerAtaques(Pokemon pokemon)
    {
        string resultado = "---Ataques disponibles---\n"; 
       
        foreach (var ataque in pokemon.Ataques) 
        { resultado += ataque.Nombre + "\n"; } 
        
        return resultado; 
    }
    
    public void Curar(int pocion)
    {
        Salud += pocion;
        if (Salud > SaludTotal)
        {
            Salud = SaludTotal;
        }
    }
    
    public void Revivir(double revive)
    {
        if (Salud == 0)
        {
            Salud = (int)(SaludTotal * revive);
        }
    }

    public void CurarEfecto()
    {
        {
            EstaDormido = false;
            EstaEnvenenado = false;
            EstaParalizado = false;
            EstaQuemado = false;
        }
    }
}