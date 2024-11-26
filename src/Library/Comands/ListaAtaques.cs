using Discord.Commands;
using program;

namespace Library.Commands;

public class ListaAtaquesCommand : ModuleBase<SocketCommandContext>
{
    [Command("listaataques")]
    [Summary("Muestra todos los ataques disponibles de cada Pokémon.")]
    public async Task ExecuteAsync()
    {
        string resultado = Facade.MostrarAtaquesDePokemones();
        await ReplyAsync(resultado);
    }
}