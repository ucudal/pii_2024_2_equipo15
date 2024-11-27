namespace program;
public class Inventario
{
    private Dictionary<string, int> objetos;

    public Inventario()
    {
        objetos = new Dictionary<string, int>
        {
            { "Súper poción", 4 },
            { "Revivir", 1 },
            { "Cura total", 2 }
        };
    }

    public string UsarObjeto(string nombreObjeto, Pokemon objetivo)
    {
        if (!objetos.ContainsKey(nombreObjeto) || objetos[nombreObjeto] <= 0)
        {
            return $"No tienes {nombreObjeto} disponible.";
        }

        switch (nombreObjeto)
        {
            case "Súper poción":
                objetivo.Vida += 70;
                if (objetivo.Vida > objetivo.VidaBase) objetivo.Vida = objetivo.VidaBase;
                break;

            case "Revivir":
                if (objetivo.Vida > 0) return $"{objetivo.Nombre} no está debilitado.";
                objetivo.Vida = objetivo.VidaBase / 2;
                break;

            case "Cura total":
                objetivo.Estado = null;
                objetivo.DuracionEstado = 0; // Asegúrate de que esta propiedad exista
                break;

            default:
                return "Este objeto no puede ser usado.";
        }

        objetos[nombreObjeto]--;
        return $"{nombreObjeto} fue usado en {objetivo.Nombre}.";
    }

    public string MostrarInventario()
    {
        return string.Join("\n", objetos.Select(o => $"{o.Key}: {o.Value} unidades"));
    }
}