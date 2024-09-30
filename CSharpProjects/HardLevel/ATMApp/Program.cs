// See https://aka.ms/new-console-template for more information
using ATMApp;
using ATMApp.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


IHost host = CreateHostBuilder(args).Build();
var scope = host.Services.CreateScope();
var services = scope.ServiceProvider;

try
{
    services.GetRequiredService<KrmnBank>().Execute(args);
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
        services.AddScoped<IBankCardRepository, BankCardRepository>();

        services.AddSingleton<KrmnBank>();
    });
}










