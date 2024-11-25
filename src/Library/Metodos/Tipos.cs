namespace Library;

public class Tipos : ITipo
{
    public string NombreTipo { get; set; }

    public Tipos(string nombreTipo)
    {
        NombreTipo = nombreTipo;

    }

    //Muy_efectivo:2 Poco_efectivo:0,5 Inmune=0
    public double EfectividadDeDaño(ITipo tipoObjetivo)
    {
        
        
        // ----------------------------Agua----------------------------------------//
        if (NombreTipo == "Agua")
        {
            if (tipoObjetivo.NombreTipo == "Fuego" ||  tipoObjetivo.NombreTipo == "Tierra" || tipoObjetivo.NombreTipo == "Roca")
                return 2; 
            else if (tipoObjetivo.NombreTipo == "Agua" || tipoObjetivo.NombreTipo == "Dragón" ||
                     tipoObjetivo.NombreTipo == "Planta")
                return 0.5;
        }
        
        // ----------------------------Bicho----------------------------------------//
        else if (NombreTipo == "Bicho")
        {
            if (tipoObjetivo.NombreTipo == "Planta" ||  tipoObjetivo.NombreTipo == "Psíquico" || tipoObjetivo.NombreTipo == "Lucha" || tipoObjetivo.NombreTipo=="Veneno")
                return 2; 
            else if (tipoObjetivo.NombreTipo == "Fuego" || tipoObjetivo.NombreTipo == "Volador")
                return 0.5;
        }
        
        // ----------------------------Dragón----------------------------------------//
        else if (NombreTipo == "Dragón")
        {
            if (tipoObjetivo.NombreTipo ==  "Dragón" )
                return 2; 
        } 
        
        // ----------------------------Eléctrico----------------------------------------//
        else if (NombreTipo == "Eléctrico")
        {
            if (tipoObjetivo.NombreTipo == "Volador"||tipoObjetivo.NombreTipo == "Agua")
                return 2; 
            else if (tipoObjetivo.NombreTipo == "Dragón" || tipoObjetivo.NombreTipo == "Tierra" ||
                     tipoObjetivo.NombreTipo == "Planta")
                return 0.5;
            else if (tipoObjetivo.NombreTipo == "Eléctrico")
                return 0;
        } 
        
        // ----------------------------Fantasma----------------------------------------//
        else if (NombreTipo == "Fantasma")
        {
            if (tipoObjetivo.NombreTipo == "Fantasma" ||  tipoObjetivo.NombreTipo == "Psíquico")
                return 2; 
            else if ( tipoObjetivo.NombreTipo == "Normal")
                return 0;
            
        }
        
        // ----------------------------Fuego----------------------------------------//
        else if (NombreTipo == "Fuego")
        {
            if ( tipoObjetivo.NombreTipo == "Bicho" || tipoObjetivo.NombreTipo == "Hielo" || tipoObjetivo.NombreTipo == "Planta")
                return 2; 
            else if (tipoObjetivo.NombreTipo == "Agua" || tipoObjetivo.NombreTipo == "Dragón" ||
                     tipoObjetivo.NombreTipo == "Fuego" || tipoObjetivo.NombreTipo == "Roca")
                return 0.5;
        } 
        
            // ----------------------------Hielo----------------------------------------//
        else if (NombreTipo == "Hielo")
        {
            if (tipoObjetivo.NombreTipo == "Dragón" ||  tipoObjetivo.NombreTipo == "Planta" || tipoObjetivo.NombreTipo == "Tierra" || tipoObjetivo.NombreTipo=="Volador")
                return 2; 
            else if (tipoObjetivo.NombreTipo == "Agua" || tipoObjetivo.NombreTipo == "Hielo")
                return 0.5;
        } 
        
        // ----------------------------Lucha----------------------------------------//
        else if (NombreTipo == "Lucha")
        {
            if ( tipoObjetivo.NombreTipo == "Hielo" || tipoObjetivo.NombreTipo == "Normal"|| tipoObjetivo.NombreTipo == "Roca"|| tipoObjetivo.NombreTipo == "Psíquico"|| tipoObjetivo.NombreTipo == "Veneno")
                return 2; 
            else if (tipoObjetivo.NombreTipo == "Bicho" || tipoObjetivo.NombreTipo == "Fantasma" || 
                     tipoObjetivo.NombreTipo == "Volador")
                return 0.5;
           
        }
        
        // ----------------------------Normal----------------------------------------//
        else if (NombreTipo == "Normal")
        {
            if ( tipoObjetivo.NombreTipo == "Roca" || tipoObjetivo.NombreTipo == "Fantasma")
                return 0.5;
            
            
        }
        
        // ----------------------------Planta----------------------------------------//
        else if (NombreTipo == "Planta")
        {
            if (tipoObjetivo.NombreTipo == "Agua" ||  tipoObjetivo.NombreTipo == "Roca" || tipoObjetivo.NombreTipo == "Tierra" || tipoObjetivo.NombreTipo == "Veneno")
                return 2; 
            else if (tipoObjetivo.NombreTipo == "Bicho" || tipoObjetivo.NombreTipo == "Dragón" ||
                     tipoObjetivo.NombreTipo == "Fuego" || tipoObjetivo.NombreTipo == "Planta" || tipoObjetivo.NombreTipo == "Volador"|| tipoObjetivo.NombreTipo == "Veneno")
                return 0.5;
        }
        
        // ----------------------------Psíquico----------------------------------------//
        else if (NombreTipo == "Psíquico")
        {
            if (tipoObjetivo.NombreTipo == "Lucha" ||  tipoObjetivo.NombreTipo == "Veneno")
                return 2; 
           
        }
        
        // ----------------------------Roca----------------------------------------//
        else if (NombreTipo == "Roca")
        {
            if (tipoObjetivo.NombreTipo == "Bicho" ||  tipoObjetivo.NombreTipo == "Fuego" || tipoObjetivo.NombreTipo == "Hielo"|| tipoObjetivo.NombreTipo == "Lucha"|| tipoObjetivo.NombreTipo == "Tierra" || tipoObjetivo.NombreTipo == "Volador")
                return 2; 
      
        }
        
        
        // ----------------------------Tierra----------------------------------------//
        else if (NombreTipo == "Tierra")
        {
            if (tipoObjetivo.NombreTipo == "Eléctrico" || tipoObjetivo.NombreTipo == "Fuego"|| tipoObjetivo.NombreTipo == "Roca"|| tipoObjetivo.NombreTipo == "Veneno")
                return 2; 
            else if (tipoObjetivo.NombreTipo == "Bicho" || tipoObjetivo.NombreTipo == "Planta" || tipoObjetivo.NombreTipo == "Volador")
                return 0.5;
            
        }
 
        // ----------------------------Veneno----------------------------------------//
        else if (NombreTipo == "Veneno")
        {
            if (tipoObjetivo.NombreTipo == "Bicho" ||  tipoObjetivo.NombreTipo == "Planta"||  tipoObjetivo.NombreTipo == "Tierra")
                return 2; 
            else if (tipoObjetivo.NombreTipo == "Fantasma" || tipoObjetivo.NombreTipo == "Veneno" || tipoObjetivo.NombreTipo=="Roca")
                return 0.5;
         
        }
       
        // ----------------------------Volador----------------------------------------//
        else if (NombreTipo == "Volador")
        {
            if (tipoObjetivo.NombreTipo == "Bicho" ||  tipoObjetivo.NombreTipo == "Lucha" ||  tipoObjetivo.NombreTipo == "Planta")
                return 2; 
            else if (tipoObjetivo.NombreTipo == "Eléctrico" || tipoObjetivo.NombreTipo=="Roca")
                return 0.5;
            
        }
        
        
        
        return 1; //situación en la que no hay ventaja ni desventaja relacionada con la efectividad de tipos.
    }
    
    
    
}