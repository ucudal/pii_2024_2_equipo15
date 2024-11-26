using Discord.Commands;
using program;
namespace program;

public class VerCentroJuego : ModuleBase<SocketCommandContext>
{
    [Command("lobby")]
    [Summary("Enseña quienes estan en el centro de juego")]
 
    public async Task ExecuteAsync()
    {
        await ReplyAsync(Facade.VerCentroJuego());
    }
}