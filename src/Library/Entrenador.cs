namespace Library
{
    public class Entrenador
    {
        public string Nombre { get; set; }              
        public List<Pokemon> Equipo { get; set; }     
        
        public int SuperPociones { get; set; }
        public int Revivir { get; set; }
        public int CuraTotal { get; set; }

        public Entrenador(string nombre)
        {
            Nombre = nombre;
            Equipo = new List<Pokemon>();
            SuperPociones = 4;
            Revivir = 1;
            CuraTotal = 2;
        }

        public int Atacar(IPokemon objetivo, IAtaque ataque)
        {
            if (ataque.EsEspecial == true)
            {
                if (objetivo.EstaDormido == false && objetivo.EstaEnvenenado == false && objetivo.EstaParalizado == false && objetivo.EstaQuemado == false)
                {
                    Random random = new Random();
                    int probabilidad = random.Next(0, 10);
                    if (ataque.Tipo.NombreTipo == "Fuego")
                    {
                        if (probabilidad <= 1) 
                        {
                            objetivo.EstaQuemado = true;
                        }
                    }
                    else if (ataque.Tipo.NombreTipo == "Electrico")
                    {
                        if (probabilidad <= 1) 
                        {
                            objetivo.EstaParalizado = true;
                        }
                    }
                    else if (ataque.Tipo.NombreTipo == "Veneno")
                    {
                        if (probabilidad <= 3) 
                        {
                            objetivo.EstaEnvenenado = true;
                        }
                    }
                    else if (ataque.Tipo.NombreTipo == "Planta")
                    {
                        objetivo.EstaDormido = true;
                    }
                
                
                }
               
            }
            double efectividadObjetivo= ataque.Tipo.efectividadDeDaño(objetivo.Tipo);  // Calcula la efectividad del tipo del ataque en relación con el tipo del objetivo
            int dañoTotal = (int)(ataque.Daño * efectividadObjetivo); //Cálculo del daño del ataque aumentado con la efectividad del tipo
            objetivo.recibirDaño(dañoTotal); //Realiza el ataque restándole salud al objetivo
            return dañoTotal;
        
        }

        
        public string ItemSuperPocion(Pokemon pokemon)
        {
            if (SuperPociones > 0)
            {
                pokemon.Curar(70); 
                SuperPociones-=1;
                return $"{Nombre} usó una Súper poción, {pokemon.Nombre} recupera 70 puntos de HP.\n" + $"Quedan {SuperPociones} Súper pociones para utilizar.";
            }
            return "No quedan Súper pociones para utilizar";
        }
        
        public string ItemRevivir(Pokemon pokemon)
        {
            if (Revivir > 0 && pokemon.Salud == 0)
            {
                pokemon.Revivir(0.5); 
                Revivir-=1;
                return $"{Nombre} usó el item Revivir en {pokemon.Nombre}.\n"+ $"No quedan más items de Revivir para utilizar.";
            }
            return "No poseé más items para Revivir o el Pokémon aún no está debilitado.";
        }
        
        public string ItemCuraTotal(Pokemon pokemon)
        {
            if (CuraTotal > 0 && (pokemon.EstaDormido || pokemon.EstaEnvenenado || pokemon.EstaParalizado || pokemon.EstaQuemado))
            {
                pokemon.CurarEfecto(); 
                CuraTotal-=1;
                return $"{Nombre} usó una Cura Total en {pokemon.Nombre}.\n" + $"Queda 1 item disponible de Cura total para utilizar.";
            }
            return "No quedan Curas Totales para utilizar o el Pokémon no tiene un efecto.";
        }


        public string MostrarPokemon()
        {
            foreach (Pokemon pokemon in Equipo)
            {
                return $"{pokemon.Nombre}";
            }

            return null;
        }
        public string UnirseAListaDeEspera(List<Entrenador> listaEspera)
        {
            listaEspera.Add(this);
            return $"{Nombre} se ha unido a la lista de espera para una batalla.";
        }

        public string AgregarPokemonAlEquipo(Pokemon pokemon)
        {
            int cantidad = Equipo.Count;
            if (cantidad < 6)
            {
                Equipo.Add(pokemon);
                return $"¡Se ha agragado a {pokemon.Nombre} al equipo!";
            }
            return $"No se puede agregar a {pokemon.Nombre} al equipo, este ya está completo.";
        }

        public string CambiarPokemonDeEquipo(Pokemon pokemonEnEquipo, Pokemon pokemonQueEntra)
        {
            if (pokemonEnEquipo == pokemonQueEntra)
            {
                return $"Se quiere cambiar al mismo pokemon";
            }
            int cantidad = Equipo.Count; 
            for (int i = 0; i < cantidad; i++)
            {
                if (Equipo[i] == pokemonEnEquipo)
                {
                    Equipo[i] = pokemonQueEntra;
                    return $"Se ha cambiado a {pokemonEnEquipo.Nombre} por {pokemonQueEntra.Nombre}";
                }
            }

            return $"{pokemonEnEquipo.Nombre} no está en el equipo";
        }
    }
}