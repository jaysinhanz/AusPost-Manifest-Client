using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ECFDataLayer.Mappings;
using Newtonsoft.Json;

namespace ManifestClient
{
    public class OrderSubmitClient
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public OrderSubmitClient(HttpClient httpClient,IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _httpClient.BaseAddress = new Uri("https://digitalapi.auspost.com.au");
            _httpClient.Timeout = new TimeSpan(0, 0, 30);
            _httpClient.DefaultRequestHeaders.Clear();
        }
        
        public async Task<bool> SendManifest(Order manifest)
        {
            // set up request 
            var ac = _configuration.GetValue<string>("AusPostAccountNo");
            var authKey = _configuration.GetValue<string>("authKey");
            // convert authKey to byte Array
            Byte[] byteArray = new UTF8Encoding().GetBytes(authKey);
            // convert the byte array to string64
            var string64Auth = Convert.ToBase64String(byteArray);
            var request = new HttpRequestMessage(HttpMethod.Post, "test/shipping/v1/orders");
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.Add("Account-Number",ac);
            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", string64Auth);
           // request.Content.Headers.ContentType= new MediaTypeHeaderValue("application/json");
            var json = JsonConvert.SerializeObject(manifest);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead))
            {

                var ret = response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : string.Empty;
                
                try
                {
                    response.EnsureSuccessStatusCode();
                }
                catch (Exception e)
                {
                   
                    return false;
                }

                return true;
            }


        }

    }
}