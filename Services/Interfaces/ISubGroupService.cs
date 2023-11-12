using dotnet.DataAccess.Models;

namespace dotnet.Services.Interfaces
{
	public interface ISubGroupService
	{
		Task<SubGroup> GetByIdAsync(int id);
		Task<IEnumerable<SubGroup>> GetAllAsync();
		Task AddAsync(SubGroup subGroup);
		Task UpdateAsync(SubGroup subGroup);
		Task DeleteAsync(int id);

		// Additional get methods
		Task<SubGroup> GetByNameAsync(string name);
		Task<IEnumerable<SubGroup>> GetByMainGroupIdAsync(int mainGroupId);

		// Additional business logic methods
	}
}
