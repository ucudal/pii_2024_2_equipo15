using Discord.Commands;
namespace Library.Commands;
using program;
public class CentroJuego : ModuleBase<SocketCommandContext>
{
    [Command("centro")]
    [Summary("Juagdores en el centro de juego")]
    public async Task ExecuteAsync()
    {
        await ReplyAsync(Facade.VerCentroJuego());
    }
}