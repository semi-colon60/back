using System.Formats.Asn1;
using dotnet.DataAccess.Interfaces;
using dotnet.Services.DTOs;
using dotnet.Services.Interfaces;

namespace dotnet.Services {
	public class LoginService : ILoginService
	{

		private readonly ICommercialIdRepository _commercialIdRepository;

		public LoginService(ICommercialIdRepository commercialIdRepository)
		{
			_commercialIdRepository = commercialIdRepository;
		}

		public async Task<LoginUserDTO?> GetCommercialIdByEmailAsync(string email, string password)
		{
			var result = await _commercialIdRepository.GetByEmailAsync(email);
			var loginUserDTO = new LoginUserDTO(result.IsAdmin, result.CommercialID);
			if(result != null && result.Password == password) {
				return loginUserDTO;
			}
			return null;
		}

		public async Task<LoginUserDTO?> GetCommercialIdByUsernameAsync(string username, string password)
		{
			var result = await _commercialIdRepository.GetByUsernameAsync(username);
			var loginUserDTO = new LoginUserDTO(result.IsAdmin, result.CommercialID);
			if(result != null && result.Password == password) {
				return loginUserDTO;
			}
			return null;
		}

	}
}