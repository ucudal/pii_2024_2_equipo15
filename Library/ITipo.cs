namespace Library;

public interface ITipo
{
        string NombreTipo { get; set; }    // Nombre del tipo 
        double EfectividadDeDaño (ITipo tipoObjetivo);  // calcular el daño basado en la efectividad del tipo y las ventajas o desventajas del tipo
}