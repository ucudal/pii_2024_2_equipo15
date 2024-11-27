/*using program;
using Discord.Commands;

namespace Library.Commands
{
    public class ProhibirItem : ModuleBase<SocketCommandContext>
    {
        [Command("prohibir-tipo")]
        [Summary("Prohíbe un tipo de Pokémon para la batalla.")]
        public async Task ExecuteAsync(
            [Remainder] [Summary("El nombre del tipo que deseas prohibir.")] string? tipo = null)
        { if (string.IsNullOrWhiteSpace(tipo))
            { await ReplyAsync("Debes especificar un tipo para prohibir.");
                return;
            }
            string resultado = Facade.ProhibirItem(item);
            await ReplyAsync(resultado);
        }
    }
}*/