using Discord.Commands;
using program;

namespace Library.Commands;

public class ListaPokemonCommand : ModuleBase<SocketCommandContext>
{
    [Command("listapokemon")]
    [Summary("Muestra todos los Pokémon disponibles para elegir en el equipo.")]
    public async Task ExecuteAsync()
    {
        string resultado = Facade.MostrarPokemones();
        await ReplyAsync(resultado);
    }
}