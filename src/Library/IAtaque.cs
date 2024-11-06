namespace Library;

public interface IAtaque
{
    string Nombre { get; set; } // Nombre del ataque 
    int Daño { get; set; } //Daño del ataque 
    ITipo Tipo { get; set; } // El tipo del ataque 
}