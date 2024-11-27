using Discord.Commands;
using program;
namespace Library.Commands;

/// <summary>
/// Esta clase implementa comandos de batalla, incluyendo usar ataques y objetos.
/// </summary>
public class ComandosDeBatalla : ModuleBase<SocketCommandContext>
{
    [Command("usarobjeto")]
    [Summary("Usa un objeto del inventario en un Pokémon.")]
    public async Task UsarObjeto(
        [Summary("Nombre del objeto.")] string nombreObjeto,
        [Summary("Nombre del Pokémon.")] string nombrePokemon)
    {
        string entrenador = CommandHelper.GetDisplayName(Context); 
        string resultado = Facade.UsarObjeto(entrenador, nombreObjeto, nombrePokemon);
        await ReplyAsync(resultado);
    }

    [Command("inventario")]
    [Summary("Muestra los objetos disponibles en el inventario.")]
    public async Task MostrarInventario()
    {
        string entrenador = CommandHelper.GetDisplayName(Context); 
        string resultado = Facade.MostrarInventario(entrenador);
        await ReplyAsync(resultado);
    }
}