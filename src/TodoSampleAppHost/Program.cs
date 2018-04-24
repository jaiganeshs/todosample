using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace TodoSampleAppHost
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = new HostBuilder()

                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    //config.AddJsonFile("appsettings.json", optional: true);
                    //config.AddEnvironmentVariables();
                    //if (args != null)
                    //{
                    //    config.AddCommandLine(args);
                    //}
                })
                .ConfigureServices((hostContext, services) =>
                {
                    //services.AddOptions();
                    //services.Configure<AppConfig>(hostContext.Configuration.GetSection("AppConfig"));
                    services.AddSingleton<IHostedService, TodoConsoleHostedService>();
                })
                .ConfigureLogging((hostingContext, logging) =>
                {
                    //logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                    //logging.AddConsole();
                });
            await builder
                .UseEnvironment("Development")
                .RunConsoleAsync();
        }
    }
}
