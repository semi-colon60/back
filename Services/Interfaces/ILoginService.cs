namespace dotnet.Services.Interfaces
{
	public interface ILoginService
	{
		public Task<CommercialId?> GetCommercialIdByEmailAsync(string email, string password);
		public Task<CommercialId?> GetCommercialIdByUsernameAsync(string username, string password);
	}
}