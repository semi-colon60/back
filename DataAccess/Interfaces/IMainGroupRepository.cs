namespace dotnet.DataAccess.Interfaces
{
	public interface IMainGroupRepository
	{
		Task<MainGroup> GetByIdAsync(int id);
		Task<IEnumerable<MainGroup>> GetAllAsync();
		Task AddAsync(MainGroup mainGroup);
		Task UpdateAsync(MainGroup mainGroup);
		Task DeleteAsync(int id);

		// Additional get methods
		Task<MainGroup?> GetByNameAsync(string name);
	}
}
