using MicroServices.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        [HttpGet] 
        public IEnumerable<Team> GetAllTeams()
        {
            return new List<Team>() { new Team("one"), new Team("two") };
        }
    }
}
