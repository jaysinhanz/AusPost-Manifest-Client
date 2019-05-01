using System;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ECFDataLayer;
using ECFDataLayer.Repositories;

namespace ManifestClient
{
    class Program
    {
        private static IConfiguration Configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();
           var repo= serviceProvider.GetService<ManifestRepository>();
           var result = repo.GetFirstManifest();

        }

        private static void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IConfiguration>(Configuration);
            serviceCollection.AddScoped<ManifestRepository>();
        }
    }
}
