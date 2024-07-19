using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using Project1_WindowsService;

var configFile = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true).Build();

var services = new ServiceCollection();
services
    .AddLogging(log => { log.ClearProviders(); log.AddNLog(); }) //i krijon vete logFactory logProvider
    .AddSingleton(configFile)
    .AddScoped<TestLogin>()
    ;

//BuildServiceProvider() e krijon Servisin per injektim
using (var serviceProvider = services.BuildServiceProvider())
{
    var objekti = serviceProvider.GetRequiredService<TestLogin>();
    objekti.Shenim();
}
