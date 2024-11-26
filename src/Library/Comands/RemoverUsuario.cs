using Discord.Commands;
using program;
namespace Library.Commands;

public class RemoverUsuario : ModuleBase<SocketCommandContext>
{
    [Command("salir")]
    [Summary("Saca al usuario del Lobby")]
  
    public async Task ExecuteAsync()
    {
        string nombre = CommandHelper.GetDisplayName(Context);
        await ReplyAsync(Facade.SacarEntrenadores(nombre));
    }
}