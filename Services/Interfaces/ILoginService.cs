using dotnet.Services.DTOs;

namespace dotnet.Services.Interfaces
{
	public interface ILoginService
	{
		public Task<LoginUserDTO?> GetCommercialIdByEmailAsync(string email, string password);
		public Task<LoginUserDTO?> GetCommercialIdByUsernameAsync(string username, string password);
	}
}