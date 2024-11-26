using Discord.Commands;
using program;

namespace Library.Commands;
public class VerCentroJuego : ModuleBase<SocketCommandContext>
{
    [Command("CentroJuego")]
    [Summary("Enseña quienes estan en el centro de juego")]
 
    public async Task ExecuteAsync()
    {
        await ReplyAsync(Facade.VerCentroJuego());
    }
}