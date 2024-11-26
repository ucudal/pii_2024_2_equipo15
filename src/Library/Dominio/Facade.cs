using program;
namespace Library;

public class Facade
{
    private static Facade? _instance;
    private readonly Dictionary<string, Entrenador> entrenadores;

    // Singleton para acceder a la instancia
    public static Facade Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Facade();
            }
            return _instance;
        }
    }
    
    
        public static List<Pokemon> catalogoPokemon = new List<Pokemon>
        {
            Logica.Blastoise,
            Logica.Arbok,
            Logica.Pikachu,
            Logica.Sandslash,
            Logica.Ninetales,
            Logica.Persian,
            Logica.Dragonair,
            Logica.Meganium,
      
        };

        public List<Pokemon> ObtenerCatalogoPokemon()
        {
            return catalogoPokemon;
        }
    


    private Facade()
    {
        entrenadores = new Dictionary<string, Entrenador>();
    }

    public void AgregarEntrenador(Entrenador entrenador)
    {
        if (!entrenadores.ContainsKey(entrenador.Nombre))
        {
            entrenadores[entrenador.Nombre] = entrenador;
        }
    }
    public Entrenador ObtenerEntrenador(string nombre)
    {
        if (entrenadores.TryGetValue(nombre, out Entrenador? entrenador))
        {
            return entrenador;
        }
        throw new Exception($"No se encontró un entrenador con el nombre: {nombre}");
    }

    public bool ExisteEntrenador(string nombre)
    {
        return entrenadores.ContainsKey(nombre);
    }

}