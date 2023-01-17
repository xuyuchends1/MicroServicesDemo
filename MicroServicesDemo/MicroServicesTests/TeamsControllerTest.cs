using MicroServices.Controllers;
using MicroServices.Models;
using MicroServices.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var result = (await teamsController.AddTeam(team)) as StatusCodeResult;
            Assert.IsType<OkResult>(result);

            _repository.Clear();
        }
    }
}
