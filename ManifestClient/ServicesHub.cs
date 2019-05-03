using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ECFDataLayer.Mappings;
using ECFDataLayer.Repositories;
using Microsoft.Extensions.Configuration;

namespace ManifestClient
{
   public class ServicesHub
    {
        private readonly OrderSubmitClient _client;
        private readonly IConfiguration _configuration;
        private readonly IManifestRepository _repository;

        public ServicesHub( OrderSubmitClient client ,IConfiguration configuration, IManifestRepository repository)
        {
            _client = client;
            _configuration = configuration;
            _repository = repository;
        }

        public  async Task<bool> SubmitNextManifest()
        {
            try
            {
                var manifest = _repository.GetFirstManifest();
                return await _client.SendManifest(manifest);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
            
           return false;
        }
    }
}
