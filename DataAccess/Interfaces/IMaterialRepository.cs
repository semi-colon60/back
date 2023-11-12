using dotnet.DataAccess.Models;

namespace dotnet.DataAccess.Interfaces
{
	public interface IMaterialRepository
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
	}
}
