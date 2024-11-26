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

        //--------------------------------------------------------------------------------
        //     Instanciar todos los tipos disponibles
        //--------------------------------------------------------------------------------

        public static Tipos Agua = new Tipos("Agua", new Dictionary<string, double>
    {
        { "Fuego", 2.0 }, { "Tierra", 2.0 }, { "Roca", 2.0 },
        { "Agua", 0.5 }, { "Planta", 0.5 }, { "Dragon", 0.5 }
    });

    public static Tipos Fuego = new Tipos("Fuego", new Dictionary<string, double>
    {
        { "Planta", 2.0 }, { "Hielo", 2.0 }, { "Bicho", 2.0 }, { "Acero", 2.0 },
        { "Fuego", 0.5 }, { "Agua", 0.5 }, { "Roca", 0.5 }, { "Dragon", 0.5 }
    });

    public static Tipos Planta = new Tipos("Planta", new Dictionary<string, double>
    {
        { "Agua", 2.0 }, { "Tierra", 2.0 }, { "Roca", 2.0 },
        { "Fuego", 0.5 }, { "Planta", 0.5 }, { "Volador", 0.5 }, { "Bicho", 0.5 }, { "Veneno", 0.5 }, { "Dragon", 0.5 }, { "Acero", 0.5 }
    });

    public static Tipos Electrico = new Tipos("Electrico", new Dictionary<string, double>
    {
        { "Agua", 2.0 }, { "Volador", 2.0 },
        { "Planta", 0.5 }, { "Electrico", 0.5 }, { "Dragon", 0.5 },
        { "Tierra", 0.0 }
    });

    public static Tipos Roca = new Tipos("Roca", new Dictionary<string, double>
    {
        { "Fuego", 2.0 }, { "Hielo", 2.0 }, { "Volador", 2.0 }, { "Bicho", 2.0 },
        { "Lucha", 0.5 }, { "Tierra", 0.5 }, { "Acero", 0.5 }
    });

    public static Tipos Tierra = new Tipos("Tierra", new Dictionary<string, double>
    {
        { "Fuego", 2.0 }, { "Electrico", 2.0 }, { "Veneno", 2.0 }, { "Roca", 2.0 }, { "Acero", 2.0 },
        { "Planta", 0.5 }, { "Volador", 0.0 }
    });

    public static Tipos Volador = new Tipos("Volador", new Dictionary<string, double>
    {
        { "Planta", 2.0 }, { "Lucha", 2.0 }, { "Bicho", 2.0 },
        { "Roca", 0.5 }, { "Electrico", 0.5 }, { "Acero", 0.5 }
    });

    public static Tipos Veneno = new Tipos("Veneno", new Dictionary<string, double>
    {
        { "Planta", 2.0 }, { "Hada", 2.0 },
        { "Veneno", 0.5 }, { "Tierra", 0.5 }, { "Roca", 0.5 }, { "Fantasma", 0.5 },
        { "Acero", 0.0 }
    });

    public static Tipos Hada = new Tipos("Hada", new Dictionary<string, double>
    {
        { "Lucha", 2.0 }, { "Dragon", 2.0 }, { "Siniestro", 2.0 },
        { "Fuego", 0.5 }, { "Veneno", 0.5 }, { "Acero", 0.5 }
    });

    public static Tipos Lucha = new Tipos("Lucha", new Dictionary<string, double>
    {
        { "Normal", 2.0 }, { "Hielo", 2.0 }, { "Roca", 2.0 }, { "Siniestro", 2.0 }, { "Acero", 2.0 },
        { "Veneno", 0.5 }, { "Volador", 0.5 }, { "Psiquico", 0.5 }, { "Hada", 0.5 },
        { "Fantasma", 0.0 }
    });

    public static Tipos Psiquico = new Tipos("Psiquico", new Dictionary<string, double>
    {
        { "Lucha", 2.0 }, { "Veneno", 2.0 },
        { "Psiquico", 0.5 }, { "Acero", 0.5 },
        { "Siniestro", 0.0 }
    });

    public static Tipos Fantasma = new Tipos("Fantasma", new Dictionary<string, double>
    {
        { "Fantasma", 2.0 }, { "Psiquico", 2.0 },
        { "Siniestro", 0.5 }, { "Normal", 0.0 }
    });

    public static Tipos Acero = new Tipos("Acero", new Dictionary<string, double>
    {
        { "Hielo", 2.0 }, { "Roca", 2.0 }, { "Hada", 2.0 },
        { "Fuego", 0.5 }, { "Agua", 0.5 }, { "Electrico", 0.5 }, { "Acero", 0.5 }
    });

    public static Tipos Hielo = new Tipos("Hielo", new Dictionary<string, double>
    {
        { "Planta", 2.0 }, { "Tierra", 2.0 }, { "Volador", 2.0 }, { "Dragon", 2.0 },
        { "Fuego", 0.5 }, { "Agua", 0.5 }, { "Hielo", 0.5 }, { "Acero", 0.5 }
    });

    public static Tipos Dragon = new Tipos("Dragon", new Dictionary<string, double>
    {
        { "Dragon", 2.0 },
        { "Acero", 0.5 }, { "Hada", 0.0 }
    });

    public static Tipos Siniestro = new Tipos("Siniestro", new Dictionary<string, double>
    {
        { "Psiquico", 2.0 }, { "Fantasma", 2.0 },
        { "Lucha", 0.5 }, { "Siniestro", 0.5 }, { "Hada", 0.5 }
    });

    public static Tipos Normal = new Tipos("Normal", new Dictionary<string, double>
    {
        { "Roca", 0.5 }, { "Acero", 0.5 }, { "Fantasma", 0.0 }
    });


        //--------------------------------------------------------------------------------
        //     Instanciar todos los ataques disponibles
        //--------------------------------------------------------------------------------

        public static Ataques Placaje = new Ataques("Placaje", 40, Normal, true);
        public static Ataques Hiperrayo = new Ataques("Hiperrayo", 150, Normal, false);
        public static Ataques Lanzallamas = new Ataques("Lanzallamas", 90, Fuego, true);
        public static Ataques HidroBomba = new Ataques("Hidro Bomba", 110, Agua, false);
        public static Ataques RayoHielo = new Ataques("Rayo Hielo", 90, Hielo, false);
        public static Ataques Trueno = new Ataques("Trueno", 110, Electrico, true);
        public static Ataques Terremoto = new Ataques("Terremoto", 100, Tierra, true);
        public static Ataques RocaAfilada = new Ataques("Roca Afilada", 100, Roca, false);
        public static Ataques BolaSombra = new Ataques("Bola Sombra", 80, Fantasma, false);
        public static Ataques ABoCajarro = new Ataques("A Bocajarro", 120, Lucha, true);

        //--------------------------------------------------------------------------------
        //     Inicializar la lista de Pokémon disponibles
        //--------------------------------------------------------------------------------

        private List<Pokemon> InicializarPokemones()
        {
            // Crear Pokémon con tipos y ataques asignados
            Pokemon blastoise = new Pokemon("Blastoise", 268, Agua);
            blastoise.AprenderHabilidad(HidroBomba);
            blastoise.AprenderHabilidad(Placaje);

            Pokemon pikachu = new Pokemon("Pikachu", 180, Electrico);
            pikachu.AprenderHabilidad(Trueno);
            pikachu.AprenderHabilidad(Placaje);

            Pokemon charizard = new Pokemon("Charizard", 266, Fuego, Volador);
            charizard.AprenderHabilidad(Lanzallamas);
            charizard.AprenderHabilidad(RayoHielo);

            Pokemon gengar = new Pokemon("Gengar", 261, Fantasma, Psiquico);
            gengar.AprenderHabilidad(BolaSombra);
            gengar.AprenderHabilidad(Hiperrayo);

            Pokemon dragonite = new Pokemon("Dragonite", 300, Dragon, Volador);
            dragonite.AprenderHabilidad(RocaAfilada);
            dragonite.AprenderHabilidad(Placaje);

            Pokemon machamp = new Pokemon("Machamp", 290, Lucha);
            machamp.AprenderHabilidad(ABoCajarro);
            machamp.AprenderHabilidad(Terremoto);

          

            return new List<Pokemon>
            {
                blastoise,
                pikachu,
                charizard,
                gengar,
                dragonite,
                machamp
            };
        }

        // Mostrar todos los Pokémon disponibles
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
        public string MostrarAtaquesDePokemones()
        {
            string resultado = "```Lista de ataques de cada Pokémon:\n";
            foreach (var pokemon in pokemones)
            {
                resultado += $"{pokemon.Nombre}:\n";
                foreach (var habilidad in pokemon.Habilidades)
                {
                    resultado += $"- {habilidad.Nombre} | Daño: {habilidad.Danio} | Precisión: {habilidad.Precision} | Tipo: {habilidad.Tipo.Nombre}\n";
                }
                resultado += "\n";
            }
            resultado += "```";
            return resultado;
        }

    }
}
