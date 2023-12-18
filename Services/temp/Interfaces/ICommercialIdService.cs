// using dotnet.DataAccess.Models;

// namespace dotnet.Services.temp.Interfaces
// {
// 	public interface ICommercialIdService
// 	{
// 		Task<CommercialId> GetByIdAsync(int id);
// 		Task<IEnumerable<CommercialId>> GetAllAsync();
// 		Task AddAsync(CommercialId commercialId);
// 		Task UpdateAsync(CommercialId commercialId);
// 		Task DeleteAsync(int id);

// 		// Additional get methods
// 		Task<IEnumerable<CommercialId>> GetByNameAsync(string name);
// 		Task<IEnumerable<CommercialId>> GetBySurnameAsync(string surname);
// 		Task<IEnumerable<CommercialId>> GetByNameAndSurnameAsync(string name, string surname);
// 		Task<IEnumerable<CommercialId>> GetByCommercialTitleAsync(string commercialTitle);
// 		Task<IEnumerable<CommercialId>> GetByPhoneAsync(string phone);
// 		Task GetByEmailAsync(string email);
// 		Task GetByUsernameAsync(string username);

// 		// Additional business logic methods
// 	}
// }