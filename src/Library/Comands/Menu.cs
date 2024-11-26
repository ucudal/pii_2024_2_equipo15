using Discord.Commands;
using program;
namespace Library.Commands;

public class Menu : ModuleBase<SocketCommandContext>
{
    [Command("Menu")]
    [Summary("Muestra la lista de comandos disponibles.")]
    public async Task ExecuteAsync()
    {
        string comandos =
            """
            Menu principal:
            """;

        await ReplyAsync(comandos);
    }
}