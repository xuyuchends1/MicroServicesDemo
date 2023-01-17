using MicroServices;
using MicroServices.Models;
using MicroServices.Repository;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace MicroServicesTests.Integration
{
    public class IntegrationBaseTest
    {
        private readonly HttpClient httpClient;
        public IntegrationBaseTest()
        {
            var application = new WebApplicationFactory<Program>()
    .WithWebHostBuilder(builder =>
    {
        builder.ConfigureServices(services =>
        {
            services.AddScoped<ITeamRepository, MemoryTeamRepository>();
        });
    });
            httpClient = application.CreateClient();
        }

        public async Task<HttpResponseMessage> PostTestAsync(string url, object value)
        {
            var stringContent = new StringContent(
                JsonConvert.SerializeObject(value),
               UnicodeEncoding.UTF8,
               "application/json");
            var response = await httpClient.PostAsync(url, stringContent);
            response.EnsureSuccessStatusCode();
            return response;
        }

        public async Task<T> GetTestAsync<T>(string url)
        {
            var response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            var value = JsonConvert.DeserializeObject<T>(data);
            return value;
        }
    }
}
