using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace Library.Commands;

public class MenuCommand : ModuleBase<SocketCommandContext>
{
    [Command("menu")]
    [Summary("Muestra un menú interactivo con opciones de acciones.")]
    public async Task ShowMenuAsync()
    {
        // Crea un mensaje inicial con un menú de botones
        var builder = new ComponentBuilder()
            .WithButton("Registrar Entrenador", "register_trainer", ButtonStyle.Primary)
            .WithButton("Ver Entrenador", "view_trainer", ButtonStyle.Secondary)
            .WithButton("Iniciar Batalla", "start_battle", ButtonStyle.Danger);

        await ReplyAsync("Selecciona una acción:", components: builder.Build());
    }
}