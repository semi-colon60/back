using dotnet.DataAccess.Models;

namespace dotnet.Services.Interfaces
{
	public interface IMaterialService
	{
		Task<Material> GetByIdAsync(int id);
		Task<IEnumerable<Material>> GetAllAsync();
		Task AddAsync(Material material);
		Task UpdateAsync(Material material);
		Task DeleteAsync(int id);

		// Additional get methods
		Task<IEnumerable<Material>> GetByUnitAsync(UnitType unit);
		Task<IEnumerable<Material>> GetByMainGroupIdAsync(int mainGroupId);
		Task<IEnumerable<Material>> GetBySubGroupIdAsync(int subGroupId);

		// Additional business logic methods
	}
}