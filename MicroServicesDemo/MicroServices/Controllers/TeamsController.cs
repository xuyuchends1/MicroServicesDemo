using MicroServices.Models;
using MicroServices.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private ITeamRepository _repository;

        public TeamsController(ITeamRepository teamRepository)
        {
            this._repository = teamRepository;
        }
        [HttpGet] 
        public async Task<IActionResult> GetAllTeams()
        {
            return this.Ok(_repository.GetTeams());
        }

        [HttpPost]
        public async Task<IActionResult> AddTeam([FromBody] Team team)
        {
            _repository.AddTeam(team);
            return this.Ok();
        }
    }
}
