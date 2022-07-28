using Microsoft.Extensions.Hosting;

namespace HelloWorldPatterns.Services
{
    internal class HelloWorldService : IHostedService
    {
        private readonly IConsoleService _consoleService;
        public HelloWorldService(
            IConsoleService consoleService,
            IHostApplicationLifetime appLifetime)
        {
            _consoleService = consoleService;
            appLifetime.ApplicationStarted.Register(onStarted);
        }

        private void onStarted() 
        {
            _consoleService
                .Write("Hello, ")
                .Write("World!")
                .ToConsole();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _consoleService
                .Write("Goodbye!")
                .ToConsole();
            
            return Task.CompletedTask;
        }
    }
}
