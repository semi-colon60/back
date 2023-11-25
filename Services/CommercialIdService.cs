using dotnet.DataAccess.Interfaces;
using dotnet.DataAccess.Repositories;
using dotnet.Services.Interfaces;

namespace dotnet.Services
{
	public class CommercialIdService : ICommercialIdService 
	{
		private readonly ICommercialIdRepository _commercialIdRepository;

		public CommercialIdService(ICommercialIdRepository commercialIdRepository)
		{
			_commercialIdRepository = commercialIdRepository;
		}

		public async Task<CommercialId> GetByIdAsync(int id)
		{
			return await _commercialIdRepository.GetByIdAsync(id);
		}

		public async Task<IEnumerable<CommercialId>> GetAllAsync()
		{
			return await _commercialIdRepository.GetAllAsync();
		}

		public async Task AddAsync(CommercialId commercialId)
		{
			await _commercialIdRepository.AddAsync(commercialId);
		}

		public async Task UpdateAsync(CommercialId commercialId)
		{
			await _commercialIdRepository.UpdateAsync(commercialId);
		}

		public async Task DeleteAsync(int id)
		{
			await _commercialIdRepository.DeleteAsync(id);
		}

		// Additional get methods
		public async Task<IEnumerable<CommercialId>> GetByNameAsync(string name)
		{
			return await _commercialIdRepository.GetByNameAsync(name);
		}

		public async Task<IEnumerable<CommercialId>> GetBySurnameAsync(string surname)
		{
			return await _commercialIdRepository.GetBySurnameAsync(surname);
		}

		public async Task<IEnumerable<CommercialId>> GetByNameAndSurnameAsync(string name, string surname)
		{
			return await _commercialIdRepository.GetByNameAndSurnameAsync(name, surname);
		}

		public async Task<IEnumerable<CommercialId>> GetByCommercialTitleAsync(string commercialTitle)
		{
			return await _commercialIdRepository.GetByCommercialTitleAsync(commercialTitle);
		}

		public async Task<IEnumerable<CommercialId>> GetByPhoneAsync(string phone)
		{
			return await _commercialIdRepository.GetByPhoneAsync(phone);
		}

		public async Task<IEnumerable<CommercialId>> GetByEmailAsync(string email)
		{
			return await _commercialIdRepository.GetByEmailAsync(email);
		}

		public async Task<CommercialId> GetByUsernameAsync(string username)
		{
			return await _commercialIdRepository.GetByUsernameAsync(username);
		}
	}
}