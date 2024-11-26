using Discord.Commands;
using program;
namespace Library.Commands;

public class VerVida : ModuleBase<SocketCommandContext>
{
    [Command("verVida")]
    [Summary("Muestra los Pokémon de los jugadores.")]
    public async Task ExecuteAsync(
        [Remainder] [Summary("Nombre del oponente (opcional).")] string? oponente = null)
    {
        string entrenador = CommandHelper.GetDisplayName(Context);
        string resultado = Facade.VerPokemones(entrenador, oponente);
        await ReplyAsync(resultado);
    }

}