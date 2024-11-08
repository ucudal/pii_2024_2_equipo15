namespace Library;

public interface IPokemon
{
    string Nombre { get; set; }        // El nombre asignado para el Pokémon
    ITipo Tipo { get; set; }          // El tipo del Pokémon 
    int Salud { get; set; }          // Salud para poder indicar la vida ACTUAL de mi pokemon
    int SaludTotal { get; set; }    // Salud total para poder indicar la vida TOTAL de mi pokemon
    List<IAtaque> Ataques { get; set; }   // Lista de ataques 
    bool EstaQuemado { get; set; } // Sirve para conocer el estado del pokemon
    bool EstaParalizado { get; set; } // Sirve para conocer el estado del pokemon
    bool EstaDormido { get; set; } // Sirve para conocer el estado del pokemon
    bool EstaEnvenenado { get; set; } // Sirve para conocer el estado del pokemon
    

    void recibirDaño(int daño);      // Método para recibir daño y reducir salud
     
    string MostrarSalud(Pokemon pokemon);         // Método para mostrar salud de un Pokémon
}