using Discord.Commands;
using program;
namespace Library.Commands;

public class CambioPokemon : ModuleBase<SocketCommandContext>
{

    [Command("cambiar")]
    [Summary("Cambia el Pokémon activo.")]
    public async Task ExecuteAsync(
        [Remainder] [Summary("El nombre del Pokémon a cambiar.")] string pokemonName)
    {
        string entrenador = CommandHelper.GetDisplayName(Context);
        string resultado = Facade.CambiarPokemones(entrenador, pokemonName);
        await ReplyAsync(resultado);
    }


}