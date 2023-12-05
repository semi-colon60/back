using dotnet.DataAccess.Interfaces;
using dotnet.Services.Interfaces;

namespace dotnet.Services {
	public class LoginService : ILoginService
	{

		private readonly ICommercialIdRepository _commercialIdRepository;

		public LoginService(ICommercialIdRepository commercialIdRepository)
		{
			_commercialIdRepository = commercialIdRepository;
		}

		public async Task<CommercialId?> GetCommercialIdByEmailAsync(string email, string password)
		{
			var result = await _commercialIdRepository.GetByEmailAsync(email);
			if(result != null && result.Password == password) {
				return result;
			}
			return null;
		}

		public async Task<CommercialId?> GetCommercialIdByUsernameAsync(string username, string password)
		{
			var result = await _commercialIdRepository.GetByUsernameAsync(username);
			if(result != null && result.Password == password) return result;
			else return null;
		}

	}
}