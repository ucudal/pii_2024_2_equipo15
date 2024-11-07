namespace Library;

public class Tipos : ITipo
{
    public string NombreTipo { get; set; }

    public Tipos(string nombreTipo)
    {
        NombreTipo = nombreTipo;

    }

    //Muy_efectivo:4 Efectivo:3 Poco_efectivo:2
    public int efectividadDeDaño(ITipo tipoObjetivo)
    {
        // ----------------------------Acero----------------------------------------//
        if (NombreTipo == "Acero")
        {
            if (tipoObjetivo.NombreTipo == "Hada" || tipoObjetivo.NombreTipo == "Hielo" ||
                tipoObjetivo.NombreTipo == "Roca")
                return 4;
            else if (tipoObjetivo.NombreTipo == "Acero" || tipoObjetivo.NombreTipo == "Agua" ||
                     tipoObjetivo.NombreTipo == "Fuego" || tipoObjetivo.NombreTipo == "Eléctrico")
                return 3;
        }
        
        // ----------------------------Agua----------------------------------------//
        else if (NombreTipo == "Agua")
        {
            if (tipoObjetivo.NombreTipo == "Fuego" ||  tipoObjetivo.NombreTipo == "Tierra" || tipoObjetivo.NombreTipo == "Roca")
                return 4; 
            else if (tipoObjetivo.NombreTipo == "Agua" || tipoObjetivo.NombreTipo == "Dragón" ||
                     tipoObjetivo.NombreTipo == "Planta")
                return 3;
        }
        
        // ----------------------------Bicho----------------------------------------//
        else if (NombreTipo == "Bicho")
        {
            if (tipoObjetivo.NombreTipo == "Planta" ||  tipoObjetivo.NombreTipo == "Psíquico" || tipoObjetivo.NombreTipo == "Siniestro")
                return 4; 
            else if (tipoObjetivo.NombreTipo == "Acero" || tipoObjetivo.NombreTipo == "Fuego" ||
                     tipoObjetivo.NombreTipo == "Hada" || tipoObjetivo.NombreTipo == "Fantasma" || tipoObjetivo.NombreTipo == "Lucha" || tipoObjetivo.NombreTipo == "Veneno" || tipoObjetivo.NombreTipo == "Volador")
                return 3;
        }
        
        // ----------------------------Dragón----------------------------------------//
        else if (NombreTipo == "Dragón")
        {
            if (tipoObjetivo.NombreTipo ==  "Dragón")
                return 4; 
            else if (tipoObjetivo.NombreTipo == "Acero")
                return 3;
            else if (tipoObjetivo.NombreTipo == "Hada")
                return 2;
        } 
        
        // ----------------------------Eléctrico----------------------------------------//
        else if (NombreTipo == "Eléctrico")
        {
            if (tipoObjetivo.NombreTipo == "Agua" ||  tipoObjetivo.NombreTipo == "Volador")
                return 4; 
            else if (tipoObjetivo.NombreTipo == "Dragón" || tipoObjetivo.NombreTipo == "Eléctrico" ||
                     tipoObjetivo.NombreTipo == "Planta")
                return 3;
            else if (tipoObjetivo.NombreTipo == "Tierra")
                return 2;
        } 
        
        // ----------------------------Fantasma----------------------------------------//
        else if (NombreTipo == "Fantasma")
        {
            if (tipoObjetivo.NombreTipo == "Fantasma" ||  tipoObjetivo.NombreTipo == "Psíquico")
                return 4; 
            else if (tipoObjetivo.NombreTipo == "Siniestro")
                return 3;
            else if (tipoObjetivo.NombreTipo == "Normal")
                return 2;
        }
        
        // ----------------------------Fuego----------------------------------------//
        else if (NombreTipo == "Fuego")
        {
            if (tipoObjetivo.NombreTipo == "Acero" ||  tipoObjetivo.NombreTipo == "Bicho" || tipoObjetivo.NombreTipo == "Hielo" || tipoObjetivo.NombreTipo == "Planta")
                return 4; 
            else if (tipoObjetivo.NombreTipo == "Agua" || tipoObjetivo.NombreTipo == "Dragón" ||
                     tipoObjetivo.NombreTipo == "Fuego" || tipoObjetivo.NombreTipo == "Roca")
                return 3;
        } 
        
        // ----------------------------Hada----------------------------------------//
        else if (NombreTipo == "Hada")
        {
            if (tipoObjetivo.NombreTipo == "Dragón" ||  tipoObjetivo.NombreTipo == "Lucha" || tipoObjetivo.NombreTipo == "Siniestro")
                return 4; 
            else if (tipoObjetivo.NombreTipo == "Acero" || tipoObjetivo.NombreTipo == "Fuego" ||
                        tipoObjetivo.NombreTipo == "Veneno" )
                return 3;
        } 
        
            // ----------------------------Hielo----------------------------------------//
        else if (NombreTipo == "Hielo")
        {
            if (tipoObjetivo.NombreTipo == "Dragón" ||  tipoObjetivo.NombreTipo == "Planta" || tipoObjetivo.NombreTipo == "Tierra" || tipoObjetivo.NombreTipo=="Volador")
                return 4; 
            else if (tipoObjetivo.NombreTipo == "Agua" || tipoObjetivo.NombreTipo == "Hielo")
                return 3;
        } 
        
        // ----------------------------Lucha----------------------------------------//
        else if (NombreTipo == "Lucha")
        {
            if (tipoObjetivo.NombreTipo == "Acero" ||  tipoObjetivo.NombreTipo == "Hielo" || tipoObjetivo.NombreTipo == "Normal"|| tipoObjetivo.NombreTipo == "Roca"|| tipoObjetivo.NombreTipo == "Siniestro")
                return 4; 
            else if (tipoObjetivo.NombreTipo == "Bicho" || tipoObjetivo.NombreTipo == "Hada" ||
                     tipoObjetivo.NombreTipo == "Psíquico" || tipoObjetivo.NombreTipo == "Veneno" || tipoObjetivo.NombreTipo == "Volador")
                return 3;
            else if (tipoObjetivo.NombreTipo == "Fantasma")
                return 2;
        }
        
        // ----------------------------Normal----------------------------------------//
        else if (NombreTipo == "Normal")
        {
            if (tipoObjetivo.NombreTipo == "Acero" || tipoObjetivo.NombreTipo == "Roca")
                return 3;
            else if (tipoObjetivo.NombreTipo == "Fantasma")
                return 2;
        }
        
        // ----------------------------Planta----------------------------------------//
        else if (NombreTipo == "Planta")
        {
            if (tipoObjetivo.NombreTipo == "Agua" ||  tipoObjetivo.NombreTipo == "Roca" || tipoObjetivo.NombreTipo == "Tierra")
                return 4; 
            else if (tipoObjetivo.NombreTipo == "Bicho" || tipoObjetivo.NombreTipo == "Acero" || tipoObjetivo.NombreTipo == "Dragón" ||
                     tipoObjetivo.NombreTipo == "Fuego" || tipoObjetivo.NombreTipo == "Planta" || tipoObjetivo.NombreTipo == "Volador"|| tipoObjetivo.NombreTipo == "Veneno")
                return 3;
        }
        
        // ----------------------------Psíquico----------------------------------------//
        else if (NombreTipo == "Psíquico")
        {
            if (tipoObjetivo.NombreTipo == "Lucha" ||  tipoObjetivo.NombreTipo == "Veneno")
                return 4; 
            else if (tipoObjetivo.NombreTipo == "Acero" || tipoObjetivo.NombreTipo == "Psíquico")
                return 3;
            else if (tipoObjetivo.NombreTipo == "Siniestro")
                return 2;
        }
        
        // ----------------------------Roca----------------------------------------//
        else if (NombreTipo == "Roca")
        {
            if (tipoObjetivo.NombreTipo == "Bicho" ||  tipoObjetivo.NombreTipo == "Fuego" || tipoObjetivo.NombreTipo == "Hielo"|| tipoObjetivo.NombreTipo == "Volador")
                return 4; 
            else if (tipoObjetivo.NombreTipo == "Acero" || tipoObjetivo.NombreTipo == "Lucha" ||
                     tipoObjetivo.NombreTipo == "Tierra")
                return 3;
        }
        
        // ----------------------------Siniestro----------------------------------------//
        else if (NombreTipo == "Siniestro")
        {
            if (tipoObjetivo.NombreTipo == "Fantasma" ||  tipoObjetivo.NombreTipo == "Psíquico")
                return 4; 
            else if (tipoObjetivo.NombreTipo == "Acero" || tipoObjetivo.NombreTipo == "Lucha" ||
                                   tipoObjetivo.NombreTipo == "Siniestro")
                return 3;
        }
        
        // ----------------------------Tierra----------------------------------------//
        else if (NombreTipo == "Tierra")
        {
            if (tipoObjetivo.NombreTipo == "Acero" ||  tipoObjetivo.NombreTipo == "Eléctrico" || tipoObjetivo.NombreTipo == "Fuego"|| tipoObjetivo.NombreTipo == "Roca"|| tipoObjetivo.NombreTipo == "Veneno")
                return 4; 
            else if (tipoObjetivo.NombreTipo == "Bicho" || tipoObjetivo.NombreTipo == "Planta")
                return 3;
            else if (tipoObjetivo.NombreTipo == "Volador")
                return 2;
        }
 
        // ----------------------------Veneno----------------------------------------//
        else if (NombreTipo == "Veneno")
        {
            if (tipoObjetivo.NombreTipo == "Hada" ||  tipoObjetivo.NombreTipo == "Planta")
                return 4; 
            else if (tipoObjetivo.NombreTipo == "Fantasma" || tipoObjetivo.NombreTipo == "Veneno" || tipoObjetivo.NombreTipo=="Tierra" || tipoObjetivo.NombreTipo=="Roca")
                return 3;
            else if (tipoObjetivo.NombreTipo == "Acero")
                return 2;
        }
       
        // ----------------------------Volador----------------------------------------//
        else if (NombreTipo == "Volador")
        {
            if (tipoObjetivo.NombreTipo == "Bicho" ||  tipoObjetivo.NombreTipo == "Lucha" ||  tipoObjetivo.NombreTipo == "Planta")
                return 4; 
            else if (tipoObjetivo.NombreTipo == "Acero" || tipoObjetivo.NombreTipo == "Eléctrico" || tipoObjetivo.NombreTipo=="Roca")
                return 3;
            
        }
        
        
        
        return 1; //Valor_neutral: representa una situación en la que no hay ventaja ni desventaja relacionada con la efectividad de tipos.
    }

}