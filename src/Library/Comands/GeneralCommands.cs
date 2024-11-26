using Discord.Commands;
using System.Threading.Tasks;

namespace Library.Commands
{
    public class GeneralCommands : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        [Summary("Responde con 'Pong!' para verificar que el bot está funcionando.")]
        public async Task PingAsync()
        {
            await ReplyAsync("¡Pong!");
        }

        [Command("hola")]
        [Summary("Responde con un saludo personalizado.")]
        public async Task HolaAsync()
        {
            await ReplyAsync($"¡Hola, {Context.User.Username}!");
        }
    }
}