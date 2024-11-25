using Discord;
using Discord.Commands;

namespace Library.Commands;

/// <summary>
/// Comando para que los usuarios puedan registrarse como entrenadores Pokémon.
/// </summary>
public class RegisterCommand : ModuleBase<SocketCommandContext>
{
    
    [Command("register")]
    [Summary("Registra al usuario como entrenador Pokémon.")]
    public async Task RegisterAsync()
    {
        string userName = Context.User.Username;

        // Verifica si el usuario ya está registrado
        if (Facade.Instance.ExisteEntrenador(userName))
        {
            await ReplyAsync($"¡Ya estás registrado como entrenador, {userName}!");
            return;
        }

        // Crea un nuevo entrenador
        var nuevoEntrenador = new Entrenador(userName);

        // Registra al entrenador en el sistema
        Facade.Instance.AgregarEntrenador(nuevoEntrenador);

        // Confirma el registro
        await ReplyAsync($"¡Entrenador registrado con éxito, {userName}! Ahora puedes comenzar a jugar.");
    }
}