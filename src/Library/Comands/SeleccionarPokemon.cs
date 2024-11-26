using Discord.Commands;
using program;
namespace Library.Commands;

/// <summary>
/// Esta clase implementa el comando 'elegir' del bot.
/// </summary>
public class ElegirCommand : ModuleBase<SocketCommandContext>
{
    [Command("seleccionar")]
    [Summary("Agrega al equipo del jugador el Pokémon seleccionado.")]
    public async Task ExecuteAsync(
        [Remainder] [Summary("Nombre del Pokémon.")] string pokemonName)
    {
        string entrenador = CommandHelper.GetDisplayName(Context);
        string resultado = Facade.SeleccionarEquipo(entrenador, pokemonName);
        await ReplyAsync(resultado);
    }

}