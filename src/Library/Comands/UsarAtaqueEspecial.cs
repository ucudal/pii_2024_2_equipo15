using Discord.Commands;
using program;

namespace Library.Commands
{
    public class UsarAtaqueEspecial : ModuleBase<SocketCommandContext>
    {
        [Command("usarEspecial")]
        [Summary("Usar un ataque especial durante tu turno.")]
        public async Task ExecuteAsync([Remainder] string ataque)
        {
            string entrenador = CommandHelper.GetDisplayName(Context);
            string resultado = Facade.UsarHabilidad(entrenador, ataque);
            await ReplyAsync(resultado);
        }
    }
}