using dotnet.DataAccess.Models;

namespace dotnet.DataAccess.Interfaces
{
	public interface ISubGroupRepository
	{
		Task<SubGroup> GetByIdAsync(long id);
		Task<IEnumerable<SubGroup>> GetAllAsync();
		Task AddAsync(SubGroup subGroup);
		Task UpdateAsync(SubGroup subGroup);
		Task DeleteAsync(long id);

		// Additional get methods
		Task<SubGroup?> GetByNameAsync(string name);
		Task<IEnumerable<SubGroup>> GetByMainGroupIdAsync(long mainGroupId);
	}
}