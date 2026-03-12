using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetDaemon.AppModel;
using NetDaemon.Client.Extensions;
using NetDaemon.Client.HomeAssistant.Extensions;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((ctx, config) =>
    {
        // follow NetDaemon getting started recommendations: JSON configuration
        config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        config.AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);
    })
    .ConfigureServices((ctx, services) =>
    {
        // Add NetDaemon dependencies
        services.AddHomeAssistantClient();
        services.AddNetDaemonAppModel();
        services.AddAppsFromAssembly(typeof(Program).Assembly);

        // register custom services here
        // services.AddSingleton<IBatteryManager, BatteryManager>();
        // services.AddSingleton<ISolarForecastService, SolarForecastService>();
        // services.AddSingleton<ITariffService, TariffService>();
    });

var host = builder.Build();

await host.RunAsync();
