using dotnet.Services.DTOs;

namespace dotnet.Services.Interfaces
{
	public interface ILoginService
	{
		public Task<LoginUserDTO?> GetByEmailAsync(string email, string password);
		public Task<LoginUserDTO?> GetByUsernameAsync(string username, string password);
	}
}