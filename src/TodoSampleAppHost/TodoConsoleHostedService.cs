using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TodoSampleAppHost
{
    public class TodoConsoleHostedService : HostedService
    {
        //public async Task StartAsync(CancellationToken cancellationToken)
        //{
        //    await Console.Out.WriteLineAsync("Hello World from Hosted service!");
        //}

        //public async Task StopAsync(CancellationToken cancellationToken)
        //{
        //    await Console.Out.WriteLineAsync("Exiting from Hosted service!");
        //}

        protected override Task ExecuteAsync(CancellationToken cancellationToken)
        {
            return Console.Out.WriteLineAsync("Hello World from Hosted service!");
        }
    }
}
