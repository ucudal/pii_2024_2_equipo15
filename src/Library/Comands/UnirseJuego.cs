using Discord.Commands;
using program;

namespace Library.Commands;

public class UnirseJuego : ModuleBase<SocketCommandContext>
{
    [Command("unirse")]
    [Summary("Ingresa al usuario al Lobby")]
    public async Task ExecuteAsync()
    {
        string nombre = CommandHelper.GetDisplayName(Context);
        string resultado = Facade.IngresarUsuarioAlCentro(nombre);
        await ReplyAsync(resultado);
    }

}