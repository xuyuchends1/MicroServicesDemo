using MicroServices.Controllers;
using MicroServices.Models;
using MicroServices.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MicroServicesTests
{
    public class TeamsControllerTest
    {
        private ITeamRepository _repository;

        public TeamsControllerTest()
        {
            _repository = new MemoryTeamRepository();
        }

        [Fact]
        public async void CreateTeamAddsTeamToList()
        {
            var teamsController = new TeamsController(_repository);
            var team = new Team("one", Guid.NewGuid());
            var result = (await teamsController.CreateTeam(team)) as StatusCodeResult;
            Assert.IsType<OkResult>(result);

            _repository.Clear();
        }
    }
}
