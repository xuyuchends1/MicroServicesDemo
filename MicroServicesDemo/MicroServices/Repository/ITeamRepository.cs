using MicroServices.Models;

namespace MicroServices.Repository
{
    public interface ITeamRepository
    {
        IEnumerable<Team> GetTeams();
        void AddTeam(Team team);
        void Clear();
    }
}
