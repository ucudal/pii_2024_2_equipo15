namespace program;

public class Batallas
{
    public Entrenador entrenador1 {get; set;}
    public Entrenador entrenador2 {get; set;}
    public Entrenador entrenadorActual {get; set;}
    public int turno {get; set;}
    
    public bool esquivo;
    
    public Batallas(Entrenador AshKetchup, Entrenador diezMedallasGary)
    {
        entrenador1 = AshKetchup;
        entrenador2 = diezMedallasGary;
        entrenadorActual = entrenador1;
        turno = 1;
    }

    public bool ChequerMuerte()
    {
        return !entrenador1.TienePokemonesVivos() || !entrenador2.TienePokemonesVivos();
    }
    
    public bool ConfirmarSiEntrenadorEstaPeleando(Entrenador entrenadores)
    {
        if (entrenadores != null)
        {
            foreach (Entrenador entrenador in JugadoresDisponibles())
            {
                if (entrenador.Nombre == entrenador.Nombre)
                {
                    return true;
                }
            }
            
        }
        return false;
    }
    
    public bool ConfirmandoEquipoCompleto()
    {
        return entrenador1.RecibirEquipoPokemon().Count == 6 &&
               entrenador2.RecibirEquipoPokemon().Count == 6;
    }

    public string Iniciar(Entrenador Entrenador1, Entrenador Entrenador2)
    {
        if(entrenador1.EnBatalla && entrenador2.EnBatalla)
        {
            return "Ya hay una batalla en curso.";
        }
        entrenador1 = Entrenador1;
        entrenador2 = Entrenador2;
        entrenador1.EnBatalla = true;
        entrenador2.EnBatalla = true;
        Random Turno = new Random();
        if (Turno.Next(0, 2) == 0)
        {
            entrenadorActual = entrenador1;
        }
        else
        {
            entrenadorActual = entrenador2;
        }
        return $"{entrenador1.Nombre} y {entrenador2.Nombre} están listos para la batalla \n {entrenadorActual.Nombre} empieza.";
    }

    public string Atacar(IHabilidad habilidad)
    {
        Random random = new Random();
        Pokemon atacante = entrenadorActual.PokemonActivo;
        Pokemon defensor = (entrenadorActual == entrenador1) ? entrenador2.PokemonActivo : entrenador1.PokemonActivo;
        string estadoResultado;
        
        if (habilidad == null)
        {
            return "No se eligió ninguna habilidad.";
        }

        habilidad.Puntos_de_Poder--;
        
        if (atacante.Estado == "paralizado" && random.Next(0, 100) < 100)
        {
            CambiarTurno();
            return $"{atacante.Nombre} está paralizado. No se puede mover. \n";
        }

        if (habilidad.EsDobleTurno)
        {
            atacante.HabilidadCargando = habilidad;
            CambiarTurno();
            return $"{atacante.Nombre} está cargando la habilidad {habilidad.Nombre}...\n";
        }

        if (atacante.HabilidadCargando != null)
        {
            habilidad = atacante.HabilidadCargando;
            atacante.HabilidadCargando = null;
            bool esEsquivo = esquivo;
            esquivo = false;

            string resultadoAtaque = Pokemon.EjecutarAtaque(atacante, defensor, habilidad, esEsquivo);
            string cambioTurno = CambiarTurno();
            estadoResultado = VerificarEstado(atacante);
            return resultadoAtaque + "\n" + estadoResultado + "\n" + cambioTurno;
        }

        bool esEsquivoNormal = esquivo;
        esquivo = false;
        string resultadoAtaqueNormal = Pokemon.EjecutarAtaque(atacante, defensor, habilidad, esEsquivoNormal);
        string cambioTurnoNormal = CambiarTurno();
        estadoResultado = VerificarEstado(atacante);
        return resultadoAtaqueNormal + "\n" + estadoResultado + "\n" + cambioTurnoNormal;
    }

    public List<Entrenador> JugadoresDisponibles()
    {
        return new List<Entrenador> { entrenador1, entrenador2 };
    }
    
    public string Esquivar()
    {
        Pokemon atacante = entrenadorActual.PokemonActivo;
        string estadoResultado = VerificarEstado(atacante);
        if (!string.IsNullOrEmpty(estadoResultado))
        {
            return estadoResultado;
        }
        esquivo = true;
        return $"{atacante.Nombre} de {entrenadorActual.Nombre} está preparado para esquivar el proximo movimiento\n";
    }
    
    public bool StatusBatalla()
    {
        foreach (var entrenador in JugadoresDisponibles())
        {
            bool continua = false;
            foreach (var pokemon in entrenador.RecibirEquipoPokemon())
            {
                if (pokemon.Vida > 0)
                {
                    continua = true;
                }
            }
            if (!continua)
            {
                return false;
            }
        }
        return true;
    }

