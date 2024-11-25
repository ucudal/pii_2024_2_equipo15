using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace Library.Commands;

/// <summary>
/// Comando para iniciar una batalla Pokémon entre dos entrenadores.
/// </summary>
public class PokemonBattleCommand : ModuleBase<SocketCommandContext>
{
    [Command("pokemonbattle")]
    [Summary(
        """
        Une al jugador que envía el mensaje con el oponente que se recibe
        como parámetro, si lo hubiera, en una batalla Pokémon; si no se recibe un
        oponente, lo une con cualquiera que esté esperando para jugar.
        """)]
    public async Task ExecuteAsync(
        [Remainder]
        [Summary("Display name del oponente, opcional")]
        string? opponentDisplayName = null)
    {
        // Nombre del jugador que envía el comando
        string playerName = CommandHelper.GetDisplayName(Context);
        SocketGuildUser? opponentUser = CommandHelper.GetUser(Context, opponentDisplayName);

        // Validación: Si el oponente no existe, enviar un mensaje de error
        if (opponentUser == null)
        {
            await ReplyAsync($"No se encontró un usuario con el nombre: {opponentDisplayName}");
            return;
        }

        string opponentName = opponentUser.DisplayName;

        // Crear entrenadores para la batalla
        Entrenador entrenador1 = Facade.Instance.ObtenerEntrenador(playerName);
        Entrenador entrenador2 = Facade.Instance.ObtenerEntrenador(opponentName);

        // Validación: Verificar que ambos entrenadores tienen equipos válidos
        if (entrenador1.Equipo == null || entrenador1.Equipo.Count == 0)
        {
            await ReplyAsync($"{playerName}, necesitas un equipo Pokémon para comenzar una batalla.");
            return;
        }
        if (entrenador2.Equipo == null || entrenador2.Equipo.Count == 0)
        {
            await ReplyAsync($"{opponentName} no tiene un equipo Pokémon para la batalla.");
            return;
        }

        // Iniciar la batalla
        Batalla batalla = new Batalla(entrenador1, entrenador2);
        await ReplyAsync($"¡La batalla entre {entrenador1.Nombre} y {entrenador2.Nombre} ha comenzado!");

        // Mensaje inicial con el turno actual
        string turnoInicial = batalla.MostrarTurnoActual();
        await ReplyAsync(turnoInicial);

        // Simulación de la batalla (lógica adicional puede agregarse aquí)
        while (batalla.ConocerGanador() == null)
        {
            // Mostrar estado del turno actual
            string estadoTurno = batalla.MostrarTurnoActual();
            await ReplyAsync(estadoTurno);

            // Verificar si algún Pokémon ha sido debilitado
            string? pokemonDebilitado = batalla.PokemonDebilitado();
            if (pokemonDebilitado != null)
            {
                await ReplyAsync(pokemonDebilitado);
            }

            // Cambiar turno
            batalla.CambiarTurno();
        }

        // Declarar el ganador
        string ganador = batalla.ConocerGanador();
        await ReplyAsync(ganador);
    }
}
