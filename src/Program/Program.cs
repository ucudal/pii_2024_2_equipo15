using Ucu.Poo.DiscordBot.Services;

namespace program
{
    class Bot
    {
        //Inicialización de programa con bot
        private static void Main()
        {
            DemoBot();
        }
        
        private static void DemoBot()
        {
            BotLoader.LoadAsync().GetAwaiter().GetResult();
        }
    }
}