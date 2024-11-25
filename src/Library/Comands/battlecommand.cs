/*using Discord;
using Discord.Commands;
using Discord.WebSocket;


namespace Library.Commands;

public class BattleCommand : ModuleBase<SocketCommandContext>
{
    [Command("battle")]
    [Summary(
        """
        Une al jugador que envía el mensaje con el oponente que se recibe
        como parámetro, si lo hubiera, en una batalla; si no se recibe un
        oponente, lo une con cualquiera que esté esperando para jugar.
        """)]
    public async Task ExecuteAsync(
        [Remainder]
        [Summary("Display name del oponente, opcional")]
        string? opponentDisplayName = null)
    {
        string displayName = CommandHelper.GetDisplayName(Context);
        SocketGuildUser? opponentUser = CommandHelper.GetUser(Context, opponentDisplayName);

        string result;
        if (opponentUser != null)
        {
            result = Facade.Instance.StartBattle(displayName, opponentUser.DisplayName);
            await Context.Message.Author.SendMessageAsync(result);
            await opponentUser.SendMessageAsync(result);
        }
        else
        {
            result = $"No hay un usuario {opponentDisplayName}";
        }

        await ReplyAsync(result);
    }
}*/