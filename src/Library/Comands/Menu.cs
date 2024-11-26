using Discord.Commands;
using program;

namespace Library.Commands;

public class Menu : ModuleBase<SocketCommandContext>
{
    [Command("menu")]
    [Summary("Muestra la lista de comandos disponibles.")]
    public async Task ExecuteAsync()
    {
        string comandos =
            """
            **Menu Principal: Comandos Disponibles**

            - **!menu**: Muestra este menú con la lista de comandos disponibles.
            - **!unirse**: Ingresa al usuario al Lobby.
            - **!salir**: Saca al usuario del Lobby.
            - **!seleccionar [nombre del Pokémon]**: Agrega al equipo del jugador el Pokémon seleccionado.
            - **!listapokemon**: Muestra todos los Pokémon disponibles para elegir en el equipo.
            - **!listaataques**: Muestra los ataques disponibles para cada Pokémon.
            - **!CentroJuego**: Enseña quiénes están en el centro de juego.
            - **!verVida [nombre del oponente (opcional)]**: Muestra los Pokémon de los jugadores y su vida.
            - **!cambiar [nombre del Pokémon]**: Cambia el Pokémon activo del jugador.
            - **!usar [nombre del ataque]**: Usa un ataque durante el turno actual.
            - **!iniciar [nombre del oponente (opcional)]**: Inicia una batalla entre dos entrenadores.
            """;

        await ReplyAsync(comandos);
    }
}