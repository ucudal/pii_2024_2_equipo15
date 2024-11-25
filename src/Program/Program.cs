using Microsoft.Extensions.DependencyInjection;
using Library.Services;
using Microsoft.Extensions.Logging;


namespace Program;

/// <summary>
/// Un programa que implementa un bot de Discord.
/// </summary>
internal static class Program
{
    /// <summary>
    /// Punto de entrada al programa.
    /// </summary>
    private static async Task Main(string[] args)
    {
        // Configurar el contenedor de dependencias
        var serviceProvider = new ServiceCollection()
            .AddLogging(options =>
            {
                options.ClearProviders();
                options.AddConsole();
            })
            .AddScoped<IBot, Bot>() // Vincula IBot con Bot
            .BuildServiceProvider();

        // Resuelve la implementación de IBot desde el contenedor
        IBot bot = serviceProvider.GetRequiredService<IBot>();

        // Inicia el bot
        await bot.StartAsync(serviceProvider);

        Console.WriteLine("Bot en ejecución. Presiona cualquier tecla para detener...");
        Console.ReadKey();

        // Detiene el bot
        await bot.StopAsync();
    }
}