namespace dotnet.DataAccess.Interfaces
{
	public interface ICommercialIdRepository
	{
		Task<CommercialId> GetByIdAsync(Int64 id);
		Task<IEnumerable<CommercialId>> GetAllAsync();
		Task AddAsync(CommercialId commercialId);
		Task UpdateAsync(CommercialId commercialId);
		Task DeleteAsync(Int64 id);

		// Additional get methods
		Task<IEnumerable<CommercialId>> GetByNameAsync(string name);
		Task<IEnumerable<CommercialId>> GetBySurnameAsync(string surname);
		Task<IEnumerable<CommercialId>> GetByNameAndSurnameAsync(string name, string surname);
		Task<IEnumerable<CommercialId>> GetByCommercialTitleAsync(string commercialTitle);
		Task<IEnumerable<CommercialId>> GetByPhoneAsync(string phone);
		Task<CommercialId?> GetByEmailAsync(string email);
		Task<CommercialId?> GetByUsernameAsync(string username);
	}
}
