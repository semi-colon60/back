namespace dotnet.DataAccess.Interfaces
{
	public interface IMaterialRepository
	{
		Task<Material> GetByIdAsync(long id);
		Task<IEnumerable<Material>> GetAllAsync();
		Task AddAsync(Material material);
		Task UpdateAsync(Material material);
		Task DeleteAsync(long id);

		// Additional get methods
		Task<IEnumerable<Material>> GetByUnitAsync(UnitType unit);
		Task<IEnumerable<Material>> GetByMainGroupIdAsync(long mainGroupId);
		Task<IEnumerable<Material>> GetBySubGroupIdAsync(long subGroupId);
	}
}
