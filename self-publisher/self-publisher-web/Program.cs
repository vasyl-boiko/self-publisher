﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Publisher.DB.Interfaces;
using System.IO;

namespace SelfPublisher.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var config = builder.Build(); 

            using (var scope = host.Services.CreateScope()) 
            {
                var services = scope.ServiceProvider;
                var factory = services.GetRequiredService<IRepositoryContextFactory>();
                factory.CreateDbContext(config.GetConnectionString("DefaultConnection")).Database.Migrate(); 
            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
