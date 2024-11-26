using Discord.Commands;
using program;

namespace Library.Commands;

public class IniciarBatalla : ModuleBase<SocketCommandContext>
{
    [Command("iniciar")]
    [Summary("Inicia una batalla entre dos entrenadores.")]
    public async Task ExecuteAsync([Remainder] string? oponente = null)
    {
        // Obtener el nombre del entrenador que ejecuta el comando
        string entrenador1 = CommandHelper.GetDisplayName(Context);

        // Verificar si el entrenador que ejecuta el comando está en el lobby
        var jugador = GameManager.ObtenerEntrenador(entrenador1);
        if (jugador == null)
        {
            await ReplyAsync($"No estás registrado en el lobby. Usa el comando adecuado para unirte.");
            return;
        }

        // Comprobar si el equipo del entrenador tiene al menos un Pokémon
        if (jugador.Pokemones.Count == 0)
        {
            await ReplyAsync($"Tu equipo no tiene Pokémon. Selecciona tus Pokémon antes de iniciar la batalla.");
            return;
        }

        // Intentar iniciar la batalla contra el oponente indicado o un rival aleatorio
        string resultado = Facade.IniciarBatalla(entrenador1, oponente);

        // Enviar el resultado de la acción
        await ReplyAsync(resultado);
    }
}