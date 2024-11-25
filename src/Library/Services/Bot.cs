using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Library.Services
{
    public class Bot : IBot
    {
        private readonly DiscordSocketClient _client;
        private readonly CommandService _commands;
        private readonly IServiceProvider _services;

        public Bot()
        {
            var config = new DiscordSocketConfig
            {
                GatewayIntents = GatewayIntents.Guilds |
                                 GatewayIntents.GuildMessages |
                                 GatewayIntents.MessageContent |
                                 GatewayIntents.GuildMembers
            };

            _client = new DiscordSocketClient(config);
            _commands = new CommandService();
            _services = new ServiceCollection()
                .AddSingleton(_client)
                .AddSingleton(_commands)
                .BuildServiceProvider();
        }

        public async Task StartAsync(IServiceProvider serviceProvider)
        {
            // Carga el token desde UserSecrets
            var token = LoadTokenFromSecrets();

            if (string.IsNullOrEmpty(token))
            {
                Console.WriteLine("No se encontró el token en los secretos. Verifica la configuración.");
                return;
            }

            _client.Log += LogAsync;
            _client.Ready += ReadyAsync;
            _client.ButtonExecuted += HandleButtonInteractionAsync;

            await _commands.AddModulesAsync(Assembly.GetEntryAssembly(), _services);
            _client.MessageReceived += HandleCommandAsync;

            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();

            Console.WriteLine("Bot iniciado y conectado.");
        }

        public async Task StopAsync()
        {
            Console.WriteLine("Deteniendo el bot...");
            await _client.LogoutAsync();
            await _client.StopAsync();
        }

        private string LoadTokenFromSecrets()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<Bot>(); // Vincula UserSecrets al proyecto

            var configuration = builder.Build();
            return configuration["DiscordToken"]; // Lee el token
        }

        private async Task LogAsync(LogMessage log)
        {
            Console.WriteLine(log.ToString());
        }

        private async Task ReadyAsync()
        {
            Console.WriteLine("Bot conectado y listo.");
        }

        private async Task HandleCommandAsync(SocketMessage messageParam)
        {
            var message = messageParam as SocketUserMessage;
            var context = new SocketCommandContext(_client, message);

            if (message == null || message.Author.IsBot) return;

            int argPos = 0;
            if (message.HasCharPrefix('!', ref argPos))
            {
                await _commands.ExecuteAsync(context, argPos, _services);
            }
        }

        private async Task HandleButtonInteractionAsync(SocketMessageComponent component)
        {
            await component.RespondAsync("Interacción no implementada aún."); // Placeholder
        }
    }
}
