using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder().ConfigureServices((_, services) => services
        .AddTransient<HelloWorldPatterns.Facades.IConsoleFacade>((_) => new HelloWorldPatterns.Facades.ConsoleFacade())
        .AddTransient<HelloWorldPatterns.Services.IConsoleService>((s) => 
            new HelloWorldPatterns.Services.ConsoleService(
                s.GetService<HelloWorldPatterns.Facades.IConsoleFacade>(),
                s.GetService<HelloWorldPatterns.Mediators.InputMediator>(),
                HelloWorldPatterns.Factories.IteratorFactory.CreateIterator<string, char>()
            ))
        .AddTransient<HelloWorldPatterns.Mediators.InputMediator>()
        .AddTransient<HelloWorldPatterns.Services.ConsoleService>()
        .AddHostedService<HelloWorldPatterns.Services.HelloWorldService>()
    ).Build();

await host.RunAsync();
