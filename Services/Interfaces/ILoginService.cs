namespace dotnet.Services.Interfaces
{
	public interface ILoginService
	{
		public Task<CommercialId?> GetByEmailAsync(string email, string password);
		public Task<CommercialId?> GetByUsernameAsync(string username, string password);
	}
}