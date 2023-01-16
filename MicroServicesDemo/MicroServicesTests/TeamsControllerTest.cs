using MicroServices.Controllers;
using MicroServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServicesTests
{
    public class TeamsControllerTest
    {
        [Fact]
        public void Test1()
        {
            TeamsController teamsController=new TeamsController();
            List<Team> teams = new List<Team>(teamsController.GetAllTeams());
            Assert.Equal(2, teams.Count);
        }
    }
}
