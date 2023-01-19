using MicroServices.Models;

namespace MicroServices.Repository
{
	public interface ITeamRepository {
	    IEnumerable<Team> List();
		Team Get(Guid id);
		Team Add(Team team);
		Team Update(Team team);		
		Team Delete(Guid id);
		void Clear();
    }
}