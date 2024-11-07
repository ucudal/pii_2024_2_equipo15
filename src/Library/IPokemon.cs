namespace Library;

public interface IPokemon
{
    string Nombre { get; set; }        // El nombre asignado para el Pokémon
    ITipo Tipo { get; set; }          // El tipo del Pokémon 
    int Salud { get; set; }          // Los puntos de vida
    List<IAtaque> Ataques { get; set; }   // Lista de ataques 
    List<IAtaque> AtaquesEspeciales { get; set; }   // Lista de ataques especiales

    void recibirDaño(int daño);      // Método para recibir daño y reducir salud
     
    int MostrarSalud(); // Método para mostrar salud de un Pokémon
}