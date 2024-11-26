﻿﻿using System.Collections.Generic;

namespace program;

public class WaitingList
{
    // Lista de entrenadores en el lobby
    private List<Entrenador> Entrenadoress { get; }= new List<Entrenador>();
   
    public int Cantidad
    {
        get { return Entrenadoress.Count; }
    }
    
    // Método para agregar un entrenador al lobby
    public bool AgregarEntrenadores(string NombreEntrenador)
    {
        // Verificamos que el nombre no sea nulo o vacío
        if (string.IsNullOrEmpty(NombreEntrenador))
            throw new ArgumentException(nameof(NombreEntrenador));
        
        // Si el entrenador ya está, no lo agregamos
        if (EntrenadorPorNombre(NombreEntrenador) != null) 
            return false;
        
        // Agregamos nuevo entrenador
        Entrenadoress.Add(new Entrenador(NombreEntrenador));
        return true;
    }
    
    // Método para eliminar un entrenador del lobby, bool para indicar si se completó
    public bool SacarEntrenadores(string EntrenadoresName)
    {
        // Buscamos al entrenador por nombre string, si no está, no se puede eliminar
        Entrenador? Entrenadores = EntrenadorPorNombre(EntrenadoresName);
        if (Entrenadores == null)
            return false;
        
        // Lo removemos de la lista
        Entrenadoress.Remove(Entrenadores);
        return true;
    }
    
    // Método para obtener un entrenador por su nombre como string, útil para fachada y futuras implementaciones
    public Entrenador? EntrenadorPorNombre(string EntrenadoresName)
    {
        foreach (Entrenador Entrenadores in Entrenadoress)
            if (Entrenadores.Nombre == EntrenadoresName)
            {
                return Entrenadores;
            }
        return null;
    }
    
    // Método para asignar un oponente random
    public Entrenador? AnadirRandom(string EntrenadoresName)
    {
        Random random = new Random();
        // Si hay menos de dos entrenadores en lobby, no se puede asignar oponente
        if (Cantidad <= 1)
            return null;
        
        int numerorandom;
        do
        {
            //Generamos número random dentro de los posibles
            numerorandom = random.Next(0, Cantidad);
            // Nos aseguramos de que el entrenador seleccionado no sea uno mismo
        } while (Entrenadoress[numerorandom].Nombre == EntrenadoresName);
        return Entrenadoress[numerorandom];
    }
    
    // Método para ver la lista de entrenadores en el lobby
    public string VerListaLobby()
    {
        string result = null;
            
        // Recorremos la lista y agregamos los nombres al string result
        foreach (var entrenador in Entrenadoress)
        {
            result += entrenador.Nombre + "\n";
        }

        return result;
    }
    
}