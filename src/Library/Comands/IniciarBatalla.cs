using Discord.Commands;
using program;

namespace Library.Commands;

public class IniciarBatalla : ModuleBase<SocketCommandContext>
{
    [Command("iniciar")]
    [Summary("Empieza la batalla entre dos jugadores que están en el Lobby.")]
    public async Task ExecuteAsync(
        [Remainder] [Summary("Es opcional tener un segundo entrenador elegido.")] string? entrenador2 = null)
    {
        string entrenador1 = CommandHelper.GetDisplayName(Context);
        string resultado = Facade.IniciarBatalla(entrenador1, entrenador2);
        await ReplyAsync(resultado);
    }

}