using Discord.Commands;
using Discord.WebSocket;
using Library;

namespace Library.Commands;

public static class CommandHelper
{
    public static class AyudanteDeComandos
    {
        public static string ObtenerNombreDeUsuario(SocketCommandContext context)
        {
            return context.User.Username; 
        }
    }
    public static string GetDisplayName(
        SocketCommandContext context, 
        string? name = null)
    {
        if (name == null)
        {
            name = context.Message.Author.Username;
        }
        
        foreach (SocketGuildUser user in context.Guild.Users)
        {
            if (user.Username == name
                || user.DisplayName == name
                || user.Nickname == name
                || user.GlobalName == name)
            {
                return user.DisplayName;
            }
        }

        return name;
    }

    public static SocketGuildUser? GetUser(
        SocketCommandContext context,
        string? name)
    {
        if (name == null)
        {
            return null;
        }
        
        foreach (SocketGuildUser user in context.Guild.Users)
        {
            if (user.Username == name
                || user.DisplayName == name
                || user.Nickname == name
                || user.GlobalName == name)
            {
                return user;
            }
        }

        return null;
    }
}