using MicroServices.Models;

namespace MicroServices.Repository
{
    public class MemoryTeamRepository : ITeamRepository
    {
        protected static ICollection<Team> Teams; 

        public MemoryTeamRepository()
        {
            if (Teams == null)
            {
                Teams = new List<Team>();
            }
        }
        public MemoryTeamRepository(ICollection<Team> teams)
        {
            Teams = teams;
        }

        public void AddTeam(Team team)
        {
           Teams.Add(team);
        }

        public IEnumerable<Team> GetTeams()
        {
            return Teams;
        }
    }
}
