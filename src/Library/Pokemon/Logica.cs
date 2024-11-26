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

        public static Ataques Placaje = new Ataques("Placaje", 40,  false);
        public static Ataques Hiperrayo = new Ataques("Hiperrayo", 150,  false);
        public static Ataques Lanzallamas = new Ataques("Lanzallamas", 90,  false);
        public static Ataques HidroBomba = new Ataques("Hidro Bomba", 110,  false);
        public static Ataques RayoHielo = new Ataques("Rayo Hielo", 90,  false);
        public static Ataques Trueno = new Ataques("Trueno", 110,  false);
        public static Ataques Terremoto = new Ataques("Terremoto", 100, false);
        public static Ataques RocaAfilada = new Ataques("Roca Afilada", 100, false);
        public static Ataques BolaSombra = new Ataques("Bola Sombra", 80,  false);
        public static Ataques ABoCajarro = new Ataques("A Bocajarro", 120,  false);
        public static Ataques LluviaDraco = new Ataques("Lluvia Draco", 130, true);
        public static Ataques Explosión = new Ataques("Explosión", 250, true);
        public static Ataques PulsoUmbrío = new Ataques("Pulso Umbrío", 120, true);
        public static Ataques ImpactoGélido = new Ataques("Impacto Gélido", 140, true);

        //--------------------------------------------------------------------------------
        //     Inicializar la lista de Pokémon disponibles
        //--------------------------------------------------------------------------------

private List<Pokemon> InicializarPokemones()
{
Pokemon blastoise = new Pokemon("Blastoise", 268, 120, 80, 160);
blastoise.AprenderHabilidad(HidroBomba); 
blastoise.AprenderHabilidad(Placaje); 
blastoise.AprenderHabilidad(LluviaDraco); 

Pokemon pikachu = new Pokemon("Pikachu", 180, 150, 120, 150);
pikachu.AprenderHabilidad(Trueno); 
pikachu.AprenderHabilidad(Placaje); 
pikachu.AprenderHabilidad(Explosión); 

Pokemon charizard = new Pokemon("Charizard", 266, 100, 80, 200);
charizard.AprenderHabilidad(Lanzallamas); 
charizard.AprenderHabilidad(RayoHielo); 
charizard.AprenderHabilidad(ImpactoGélido); 

Pokemon gengar = new Pokemon("Gengar", 261, 120, 95, 140);
gengar.AprenderHabilidad(BolaSombra); 
gengar.AprenderHabilidad(Hiperrayo); 
gengar.AprenderHabilidad(PulsoUmbrío); 

Pokemon dragonite = new Pokemon("Dragonite", 300, 200, 100, 110);
dragonite.AprenderHabilidad(RocaAfilada); 
dragonite.AprenderHabilidad(Placaje); 
dragonite.AprenderHabilidad(LluviaDraco); 

Pokemon machamp = new Pokemon("Machamp", 290, 200, 100, 120);
machamp.AprenderHabilidad(ABoCajarro);
machamp.AprenderHabilidad(Terremoto); 
machamp.AprenderHabilidad(Explosión); 


Pokemon snorlax = new Pokemon("Snorlax", 450, 50, 110, 200);
snorlax.AprenderHabilidad(Placaje); 
snorlax.AprenderHabilidad(Hiperrayo); 
snorlax.AprenderHabilidad(ImpactoGélido); 

Pokemon jolteon = new Pokemon("Jolteon", 220, 200, 100, 80);
jolteon.AprenderHabilidad(Trueno); 
jolteon.AprenderHabilidad(Explosión); 

Pokemon scizor = new Pokemon("Scizor", 250, 120, 150, 180);
scizor.AprenderHabilidad(RocaAfilada); 
scizor.AprenderHabilidad(Placaje); 
scizor.AprenderHabilidad(LluviaDraco); 

Pokemon gyarados = new Pokemon("Gyarados", 300, 130, 150, 100);
gyarados.AprenderHabilidad(HidroBomba); 
gyarados.AprenderHabilidad(Lanzallamas); 
gyarados.AprenderHabilidad(ImpactoGélido); 

Pokemon tyranitar = new Pokemon("Tyranitar", 350, 100, 200, 150);
tyranitar.AprenderHabilidad(Terremoto); 
tyranitar.AprenderHabilidad(RocaAfilada); 
tyranitar.AprenderHabilidad(PulsoUmbrío); 

    return new List<Pokemon>
    {
        blastoise,
        pikachu,
        charizard,
        gengar,
        dragonite,
        machamp,
        snorlax,
        jolteon,
        scizor,
        gyarados,
        tyranitar
    };
}


        // Mostrar todos los Pokémon disponibles
        public string MostrarPokemones()
        {
            string resultado = "```Lista de Pokémon disponibles:\n";
            foreach (var pokemon in pokemones)
            {
                resultado += $"{pokemon.Nombre} | HP: {pokemon.Vida}/{pokemon.VidaBase} | Ataque: {pokemon.Ataque} | Defensa: {pokemon.Defensa} | Velocidad: {pokemon.Velocidad}\n";
            }
            resultado += "```";
            return resultado;
        }


        // Obtener un Pokémon por nombre
        public Pokemon? ObtenerPokemon(string nombre)
        {
            return pokemones.Find(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }

   
        public List<Pokemon> ObtenerTodos()
        {
            return new List<Pokemon>(pokemones);
        }
        public string MostrarAtaquesDePokemones()
        {
            if (pokemones == null || !pokemones.Any())
                return "No hay Pokémon disponibles para mostrar sus ataques.";

            string resultado = "```Lista de ataques de cada Pokémon:\n";
            foreach (var pokemon in pokemones)
            {
                resultado += $"{pokemon.Nombre}:\n";
                foreach (var habilidad in pokemon.Habilidades)
                {
                    // Mostrar información relevante para cada habilidad
                    resultado += $"- {habilidad.Nombre} | Daño: {habilidad.Danio} | Precisión: {habilidad.Precision} | PP: {habilidad.Puntos_de_Poder} | Especial: {(habilidad.EsEspecial ? "Sí" : "No")}\n";
                }
                resultado += "\n";
            }
            resultado += "```";
            return resultado;
        }


    }
}
