namespace Library.Services
{
    public interface IBot
    {
        Task StartAsync(IServiceProvider serviceProvider);
        Task StopAsync();
    }
}