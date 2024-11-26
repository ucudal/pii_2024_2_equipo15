namespace program
{
    public class Logica
    {
        private static Logica? _instance;
        private List<Pokemon> pokemones;

        // Singleton para asegurar una única instancia de Logica
        public static Logica Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logica();
                }
                return _instance;
            }
        }

        private Logica()
        {
            pokemones = InicializarPokemones();
        }

        // Inicializar la lista de Pokémon disponibles
        private List<Pokemon> InicializarPokemones()
        {
            // Tipos básicos
            ITipo tipoFuego = new Tipos("Fuego", new Dictionary<string, double>());
            ITipo tipoAgua = new Tipos("Agua", new Dictionary<string, double>());
            ITipo tipoPlanta = new Tipos("Planta", new Dictionary<string, double>());
            ITipo tipoElectrico = new Tipos("Electrico", new Dictionary<string, double>());
            ITipo tipoNormal = new Tipos("Normal", new Dictionary<string, double>());
            ITipo tipoFantasma = new Tipos("Fantasma", new Dictionary<string, double>());
            ITipo tipoPsiquico = new Tipos("Psiquico", new Dictionary<string, double>());
            ITipo tipoDragon = new Tipos("Dragon", new Dictionary<string, double>());
            ITipo tipoHada = new Tipos("Hada", new Dictionary<string, double>());
            ITipo tipoTierra = new Tipos("Tierra", new Dictionary<string, double>());
            ITipo tipoVolador = new Tipos("Volador", new Dictionary<string, double>());
            ITipo tipoRoca = new Tipos("Roca", new Dictionary<string, double>());
            ITipo tipoBicho = new Tipos("Bicho", new Dictionary<string, double>());
            ITipo tipoHielo = new Tipos("Hielo", new Dictionary<string, double>());
            ITipo tipoSiniestro = new Tipos("Siniestro", new Dictionary<string, double>());
            ITipo tipoVeneno = new Tipos("Veneno", new Dictionary<string, double>());
            ITipo tipoAcero = new Tipos("Acero", new Dictionary<string, double>());

            // Efectos básicos
            IEfectos paralisis = new Efectos("paralizado");
            IEfectos quemadura = new Efectos("quemado");
            IEfectos noqueado = new Efectos("noqueado");

            // Crear Pokémon y asignarles habilidades
            Pokemon sceptile = new Pokemon("SCEPTILE", 281, tipoPlanta);
            sceptile.AprenderHabilidad(new Habilidades("Corte furia", tipoBicho, 40, 95, 20, false));
            sceptile.AprenderHabilidad(new Habilidades("Energibola", tipoPlanta, 90, 100, 10, false));
            sceptile.AprenderHabilidad(new Habilidades("Hoja Aguda", tipoPlanta, 90, 100, 15, false));
            sceptile.AprenderHabilidad(new Habilidades("Lluevehojas", tipoPlanta, 130, 80, 5, true));

            Pokemon arcanine = new Pokemon("ARCANINE", 321, tipoFuego);
            arcanine.AprenderHabilidad(new Habilidades("Ascuas", tipoFuego, 40, 100, 25, false));
            arcanine.AprenderHabilidad(new Habilidades("Lanzallamas", tipoFuego, 90, 90, 15, false));
            arcanine.AprenderHabilidad(new Habilidades("Velocidad Extrema", tipoNormal, 80, 70, 5, false));
            arcanine.AprenderHabilidad(new Habilidades("Envite ígneo", tipoFuego, 120, 100, 15, true, quemadura));

            Pokemon blastoise = new Pokemon("BLASTOISE", 299, tipoAgua);
            blastoise.AprenderHabilidad(new Habilidades("Pistola Agua", tipoAgua, 40, 100, 25, false));
            blastoise.AprenderHabilidad(new Habilidades("Hidropulso", tipoAgua, 60, 100, 20, false));
            blastoise.AprenderHabilidad(new Habilidades("Acua Cola", tipoAgua, 90, 90, 10, false));
            blastoise.AprenderHabilidad(new Habilidades("HidroBomba", tipoAgua, 110, 80, 5, true));

            Pokemon pikachu = new Pokemon("PIKACHU", 211, tipoElectrico);
            pikachu.AprenderHabilidad(new Habilidades("Electrobola", tipoElectrico, 90, 90, 6, false));
            pikachu.AprenderHabilidad(new Habilidades("Rayo", tipoElectrico, 110, 70, 15, false));
            pikachu.AprenderHabilidad(new Habilidades("Puño Trueno", tipoElectrico, 60, 100, 15, false));
            pikachu.AprenderHabilidad(new Habilidades("Trueno", tipoElectrico, 120, 50, 5, true, paralisis));

            Pokemon gengar = new Pokemon("GENGAR", 261, tipoFantasma, tipoSiniestro);
            gengar.AprenderHabilidad(new Habilidades("Bola Sombra", tipoFantasma, 80, 100, 15, false));
            gengar.AprenderHabilidad(new Habilidades("Sombra Aterradora", tipoSiniestro, 75, 100, 15, false));
            gengar.AprenderHabilidad(new Habilidades("Puño Siniestro", tipoSiniestro, 70, 100, 20, false));
            gengar.AprenderHabilidad(new Habilidades("Tormenta Sombría", tipoFantasma, 155, 60, 5, true));

            Pokemon dragonite = new Pokemon("DRAGONITE", 323, tipoDragon, tipoVolador);
            dragonite.AprenderHabilidad(new Habilidades("Golpe Dragón", tipoDragon, 75, 100, 15, false));
            dragonite.AprenderHabilidad(new Habilidades("Hiperrayo", tipoNormal, 100, 90, 5, false));
            dragonite.AprenderHabilidad(new Habilidades("Colas de Fuego", tipoFuego, 90, 100, 15, false));
            dragonite.AprenderHabilidad(new Habilidades("Tormenta de Dragones", tipoDragon, 150, 50, 5, true, paralisis));

            // Agregar Pokémon adicionales según el patrón anterior...

            // Devolver la lista completa
            return new List<Pokemon>
            {
                sceptile,
                arcanine,
                blastoise,
                pikachu,
                gengar,
                dragonite,
                // Agregar más Pokémon aquí...
            };
        }

        // Mostrar todos los Pokémon
        public string MostrarPokemones()
        {
            string resultado = "```Lista de Pokémon disponibles:\n";
            foreach (var pokemon in pokemones)
            {
                resultado += $"{pokemon.Nombre} | Tipo: {pokemon.TipoPrincipal.Nombre} | HP: {pokemon.Vida}/{pokemon.VidaBase}\n";
            }
            resultado += "```";
            return resultado;
        }

        // Obtener un Pokémon por nombre
        public Pokemon? ObtenerPokemon(string nombre)
        {
            return pokemones.Find(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }

        // Obtener todos los Pokémon disponibles
        public List<Pokemon> ObtenerTodos()
        {
            return new List<Pokemon>(pokemones);
        }
    }
}
