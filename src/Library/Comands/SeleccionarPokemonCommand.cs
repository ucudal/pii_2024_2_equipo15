using Discord.Commands;
using System.Text;
using System.Threading.Tasks;

namespace Library.Commands
{
    public class SeleccionarPokemonCommand : ModuleBase<SocketCommandContext>
    {
        [Command("seleccionar")]
        [Summary("Permite al jugador seleccionar 6 Pokémon para su equipo.")]
        public async Task SeleccionarEquipoAsync()
        {
            string jugador = Context.User.Username;

            // Verificar si el jugador ya tiene un equipo completo
            if (Facade.Instance.ExisteEntrenador(jugador) && Facade.Instance.ObtenerEntrenador(jugador).Equipo.Count == 6)
            {
                await ReplyAsync($"{jugador}, ya tienes un equipo completo de 6 Pokémon.");
                return;
            }

            // Mostrar lista de Pokémon disponibles
            var catalogo = Facade.Instance.ObtenerCatalogoPokemon();
            StringBuilder mensaje = new StringBuilder("Lista de Pokémon disponibles:\n");
            for (int i = 0; i < catalogo.Count; i++)
            {
                var pokemon = catalogo[i];
                mensaje.AppendLine($"{i + 1}. {pokemon.Nombre} (Tipo: {pokemon.Tipo.NombreTipo}, Salud: {pokemon.Salud})");
            }

            mensaje.AppendLine("\nEscribe los números de los 6 Pokémon que deseas seleccionar, separados por comas (ejemplo: `1,2,3,4,5,6`).");
            await ReplyAsync(mensaje.ToString());

            // Esperar respuesta del jugador
            var response = await NextMessageAsync(timeout: TimeSpan.FromMinutes(2));
            if (response == null)
            {
                await ReplyAsync("No respondiste a tiempo. Intenta nuevamente.");
                return;
            }

            // Procesar selección del jugador
            var indices = response.Content.Split(',')
                .Select(s => int.TryParse(s.Trim(), out int n) ? n - 1 : -1)
                .Where(i => i >= 0 && i < catalogo.Count)
                .ToList();

            if (indices.Count != 6)
            {
                await ReplyAsync("Selección inválida. Debes elegir exactamente 6 números válidos.");
                return;
            }

            // Obtener o crear entrenador
            var entrenador = Facade.Instance.ExisteEntrenador(jugador)
                ? Facade.Instance.ObtenerEntrenador(jugador)
                : new Entrenador(jugador);

            if (!Facade.Instance.ExisteEntrenador(jugador))
            {
                Facade.Instance.AgregarEntrenador(entrenador);
            }

            // Agregar Pokémon al equipo del entrenador
            foreach (int indice in indices)
            {
                var pokemonSeleccionado = catalogo[indice];
                var resultado = entrenador.AgregarPokemonAlEquipo(pokemonSeleccionado);

                if (resultado.Contains("No se puede agregar"))
                {
                    await ReplyAsync(resultado);
                }
            }

            // Mostrar equipo final
            StringBuilder equipoMensaje = new StringBuilder($"¡{jugador}, tu equipo está listo!\n");
            foreach (var pokemon in entrenador.Equipo)
            {
                equipoMensaje.AppendLine($"{pokemon.Nombre} (Tipo: {pokemon.Tipo.NombreTipo}, Salud: {pokemon.Salud})");
            }

            await ReplyAsync(equipoMensaje.ToString());
        }
    }
}
