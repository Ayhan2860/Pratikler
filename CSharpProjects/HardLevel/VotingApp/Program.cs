// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VotingApp;
using VotingApp.Extensions;

IHost host = CreateHostBuilder(args).Build();
var scope = host.Services.CreateScope();
var services = scope.ServiceProvider;

try
{
    services.GetRequiredService<App>().Run(args);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


IHostBuilder CreateHostBuilder(string[] strings)
{
    return Host.CreateDefaultBuilder()
    .ConfigureServices((_, services) =>
    {
        services.CreateService();
        services.AddSingleton<App>();
    });
}










