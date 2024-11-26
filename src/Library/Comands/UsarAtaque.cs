using Discord.Commands;
using program;
namespace Library.Commands;

public class UsarAtaque : ModuleBase<SocketCommandContext>
{

    [Command("usar")]
    [Summary("Usar un ataque durante tu turno.")]
    public async Task ExecuteAsync(
        [Remainder] [Summary("El nombre del ataque a usar.")] string? ataque = null)
    {
        string entrenador = CommandHelper.GetDisplayName(Context);
        string resultado = Facade.UsarHabilidad(entrenador, ataque);
        await ReplyAsync(resultado);
    }

}