    public string CambiarPokemon(Pokemon pokemon)
    {
        if (pokemon == null)
        {
            return "Ese Pokémon no está en tu equipo.";
        }
        if (pokemon.Nombre == entrenadorActual.PokemonActivo.Nombre)
        {
            return "Ese ya es tu Pokémon activo.";
        }
        bool cambioExitoso = entrenadorActual.FijarPokemonActual(pokemon);

        if (cambioExitoso)
        {
            return $"{pokemon.Nombre} AHORA SE ENCUENTRA A LA CABEZA. \n";
        }
        return $"{entrenadorActual.Nombre} no pudo cambiar a {pokemon.Nombre}.";
    }
    
    public string UsarMochila(Objetos? objeto, Pokemon? pokemon)
    {
        Entrenador entrenador = JugadoresDisponibles()[turno];
        if (pokemon == null)
        {
            return $" {JugadoresDisponibles()[turno].Nombre} ese pokemon no está en tu equipo.\nBusca otro.\n";
        }
        if (objeto == null)
        {
            return $"{JugadoresDisponibles()[turno].Nombre} no cuentas con ese objeto.\nBusca otro.\n";
        }
        string final = objeto.Usar(pokemon, entrenadorActual);
        if (final.Contains("recuperaron"))
        {
            Objetos objetoEnMochila = entrenador.Mochila.FirstOrDefault(o => o.Nombre == objeto.Nombre);
            if (objetoEnMochila != null)
            {
                entrenador.Mochila.Remove(objetoEnMochila);
            }
        }
        return final;
    }

    public string VerificarEstado(Pokemon atacante)
    {
        Random random = new Random();
        int turnos_noqueado = 4;
        switch (atacante.Estado)
        {
            case "envenenado":
                atacante.Vida -= (int)(atacante.VidaBase * 0.05);
                if (atacante.Vida <= 0)
                {
                    atacante.Vida = 0;
                    return $"{atacante.Nombre} fue derrotado por el veneno.";
                }
                return $"{atacante.Nombre} pierde vida por envenenamiento. Vida restante: {atacante.Vida} / {atacante.VidaBase}";
                break;
            
            case "quemado":
                atacante.Vida -= (int)(atacante.VidaBase * 0.10);
                if (atacante.Vida <= 0)
                {
                    atacante.Vida = 0;
                    return $"{atacante.Nombre} fue derrotado por la quemadura.";
                }
                return $"{atacante.Nombre} está quemado y pierde {(int)(atacante.VidaBase * 0.10)} HP. Vida restante: {atacante.Vida} / {atacante.VidaBase}";
                break;

            case "noqueado":
                if (random.Next(1, 5) < turnos_noqueado)
                {
                    atacante.Estado = null;
                    return $"{atacante.Nombre} se ha recuperado del noqueo y puede volver a atacar.";
                }
                return $"{atacante.Nombre} está noqueado. No puede moverse.";
                
                break;
        }

        return "";
    }

    public string CambiarTurno()
    {
        if (ChequerMuerte())
        {
            string ganador = DeterminarGanador();
            return $"LA BATALLA TERMINÓ! EL GANADOR ES {ganador}!";
        }
        
        entrenadorActual = (entrenadorActual == entrenador1) ? entrenador2 : entrenador1;
        Pokemon atacante = entrenadorActual.PokemonActivo;
        VerificarEstado(atacante);
        Pokemon defensor = (entrenadorActual == entrenador1) ? entrenador2.PokemonActivo : entrenador1.PokemonActivo;
        if (atacante.HabilidadCargando != null)
        {
            IHabilidad habilidad = atacante.HabilidadCargando;
            atacante.HabilidadCargando = null;
            bool esEsquivo = esquivo;
            esquivo = false;

            string resultadoAtaque = Pokemon.EjecutarAtaque(atacante, defensor, habilidad, esEsquivo);
            string estadoResultado = VerificarEstado(atacante);
            estadoResultado += "\n";
            string estaCargando = $"{atacante.Nombre} TERMINÓ DE CARGAR LA HABILIDAD!";
            entrenadorActual = (entrenadorActual == entrenador1) ? entrenador2 : entrenador1;
            return estaCargando + resultadoAtaque + "\n" + estadoResultado;
        }
        return null;
    }
    
    public string DeterminarGanador()
    {
        if (entrenador1.TienePokemonesVivos()) return entrenador1.Nombre;
        if (entrenador2.TienePokemonesVivos()) return entrenador2.Nombre;
        return "Empate";
    }
    
}