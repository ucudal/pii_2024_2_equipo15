/*using program;
using Discord.Commands;

namespace Library.Commands
{
    public class ProhibirPokemon : ModuleBase<SocketCommandContext>
    {
        [Command("prohibirpokemon")]
        [Summary("Prohibe Pokémon para la batalla.")]
        public async Task ExecuteAsync(
            [Remainder] [Summary("El nombre del pokemon que deseas prohibir.")] string? tipo = null)
        { if (string.IsNullOrWhiteSpace(tipo))
            { await ReplyAsync("Debes especificar un pokemon para prohibir");
                return;
            }
            string resultado = Facade.ProhibirPokemon(pokemon);
            await ReplyAsync(resultado);
        }
    }
}*/