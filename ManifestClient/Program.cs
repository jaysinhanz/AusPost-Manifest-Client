using System;
using System.Threading.Tasks;
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
            .AddUserSecrets<Program>()
            .Build();
        static async Task  Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var factory = serviceProvider.GetService<ServicesHub>();
            var x = await factory.SubmitNextManifest();
        }

        private static void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IConfiguration>(Configuration);
            serviceCollection.AddScoped<IManifestRepository,ManifestRepository>();
            // Add Named HttpClient factory
            serviceCollection.AddHttpClient<OrderSubmitClient>();
            serviceCollection.AddTransient<ServicesHub>();
        }
    }
}
