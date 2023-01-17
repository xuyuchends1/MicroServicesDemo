using MicroServices;
using MicroServices.Models;
using MicroServices.Repository;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System.Text;

namespace MicroServicesTests.Integration
{
    public class TeamsControllerTest : IntegrationBaseTest
    {
        [Fact]
        public async Task HelloWorld()
        {
            var team = new Team("one", Guid.NewGuid());
            await PostTestAsync("/api/Teams", team);
            var teams = await GetTestAsync<List<Team>>("/api/Teams");
            Assert.Single(teams);
        }
    }
}
