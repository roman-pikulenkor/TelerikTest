﻿using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;

namespace RadComboBoxTest.Browser
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            var host = builder.Build();
            await host.RunAsync();
        }

        public static void RunApplication()
        {
            Application.RunApplication(() =>
            {
                Console.WriteLine("Run Application");
                try
                {
                    var app = new RadComboBoxTest.App();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            });
        }
    }
}
